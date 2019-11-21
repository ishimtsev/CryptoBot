namespace CryptoBot
{
	partial class NewOrder
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewOrder));
			this.TestRadioButton = new System.Windows.Forms.RadioButton();
			this.NotTestRadioButton = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SymbolChoiceComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.GTCradioButton = new System.Windows.Forms.RadioButton();
			this.IOCradioButton = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.LimitRadioButton = new System.Windows.Forms.RadioButton();
			this.MarketRadioButton = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.PriceTextBox = new System.Windows.Forms.TextBox();
			this.QuantityTextBox = new System.Windows.Forms.TextBox();
			this.OKbutton = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.BuyRadioButton = new System.Windows.Forms.RadioButton();
			this.SellRadioButton = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// TestRadioButton
			// 
			this.TestRadioButton.AutoSize = true;
			this.TestRadioButton.Checked = true;
			this.TestRadioButton.Location = new System.Drawing.Point(6, 21);
			this.TestRadioButton.Name = "TestRadioButton";
			this.TestRadioButton.Size = new System.Drawing.Size(48, 21);
			this.TestRadioButton.TabIndex = 0;
			this.TestRadioButton.TabStop = true;
			this.TestRadioButton.Text = "Да";
			this.TestRadioButton.UseVisualStyleBackColor = true;
			this.TestRadioButton.CheckedChanged += new System.EventHandler(this.Check_Changed);
			// 
			// NotTestRadioButton
			// 
			this.NotTestRadioButton.AutoSize = true;
			this.NotTestRadioButton.Location = new System.Drawing.Point(6, 48);
			this.NotTestRadioButton.Name = "NotTestRadioButton";
			this.NotTestRadioButton.Size = new System.Drawing.Size(54, 21);
			this.NotTestRadioButton.TabIndex = 0;
			this.NotTestRadioButton.Text = "Нет";
			this.NotTestRadioButton.UseVisualStyleBackColor = true;
			this.NotTestRadioButton.CheckedChanged += new System.EventHandler(this.Check_Changed);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TestRadioButton);
			this.groupBox1.Controls.Add(this.NotTestRadioButton);
			this.groupBox1.ForeColor = System.Drawing.Color.Red;
			this.groupBox1.Location = new System.Drawing.Point(25, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(143, 79);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Тестовый режим";
			// 
			// SymbolChoiceComboBox
			// 
			this.SymbolChoiceComboBox.FormattingEnabled = true;
			this.SymbolChoiceComboBox.Location = new System.Drawing.Point(25, 149);
			this.SymbolChoiceComboBox.Name = "SymbolChoiceComboBox";
			this.SymbolChoiceComboBox.Size = new System.Drawing.Size(143, 24);
			this.SymbolChoiceComboBox.TabIndex = 2;
			this.SymbolChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.Check_Changed);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 129);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(114, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Валютная пара:";
			// 
			// GTCradioButton
			// 
			this.GTCradioButton.AutoSize = true;
			this.GTCradioButton.Checked = true;
			this.GTCradioButton.Location = new System.Drawing.Point(6, 21);
			this.GTCradioButton.Name = "GTCradioButton";
			this.GTCradioButton.Size = new System.Drawing.Size(58, 21);
			this.GTCradioButton.TabIndex = 4;
			this.GTCradioButton.TabStop = true;
			this.GTCradioButton.Text = "GTC";
			this.GTCradioButton.UseVisualStyleBackColor = true;
			this.GTCradioButton.CheckedChanged += new System.EventHandler(this.Check_Changed);
			// 
			// IOCradioButton
			// 
			this.IOCradioButton.AutoSize = true;
			this.IOCradioButton.Location = new System.Drawing.Point(6, 48);
			this.IOCradioButton.Name = "IOCradioButton";
			this.IOCradioButton.Size = new System.Drawing.Size(52, 21);
			this.IOCradioButton.TabIndex = 4;
			this.IOCradioButton.Text = "IOC";
			this.IOCradioButton.UseVisualStyleBackColor = true;
			this.IOCradioButton.CheckedChanged += new System.EventHandler(this.Check_Changed);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.GTCradioButton);
			this.groupBox2.Controls.Add(this.IOCradioButton);
			this.groupBox2.Location = new System.Drawing.Point(207, 111);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(143, 80);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Тип";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.LimitRadioButton);
			this.groupBox3.Controls.Add(this.MarketRadioButton);
			this.groupBox3.Location = new System.Drawing.Point(207, 208);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(143, 80);
			this.groupBox3.TabIndex = 5;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Тип ордера";
			// 
			// LimitRadioButton
			// 
			this.LimitRadioButton.AutoSize = true;
			this.LimitRadioButton.Checked = true;
			this.LimitRadioButton.Location = new System.Drawing.Point(6, 21);
			this.LimitRadioButton.Name = "LimitRadioButton";
			this.LimitRadioButton.Size = new System.Drawing.Size(97, 21);
			this.LimitRadioButton.TabIndex = 4;
			this.LimitRadioButton.TabStop = true;
			this.LimitRadioButton.Text = "Лимитный";
			this.LimitRadioButton.UseVisualStyleBackColor = true;
			this.LimitRadioButton.CheckedChanged += new System.EventHandler(this.Check_Changed);
			// 
			// MarketRadioButton
			// 
			this.MarketRadioButton.AutoSize = true;
			this.MarketRadioButton.Location = new System.Drawing.Point(6, 48);
			this.MarketRadioButton.Name = "MarketRadioButton";
			this.MarketRadioButton.Size = new System.Drawing.Size(98, 21);
			this.MarketRadioButton.TabIndex = 4;
			this.MarketRadioButton.Text = "Рыночный";
			this.MarketRadioButton.UseVisualStyleBackColor = true;
			this.MarketRadioButton.CheckedChanged += new System.EventHandler(this.Check_Changed);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(28, 188);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 17);
			this.label2.TabIndex = 6;
			this.label2.Text = "Цена:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(28, 246);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Количество:";
			// 
			// PriceTextBox
			// 
			this.PriceTextBox.Location = new System.Drawing.Point(25, 208);
			this.PriceTextBox.Name = "PriceTextBox";
			this.PriceTextBox.Size = new System.Drawing.Size(143, 22);
			this.PriceTextBox.TabIndex = 8;
			this.PriceTextBox.Text = "0.002";
			this.PriceTextBox.TextChanged += new System.EventHandler(this.Check_Changed);
			// 
			// QuantityTextBox
			// 
			this.QuantityTextBox.Location = new System.Drawing.Point(25, 266);
			this.QuantityTextBox.Name = "QuantityTextBox";
			this.QuantityTextBox.Size = new System.Drawing.Size(143, 22);
			this.QuantityTextBox.TabIndex = 9;
			this.QuantityTextBox.Text = "0.002";
			this.QuantityTextBox.TextChanged += new System.EventHandler(this.Check_Changed);
			// 
			// OKbutton
			// 
			this.OKbutton.Enabled = false;
			this.OKbutton.Location = new System.Drawing.Point(118, 322);
			this.OKbutton.Name = "OKbutton";
			this.OKbutton.Size = new System.Drawing.Size(143, 38);
			this.OKbutton.TabIndex = 10;
			this.OKbutton.Text = "OK";
			this.OKbutton.UseVisualStyleBackColor = true;
			this.OKbutton.Click += new System.EventHandler(this.OKbutton_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.BuyRadioButton);
			this.groupBox4.Controls.Add(this.SellRadioButton);
			this.groupBox4.Location = new System.Drawing.Point(207, 27);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(143, 72);
			this.groupBox4.TabIndex = 5;
			this.groupBox4.TabStop = false;
			// 
			// BuyRadioButton
			// 
			this.BuyRadioButton.AutoSize = true;
			this.BuyRadioButton.Checked = true;
			this.BuyRadioButton.Location = new System.Drawing.Point(6, 15);
			this.BuyRadioButton.Name = "BuyRadioButton";
			this.BuyRadioButton.Size = new System.Drawing.Size(75, 21);
			this.BuyRadioButton.TabIndex = 4;
			this.BuyRadioButton.TabStop = true;
			this.BuyRadioButton.Text = "Купить";
			this.BuyRadioButton.UseVisualStyleBackColor = true;
			this.BuyRadioButton.CheckedChanged += new System.EventHandler(this.Check_Changed);
			// 
			// SellRadioButton
			// 
			this.SellRadioButton.AutoSize = true;
			this.SellRadioButton.Location = new System.Drawing.Point(6, 42);
			this.SellRadioButton.Name = "SellRadioButton";
			this.SellRadioButton.Size = new System.Drawing.Size(85, 21);
			this.SellRadioButton.TabIndex = 4;
			this.SellRadioButton.Text = "Продать";
			this.SellRadioButton.UseVisualStyleBackColor = true;
			this.SellRadioButton.CheckedChanged += new System.EventHandler(this.Check_Changed);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(409, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(410, 366);
			this.textBox1.TabIndex = 11;
			// 
			// NewOrder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 390);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.OKbutton);
			this.Controls.Add(this.QuantityTextBox);
			this.Controls.Add(this.PriceTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SymbolChoiceComboBox);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "NewOrder";
			this.Text = "Новый ордер";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton TestRadioButton;
		private System.Windows.Forms.RadioButton NotTestRadioButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox SymbolChoiceComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton GTCradioButton;
		private System.Windows.Forms.RadioButton IOCradioButton;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton LimitRadioButton;
		private System.Windows.Forms.RadioButton MarketRadioButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PriceTextBox;
		private System.Windows.Forms.TextBox QuantityTextBox;
		private System.Windows.Forms.Button OKbutton;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.RadioButton BuyRadioButton;
		private System.Windows.Forms.RadioButton SellRadioButton;
		private System.Windows.Forms.TextBox textBox1;
	}
}