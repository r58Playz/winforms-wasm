using System.Windows.Forms;

partial class App {
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose(bool disposing)
	{
		if (disposing && (components != null))
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		this.testScore1Label = new System.Windows.Forms.Label();
		this.testScore1Input = new System.Windows.Forms.NumericUpDown();
		this.testScore2Input = new System.Windows.Forms.NumericUpDown();
		this.testScore2Label = new System.Windows.Forms.Label();
		this.testScore3Input = new System.Windows.Forms.NumericUpDown();
		this.testScore3Label = new System.Windows.Forms.Label();
		this.averageOutput = new System.Windows.Forms.NumericUpDown();
		this.averageLabel = new System.Windows.Forms.Label();
		this.calculateButton = new System.Windows.Forms.Button();
		this.exitButton = new System.Windows.Forms.Button();
		((System.ComponentModel.ISupportInitialize)(this.testScore1Input)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.testScore2Input)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.testScore3Input)).BeginInit();
		((System.ComponentModel.ISupportInitialize)(this.averageOutput)).BeginInit();
		this.SuspendLayout();
		// 
		// testScore1Label
		// 
		this.testScore1Label.AutoSize = true;
		this.testScore1Label.Location = new System.Drawing.Point(12, 9);
		this.testScore1Label.Name = "testScore1Label";
		this.testScore1Label.Size = new System.Drawing.Size(68, 15);
		this.testScore1Label.TabIndex = 0;
		this.testScore1Label.Text = "Test Score 1";
		// 
		// testScore1Input
		// 
		this.testScore1Input.DecimalPlaces = 2;
		this.testScore1Input.Increment = new decimal(new int[] {
		1,
		0,
		0,
		131072});
		this.testScore1Input.Location = new System.Drawing.Point(105, 9);
		this.testScore1Input.Name = "testScore1Input";
		this.testScore1Input.Size = new System.Drawing.Size(82, 23);
		this.testScore1Input.TabIndex = 1;
		// 
		// testScore2Input
		// 
		this.testScore2Input.DecimalPlaces = 2;
		this.testScore2Input.Increment = new decimal(new int[] {
		1,
		0,
		0,
		131072});
		this.testScore2Input.Location = new System.Drawing.Point(105, 38);
		this.testScore2Input.Name = "testScore2Input";
		this.testScore2Input.Size = new System.Drawing.Size(82, 23);
		this.testScore2Input.TabIndex = 3;
		// 
		// testScore2Label
		// 
		this.testScore2Label.AutoSize = true;
		this.testScore2Label.Location = new System.Drawing.Point(12, 38);
		this.testScore2Label.Name = "testScore2Label";
		this.testScore2Label.Size = new System.Drawing.Size(68, 15);
		this.testScore2Label.TabIndex = 2;
		this.testScore2Label.Text = "Test Score 2";
		// 
		// testScore3Input
		// 
		this.testScore3Input.DecimalPlaces = 2;
		this.testScore3Input.Increment = new decimal(new int[] {
		1,
		0,
		0,
		131072});
		this.testScore3Input.Location = new System.Drawing.Point(105, 67);
		this.testScore3Input.Name = "testScore3Input";
		this.testScore3Input.Size = new System.Drawing.Size(82, 23);
		this.testScore3Input.TabIndex = 5;
		// 
		// testScore3Label
		// 
		this.testScore3Label.AutoSize = true;
		this.testScore3Label.Location = new System.Drawing.Point(12, 67);
		this.testScore3Label.Name = "testScore3Label";
		this.testScore3Label.Size = new System.Drawing.Size(68, 15);
		this.testScore3Label.TabIndex = 4;
		this.testScore3Label.Text = "Test Score 3";
		// 
		// averageOutput
		// 
		this.averageOutput.DecimalPlaces = 2;
		this.averageOutput.Increment = new decimal(new int[] {
		1,
		0,
		0,
		131072});
		this.averageOutput.Location = new System.Drawing.Point(105, 96);
		this.averageOutput.Name = "averageOutput";
		this.averageOutput.ReadOnly = true;
		this.averageOutput.Size = new System.Drawing.Size(82, 23);
		this.averageOutput.TabIndex = 7;
		// 
		// averageLabel
		// 
		this.averageLabel.AutoSize = true;
		this.averageLabel.Location = new System.Drawing.Point(30, 96);
		this.averageLabel.Name = "averageLabel";
		this.averageLabel.Size = new System.Drawing.Size(50, 15);
		this.averageLabel.TabIndex = 6;
		this.averageLabel.Text = "Average";
		// 
		// calculateButton
		// 
		this.calculateButton.Location = new System.Drawing.Point(12, 123);
		this.calculateButton.Name = "calculateButton";
		this.calculateButton.Size = new System.Drawing.Size(82, 23);
		this.calculateButton.TabIndex = 8;
		this.calculateButton.Text = "Calculate";
		this.calculateButton.UseVisualStyleBackColor = true;
		this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
		// 
		// exitButton
		// 
		this.exitButton.Location = new System.Drawing.Point(105, 123);
		this.exitButton.Name = "exitButton";
		this.exitButton.Size = new System.Drawing.Size(82, 23);
		this.exitButton.TabIndex = 9;
		this.exitButton.Text = "Exit";
		this.exitButton.UseVisualStyleBackColor = true;
		this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
		// 
		// TestAverage
		// 
		this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
		this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.ClientSize = new System.Drawing.Size(199, 152);
		this.Controls.Add(this.exitButton);
		this.Controls.Add(this.calculateButton);
		this.Controls.Add(this.averageOutput);
		this.Controls.Add(this.averageLabel);
		this.Controls.Add(this.testScore3Input);
		this.Controls.Add(this.testScore3Label);
		this.Controls.Add(this.testScore2Input);
		this.Controls.Add(this.testScore2Label);
		this.Controls.Add(this.testScore1Input);
		this.Controls.Add(this.testScore1Label);
		this.Name = "TestAverage";
		this.Text = "Test Averages";
		((System.ComponentModel.ISupportInitialize)(this.testScore1Input)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.testScore2Input)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.testScore3Input)).EndInit();
		((System.ComponentModel.ISupportInitialize)(this.averageOutput)).EndInit();
		this.ResumeLayout(false);
		this.PerformLayout();

	}

	#endregion

	private Label testScore1Label;
	private NumericUpDown testScore1Input;
	private NumericUpDown testScore2Input;
	private Label testScore2Label;
	private NumericUpDown testScore3Input;
	private Label testScore3Label;
	private NumericUpDown averageOutput;
	private Label averageLabel;
	private Button calculateButton;
	private Button exitButton;
}
