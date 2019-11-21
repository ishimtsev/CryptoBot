namespace CryptoBot
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.OrderBookStartButton = new System.Windows.Forms.Button();
			this.SymbolsPriceTickerStartButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.OrdersStartButton = new System.Windows.Forms.Button();
			this.AccountStartButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.APIkeysStartButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// OrderBookStartButton
			// 
			this.OrderBookStartButton.Location = new System.Drawing.Point(44, 44);
			this.OrderBookStartButton.Name = "OrderBookStartButton";
			this.OrderBookStartButton.Size = new System.Drawing.Size(143, 54);
			this.OrderBookStartButton.TabIndex = 3;
			this.OrderBookStartButton.Text = "Стакан для валютной пары";
			this.OrderBookStartButton.UseVisualStyleBackColor = true;
			this.OrderBookStartButton.Click += new System.EventHandler(this.OrderBookStartButton_Click);
			// 
			// SymbolsPriceTickerStartButton
			// 
			this.SymbolsPriceTickerStartButton.Location = new System.Drawing.Point(227, 44);
			this.SymbolsPriceTickerStartButton.Name = "SymbolsPriceTickerStartButton";
			this.SymbolsPriceTickerStartButton.Size = new System.Drawing.Size(143, 54);
			this.SymbolsPriceTickerStartButton.TabIndex = 3;
			this.SymbolsPriceTickerStartButton.Text = "Последняя цена каждой пары";
			this.SymbolsPriceTickerStartButton.UseVisualStyleBackColor = true;
			this.SymbolsPriceTickerStartButton.Click += new System.EventHandler(this.SymbolsPriceTickerStartButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.OrdersStartButton);
			this.groupBox1.Controls.Add(this.AccountStartButton);
			this.groupBox1.Location = new System.Drawing.Point(28, 267);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(357, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			// 
			// OrdersStartButton
			// 
			this.OrdersStartButton.Location = new System.Drawing.Point(16, 21);
			this.OrdersStartButton.Name = "OrdersStartButton";
			this.OrdersStartButton.Size = new System.Drawing.Size(143, 54);
			this.OrdersStartButton.TabIndex = 3;
			this.OrdersStartButton.Text = "Ордеры";
			this.OrdersStartButton.UseVisualStyleBackColor = true;
			this.OrdersStartButton.Click += new System.EventHandler(this.OrdersStartButton_Click);
			// 
			// AccountStartButton
			// 
			this.AccountStartButton.Location = new System.Drawing.Point(199, 21);
			this.AccountStartButton.Name = "AccountStartButton";
			this.AccountStartButton.Size = new System.Drawing.Size(143, 54);
			this.AccountStartButton.TabIndex = 3;
			this.AccountStartButton.Text = "Информация об аккаунте";
			this.AccountStartButton.UseVisualStyleBackColor = true;
			this.AccountStartButton.Click += new System.EventHandler(this.AccountStartButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(54, 176);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(307, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Для остальных действий требуется API ключ";
			// 
			// APIkeysStartButton
			// 
			this.APIkeysStartButton.Location = new System.Drawing.Point(28, 211);
			this.APIkeysStartButton.Name = "APIkeysStartButton";
			this.APIkeysStartButton.Size = new System.Drawing.Size(357, 33);
			this.APIkeysStartButton.TabIndex = 6;
			this.APIkeysStartButton.Text = "Добавить API ключ";
			this.APIkeysStartButton.UseVisualStyleBackColor = true;
			this.APIkeysStartButton.Click += new System.EventHandler(this.APIkeysStartButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 392);
			this.Controls.Add(this.APIkeysStartButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.SymbolsPriceTickerStartButton);
			this.Controls.Add(this.OrderBookStartButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "CryptoBot";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button OrderBookStartButton;
		private System.Windows.Forms.Button SymbolsPriceTickerStartButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button AccountStartButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button APIkeysStartButton;
		private System.Windows.Forms.Button OrdersStartButton;
	}
}

