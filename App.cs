using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public partial class App : Form
{
    public App()
    {
		Console.WriteLine("123");
        InitializeComponent();
    }

	private void calculateButton_Click(object sender, EventArgs e)
	{
		decimal testScore1 = this.testScore1Input.Value, testScore2 = this.testScore2Input.Value, testScore3 = this.testScore3Input.Value;
		decimal avg = (testScore1 + testScore2 + testScore3) / 3;
		this.averageOutput.Value = avg;
	}

	private void exitButton_Click(object sender, EventArgs e)
	{
		this.Close();
	}
}
