using System;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.JavaScript;

static partial class WinformsWasm
{
	internal static string FONTCONFIG_CFG = """
	<?xml version="1.0"?>
	<!DOCTYPE fontconfig SYSTEM "urn:fontconfig:fonts.dtd">
	<fontconfig>
		<dir>/usr/share/fonts</dir>
		<cachedir>/var/cache/fontconfig</cachedir>
	</fontconfig>
	""";

    static void Main()
    {
        Console.WriteLine(":3");
    }

    [JSExport]
    internal static async Task PreInit(string fetchbase)
    {
		Emscripten.MountOpfs();
		Emscripten.MountFetch(fetchbase + "/assets", "/assets");

		// sdl3
		Directory.CreateDirectory("/tmp/filedrop");

		Directory.CreateDirectory("/etc/fonts");
		File.WriteAllText("/etc/fonts/fonts.conf", FONTCONFIG_CFG);
		Directory.CreateDirectory("/usr/share/fonts");
		Directory.CreateDirectory("/var/cache/fontconfig");
		Emscripten.MountFetchFile("/assets/micross.ttf");
		File.CreateSymbolicLink("/usr/share/fonts/MSSansSerif.ttf", "/assets/micross.ttf");
		Emscripten.MountFetchFile("/assets/tahoma.ttf");
		File.CreateSymbolicLink("/usr/share/fonts/Tahoma.ttf", "/assets/tahoma.ttf");

		Application.ThreadException += (sender, e) => {
			Console.WriteLine($"[APP ERROR] {e.Exception}");
		};
    }

    [JSExport]
    internal static Task Run()
    {
        try
        {
            System.Drawing.GDIPlus.InitGdiPlus();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Application.MainLoopRunner = (iteration) => {
				try {
					return Emscripten.RunEmLoop(() => {
						try {
							bool iter = iteration();
							return iter;
						} catch(Exception e) {
							Console.Error.WriteLine("Error in iteration()!");
							Console.Error.WriteLine($"{e}");
							throw;
						}
					});
				} catch (Exception e) {
					Console.Error.WriteLine("Error in MainLoopRunner()!");
					Console.Error.WriteLine($"{e}");
					return Task.FromException(e);
				}
			};
			return Application.RunAsync(new App());
        }
        catch (Exception e)
        {
            Console.Error.WriteLine("Error in Run()!");
            Console.Error.WriteLine($"{e}");
			return Task.FromException(e);
        }
    }
}
