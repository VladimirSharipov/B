namespace BANK
{
	partial class Form1
	{
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
			button1 = new Button();
			linkLabel1 = new LinkLabel();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			ShowPassswordcheckBox1 = new CheckBox();
			Passwordtxtbox = new TextBox();
			label5 = new Label();
			label6 = new Label();
			PhoneNumbertxtBox = new TextBox();
			button2 = new Button();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(141, 198, 65);
			button1.FlatStyle = FlatStyle.Popup;
			button1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = SystemColors.ControlLightLight;
			button1.Location = new Point(12, 212);
			button1.Name = "button1";
			button1.Size = new Size(370, 51);
			button1.TabIndex = 0;
			button1.Text = "Войти";
			button1.UseVisualStyleBackColor = false;			
			// 
			// linkLabel1
			// 
			linkLabel1.ActiveLinkColor = Color.White;
			linkLabel1.AutoSize = true;
			linkLabel1.LinkColor = Color.Silver;
			linkLabel1.Location = new Point(205, 290);
			linkLabel1.Name = "linkLabel1";
			linkLabel1.Size = new Size(95, 15);
			linkLabel1.TabIndex = 1;
			linkLabel1.TabStop = true;
			linkLabel1.Text = "Создать аккаунт";
			linkLabel1.VisitedLinkColor = Color.Silver;
			linkLabel1.LinkClicked += linkLabel1_LinkClicked;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.WhiteSmoke;
			label1.Location = new Point(169, 9);
			label1.Name = "label1";
			label1.Size = new Size(55, 25);
			label1.TabIndex = 2;
			label1.Text = "Вход";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.White;
			label2.Location = new Point(87, 290);
			label2.Name = "label2";
			label2.Size = new Size(121, 15);
			label2.TabIndex = 3;
			label2.Text = "Нет учетной записи?";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.FlatStyle = FlatStyle.Flat;
			label3.ForeColor = Color.White;
			label3.Location = new Point(12, 52);
			label3.Name = "label3";
			label3.Size = new Size(148, 15);
			label3.TabIndex = 4;
			label3.Text = "Введите номер телефона ";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.ForeColor = Color.White;
			label4.Location = new Point(12, 120);
			label4.Name = "label4";
			label4.Size = new Size(93, 15);
			label4.TabIndex = 5;
			label4.Text = "Введите пароль";
			// 
			// ShowPassswordcheckBox1
			// 
			ShowPassswordcheckBox1.AutoSize = true;
			ShowPassswordcheckBox1.ForeColor = Color.White;
			ShowPassswordcheckBox1.Location = new Point(263, 187);
			ShowPassswordcheckBox1.Name = "ShowPassswordcheckBox1";
			ShowPassswordcheckBox1.Size = new Size(119, 19);
			ShowPassswordcheckBox1.TabIndex = 6;
			ShowPassswordcheckBox1.Text = "Показать пароль";
			ShowPassswordcheckBox1.UseVisualStyleBackColor = true;
			ShowPassswordcheckBox1.CheckedChanged += checkBox1_CheckedChanged;
			// 
			// Passwordtxtbox
			// 
			Passwordtxtbox.BackColor = Color.FromArgb(33, 33, 33);
			Passwordtxtbox.BorderStyle = BorderStyle.None;
			Passwordtxtbox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			Passwordtxtbox.Location = new Point(12, 138);
			Passwordtxtbox.Name = "Passwordtxtbox";
			Passwordtxtbox.Size = new Size(370, 28);
			Passwordtxtbox.TabIndex = 8;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.ForeColor = Color.FromArgb(141, 198, 65);
			label5.Location = new Point(12, 169);
			label5.Name = "label5";
			label5.Size = new Size(364, 15);
			label5.TabIndex = 10;
			label5.Text = ".......................................................................................................................";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.ForeColor = Color.FromArgb(141, 198, 65);
			label6.Location = new Point(12, 96);
			label6.Name = "label6";
			label6.Size = new Size(364, 15);
			label6.TabIndex = 10;
			label6.Text = ".......................................................................................................................";
	
			// 
			// PhoneNumbertxtBox
			// 
			PhoneNumbertxtBox.BackColor = Color.FromArgb(33, 33, 33);
			PhoneNumbertxtBox.BorderStyle = BorderStyle.None;
			PhoneNumbertxtBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			PhoneNumbertxtBox.Location = new Point(12, 70);
			PhoneNumbertxtBox.Name = "PhoneNumbertxtBox";
			PhoneNumbertxtBox.Size = new Size(370, 28);
			PhoneNumbertxtBox.TabIndex = 8;
	
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(141, 198, 65);
			button2.FlatStyle = FlatStyle.Popup;
			button2.Location = new Point(355, 9);
			button2.Name = "button2";
			button2.Size = new Size(25, 23);
			button2.TabIndex = 11;
			button2.Text = "X";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(33, 33, 33);
			ClientSize = new Size(392, 338);
			Controls.Add(button2);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(PhoneNumbertxtBox);
			Controls.Add(Passwordtxtbox);
			Controls.Add(ShowPassswordcheckBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(linkLabel1);
			Controls.Add(button1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			MouseDown += Form1_MouseDown;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private LinkLabel linkLabel1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private CheckBox ShowPassswordcheckBox1;
		private TextBox Passwordtxtbox;
		private Label label5;
		private Label label6;
		private TextBox PhoneNumbertxtBox;
		private Button button2;
	}
}