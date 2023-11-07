namespace BANK.Forms
{
	partial class AddBankCard
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
			TypeCardcmdbox = new ComboBox();
			label1 = new Label();
			Closebtn = new Button();
			Createbtn = new Button();
			label6 = new Label();
			CurrencyCombx = new ComboBox();
			label2 = new Label();
			SystemPaycmbbx = new ComboBox();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label7 = new Label();
			label9 = new Label();
			numericUpDownPin = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)numericUpDownPin).BeginInit();
			SuspendLayout();
			// 
			// TypeCardcmdbox
			// 
			TypeCardcmdbox.BackColor = Color.FromArgb(33, 33, 33);
			TypeCardcmdbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			TypeCardcmdbox.FormattingEnabled = true;
			TypeCardcmdbox.Items.AddRange(new object[] { "Дебитовая", "Кредитная" });
			TypeCardcmdbox.Location = new Point(13, 31);
			TypeCardcmdbox.Name = "TypeCardcmdbox";
			TypeCardcmdbox.Size = new Size(302, 38);
			TypeCardcmdbox.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = SystemColors.ControlLightLight;
			label1.Location = new Point(12, 13);
			label1.Name = "label1";
			label1.Size = new Size(63, 15);
			label1.TabIndex = 1;
			label1.Text = "Тип карты";
			// 
			// Closebtn
			// 
			Closebtn.BackColor = Color.FromArgb(141, 198, 65);
			Closebtn.FlatStyle = FlatStyle.Popup;
			Closebtn.Location = new Point(289, 2);
			Closebtn.Name = "Closebtn";
			Closebtn.Size = new Size(25, 23);
			Closebtn.TabIndex = 12;
			Closebtn.Text = "X";
			Closebtn.UseVisualStyleBackColor = false;
			Closebtn.Click += Button2_Click;
			// 
			// Createbtn
			// 
			Createbtn.BackColor = Color.FromArgb(141, 198, 65);
			Createbtn.FlatStyle = FlatStyle.Popup;
			Createbtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			Createbtn.ForeColor = SystemColors.ControlLightLight;
			Createbtn.Location = new Point(12, 387);
			Createbtn.Name = "Createbtn";
			Createbtn.Size = new Size(294, 51);
			Createbtn.TabIndex = 13;
			Createbtn.Text = "Создать";
			Createbtn.UseVisualStyleBackColor = false;
			Createbtn.Click += Createbtn_Click;
			Createbtn.Layout += Createbtn_Layout;
			Createbtn.MouseDown += Createbtn_MouseDown;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.ForeColor = Color.FromArgb(141, 198, 65);
			label6.Location = new Point(12, 72);
			label6.Name = "label6";
			label6.Size = new Size(301, 15);
			label6.TabIndex = 14;
			label6.Text = "..................................................................................................";
			label6.Click += label6_Click;
			// 
			// CurrencyCombx
			// 
			CurrencyCombx.BackColor = Color.FromArgb(33, 33, 33);
			CurrencyCombx.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			CurrencyCombx.FormattingEnabled = true;
			CurrencyCombx.Items.AddRange(new object[] { "USD", "TG", "RUB" });
			CurrencyCombx.Location = new Point(13, 114);
			CurrencyCombx.Name = "CurrencyCombx";
			CurrencyCombx.Size = new Size(302, 38);
			CurrencyCombx.TabIndex = 0;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.FromArgb(141, 198, 65);
			label2.Location = new Point(11, 152);
			label2.Name = "label2";
			label2.Size = new Size(301, 15);
			label2.TabIndex = 14;
			label2.Text = "..................................................................................................";
			label2.Click += label6_Click;
			// 
			// SystemPaycmbbx
			// 
			SystemPaycmbbx.BackColor = Color.FromArgb(33, 33, 33);
			SystemPaycmbbx.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			SystemPaycmbbx.FormattingEnabled = true;
			SystemPaycmbbx.Items.AddRange(new object[] { "Visa", "Mastercard" });
			SystemPaycmbbx.Location = new Point(13, 205);
			SystemPaycmbbx.Name = "SystemPaycmbbx";
			SystemPaycmbbx.Size = new Size(302, 38);
			SystemPaycmbbx.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.FromArgb(141, 198, 65);
			label3.Location = new Point(13, 246);
			label3.Name = "label3";
			label3.Size = new Size(301, 15);
			label3.TabIndex = 14;
			label3.Text = "..................................................................................................";
			label3.Click += label6_Click;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.FromArgb(141, 198, 65);
			label4.Location = new Point(14, 336);
			label4.Name = "label4";
			label4.Size = new Size(301, 15);
			label4.TabIndex = 14;
			label4.Text = "..................................................................................................";
			label4.Click += label6_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = SystemColors.ControlLightLight;
			label5.Location = new Point(13, 96);
			label5.Name = "label5";
			label5.Size = new Size(48, 15);
			label5.TabIndex = 1;
			label5.Text = "Валюта";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.ForeColor = SystemColors.ControlLightLight;
			label7.Location = new Point(11, 187);
			label7.Name = "label7";
			label7.Size = new Size(116, 15);
			label7.TabIndex = 1;
			label7.Text = "Платежная система";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.ForeColor = SystemColors.ControlLightLight;
			label9.Location = new Point(11, 278);
			label9.Name = "label9";
			label9.Size = new Size(50, 15);
			label9.TabIndex = 1;
			label9.Text = "PIN-код";
			// 
			// numericUpDownPin
			// 
			numericUpDownPin.BackColor = Color.FromArgb(33, 33, 33);
			numericUpDownPin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			numericUpDownPin.Location = new Point(14, 298);
			numericUpDownPin.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
			numericUpDownPin.Name = "numericUpDownPin";
			numericUpDownPin.Size = new Size(303, 35);
			numericUpDownPin.TabIndex = 15;
			// 
			// AddBankCard
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(33, 33, 33);
			ClientSize = new Size(326, 450);
			Controls.Add(numericUpDownPin);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label6);
			Controls.Add(Createbtn);
			Controls.Add(Closebtn);
			Controls.Add(SystemPaycmbbx);
			Controls.Add(label9);
			Controls.Add(label7);
			Controls.Add(label5);
			Controls.Add(label1);
			Controls.Add(CurrencyCombx);
			Controls.Add(TypeCardcmdbox);
			FormBorderStyle = FormBorderStyle.None;
			Name = "AddBankCard";
			Text = "AddBankCard";
			Load += AddBankCard_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDownPin).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox TypeCardcmdbox;
		private Label label1;
		private Button Closebtn;
		private Button Createbtn;
		private Label label6;
		private ComboBox CurrencyCombx;
		private Label label2;
		private ComboBox SystemPaycmbbx;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label7;
		private Label label9;
		private NumericUpDown numericUpDownPin;
	}
}