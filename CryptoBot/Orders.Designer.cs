namespace CryptoBot
{
	partial class Orders
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
			this.OrdersListBox = new System.Windows.Forms.ListBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.NewOrderStartButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.AllOrdersRadioButton = new System.Windows.Forms.RadioButton();
			this.CurrentOrdersRadioButton = new System.Windows.Forms.RadioButton();
			this.SymbolChoiceComboBox = new System.Windows.Forms.ComboBox();
			this.QueryOrderStartButton = new System.Windows.Forms.Button();
			this.CancelOrderStartButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// OrdersListBox
			// 
			this.OrdersListBox.FormattingEnabled = true;
			this.OrdersListBox.ItemHeight = 16;
			this.OrdersListBox.Location = new System.Drawing.Point(298, 12);
			this.OrdersListBox.Name = "OrdersListBox";
			this.OrdersListBox.Size = new System.Drawing.Size(169, 436);
			this.OrdersListBox.TabIndex = 0;
			this.OrdersListBox.SelectedIndexChanged += new System.EventHandler(this.OrdersListBox_SelectedIndexChanged);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(473, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(311, 480);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(74, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Пара:";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(298, 454);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 38);
			this.button1.TabIndex = 3;
			this.button1.Text = "Обновить список";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// NewOrderStartButton
			// 
			this.NewOrderStartButton.Enabled = false;
			this.NewOrderStartButton.Location = new System.Drawing.Point(47, 438);
			this.NewOrderStartButton.Name = "NewOrderStartButton";
			this.NewOrderStartButton.Size = new System.Drawing.Size(198, 52);
			this.NewOrderStartButton.TabIndex = 4;
			this.NewOrderStartButton.Text = "Новый ордер";
			this.NewOrderStartButton.UseVisualStyleBackColor = true;
			this.NewOrderStartButton.Click += new System.EventHandler(this.NewOrderStartButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.AllOrdersRadioButton);
			this.groupBox1.Controls.Add(this.CurrentOrdersRadioButton);
			this.groupBox1.Location = new System.Drawing.Point(77, 119);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(137, 77);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Тип ордеров";
			// 
			// AllOrdersRadioButton
			// 
			this.AllOrdersRadioButton.AutoSize = true;
			this.AllOrdersRadioButton.Checked = true;
			this.AllOrdersRadioButton.Location = new System.Drawing.Point(6, 48);
			this.AllOrdersRadioButton.Name = "AllOrdersRadioButton";
			this.AllOrdersRadioButton.Size = new System.Drawing.Size(53, 21);
			this.AllOrdersRadioButton.TabIndex = 7;
			this.AllOrdersRadioButton.TabStop = true;
			this.AllOrdersRadioButton.Text = "Все";
			this.AllOrdersRadioButton.UseVisualStyleBackColor = true;
			this.AllOrdersRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// CurrentOrdersRadioButton
			// 
			this.CurrentOrdersRadioButton.AutoSize = true;
			this.CurrentOrdersRadioButton.Location = new System.Drawing.Point(6, 21);
			this.CurrentOrdersRadioButton.Name = "CurrentOrdersRadioButton";
			this.CurrentOrdersRadioButton.Size = new System.Drawing.Size(97, 21);
			this.CurrentOrdersRadioButton.TabIndex = 7;
			this.CurrentOrdersRadioButton.Text = "Открытые";
			this.CurrentOrdersRadioButton.UseVisualStyleBackColor = true;
			this.CurrentOrdersRadioButton.CheckedChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// SymbolChoiceComboBox
			// 
			this.SymbolChoiceComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.SymbolChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.SymbolChoiceComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.SymbolChoiceComboBox.FormattingEnabled = true;
			this.SymbolChoiceComboBox.Location = new System.Drawing.Point(77, 66);
			this.SymbolChoiceComboBox.Name = "SymbolChoiceComboBox";
			this.SymbolChoiceComboBox.Size = new System.Drawing.Size(137, 24);
			this.SymbolChoiceComboBox.TabIndex = 7;
			this.SymbolChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.CheckedChanged);
			// 
			// QueryOrderStartButton
			// 
			this.QueryOrderStartButton.Enabled = false;
			this.QueryOrderStartButton.Location = new System.Drawing.Point(77, 273);
			this.QueryOrderStartButton.Name = "QueryOrderStartButton";
			this.QueryOrderStartButton.Size = new System.Drawing.Size(137, 49);
			this.QueryOrderStartButton.TabIndex = 8;
			this.QueryOrderStartButton.Text = "Проверить состояние";
			this.QueryOrderStartButton.UseVisualStyleBackColor = true;
			this.QueryOrderStartButton.Click += new System.EventHandler(this.QueryOrderStartButton_Click);
			// 
			// CancelOrderStartButton
			// 
			this.CancelOrderStartButton.Enabled = false;
			this.CancelOrderStartButton.Location = new System.Drawing.Point(77, 328);
			this.CancelOrderStartButton.Name = "CancelOrderStartButton";
			this.CancelOrderStartButton.Size = new System.Drawing.Size(137, 49);
			this.CancelOrderStartButton.TabIndex = 8;
			this.CancelOrderStartButton.Text = "Отменить ордер";
			this.CancelOrderStartButton.UseVisualStyleBackColor = true;
			this.CancelOrderStartButton.Click += new System.EventHandler(this.CancelOrderStartButton_Click);
			// 
			// Orders
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 502);
			this.Controls.Add(this.CancelOrderStartButton);
			this.Controls.Add(this.QueryOrderStartButton);
			this.Controls.Add(this.SymbolChoiceComboBox);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.NewOrderStartButton);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.OrdersListBox);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Orders";
			this.Text = "Ордеры";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox OrdersListBox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button NewOrderStartButton;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton AllOrdersRadioButton;
		private System.Windows.Forms.RadioButton CurrentOrdersRadioButton;
		private System.Windows.Forms.ComboBox SymbolChoiceComboBox;
		private System.Windows.Forms.Button QueryOrderStartButton;
		private System.Windows.Forms.Button CancelOrderStartButton;
	}
}