# winforms-wasm
WIP testing ground for a mono Windows Forms + mono mwf-designer WebAssembly port. This branch will probably eventually be moved. 

## `System.Windows.Forms.dll`
- Patched Mono Windows Forms with a SDL3 backend for WebAssembly is at https://github.com/r58Playz/mono-winforms-wasm in `mcs/class/System.Windows.Forms`.
- Windows Forms heavily depends on `System.Drawing.Common`, which is implemented by mono with `libgdiplus`
  - `libgdiplus` depends on cairo, fontconfig, glib, etc
  - These libraries are built at https://github.com/r58playz/fna-wasm-build
