namespace CryptoBot
{
	partial class Account
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
			this.AccInfoButton = new System.Windows.Forms.Button();
			this.TradeListButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SymbolChoiceComboBox = new System.Windows.Forms.ComboBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AccInfoButton
			// 
			this.AccInfoButton.Location = new System.Drawing.Point(44, 65);
			this.AccInfoButton.Name = "AccInfoButton";
			this.AccInfoButton.Size = new System.Drawing.Size(150, 44);
			this.AccInfoButton.TabIndex = 0;
			this.AccInfoButton.Text = "Информация об аккаунте";
			this.AccInfoButton.UseVisualStyleBackColor = true;
			this.AccInfoButton.Click += new System.EventHandler(this.AccInfoButton_Click);
			// 
			// TradeListButton
			// 
			this.TradeListButton.Enabled = false;
			this.TradeListButton.Location = new System.Drawing.Point(12, 78);
			this.TradeListButton.Name = "TradeListButton";
			this.TradeListButton.Size = new System.Drawing.Size(150, 44);
			this.TradeListButton.TabIndex = 0;
			this.TradeListButton.Text = "Посмотреть";
			this.TradeListButton.UseVisualStyleBackColor = true;
			this.TradeListButton.Click += new System.EventHandler(this.TradeListButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.SymbolChoiceComboBox);
			this.groupBox1.Controls.Add(this.TradeListButton);
			this.groupBox1.Location = new System.Drawing.Point(32, 243);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(175, 135);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Список сделок";
			// 
			// SymbolChoiceComboBox
			// 
			this.SymbolChoiceComboBox.FormattingEnabled = true;
			this.SymbolChoiceComboBox.Location = new System.Drawing.Point(12, 30);
			this.SymbolChoiceComboBox.Name = "SymbolChoiceComboBox";
			this.SymbolChoiceComboBox.Size = new System.Drawing.Size(150, 24);
			this.SymbolChoiceComboBox.TabIndex = 2;
			this.SymbolChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.SymbolChoiceComboBox_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(247, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(345, 407);
			this.textBox1.TabIndex = 3;
			// 
			// Account
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(604, 431);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.AccInfoButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Account";
			this.Text = "Аккаунт";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AccInfoButton;
		private System.Windows.Forms.Button TradeListButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox SymbolChoiceComboBox;
		private System.Windows.Forms.TextBox textBox1;
	}
}