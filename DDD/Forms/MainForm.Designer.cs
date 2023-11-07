namespace BANK.Forms
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			label1 = new Label();
			paybtn = new Button();
			button5 = new Button();
			button6 = new Button();
			button7 = new Button();
			currencyLabel = new Label();
			pictureVisa = new PictureBox();
			label_cardNumber = new Label();
			label_cardTo = new Label();
			label_cardCvv = new Label();
			balanceLabel = new Label();
			pictureBoxMasterCard = new PictureBox();
			CardsComboBox = new ComboBox();
			((System.ComponentModel.ISupportInitialize)pictureVisa).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxMasterCard).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(141, 198, 65);
			button1.FlatStyle = FlatStyle.Flat;
			button1.Location = new Point(971, 2);
			button1.Name = "button1";
			button1.Size = new Size(34, 29);
			button1.TabIndex = 0;
			button1.Text = "X";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Cursor = Cursors.Hand;
			button2.FlatStyle = FlatStyle.Flat;
			button2.Image = (Image)resources.GetObject("button2.Image");
			button2.ImageAlign = ContentAlignment.MiddleLeft;
			button2.Location = new Point(963, 53);
			button2.Name = "button2";
			button2.Size = new Size(42, 38);
			button2.TabIndex = 0;
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.BackColor = Color.FromArgb(141, 198, 65);
			button3.FlatStyle = FlatStyle.Flat;
			button3.Location = new Point(512, 70);
			button3.Name = "button3";
			button3.Size = new Size(88, 29);
			button3.TabIndex = 0;
			button3.Text = "button1";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(290, 76);
			label1.Name = "label1";
			label1.Size = new Size(78, 30);
			label1.TabIndex = 2;
			label1.Text = "КАРТЫ";
			// 
			// paybtn
			// 
			paybtn.Location = new Point(254, 426);
			paybtn.Name = "paybtn";
			paybtn.Size = new Size(75, 66);
			paybtn.TabIndex = 3;
			paybtn.Text = "button4";
			paybtn.UseVisualStyleBackColor = true;
			paybtn.Click += paybtn_Click;
			// 
			// button5
			// 
			button5.Location = new Point(512, 426);
			button5.Name = "button5";
			button5.Size = new Size(75, 66);
			button5.TabIndex = 3;
			button5.Text = "button4";
			button5.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			button6.Location = new Point(249, 542);
			button6.Name = "button6";
			button6.Size = new Size(75, 66);
			button6.TabIndex = 3;
			button6.Text = "button4";
			button6.UseVisualStyleBackColor = true;
			// 
			// button7
			// 
			button7.Location = new Point(501, 542);
			button7.Name = "button7";
			button7.Size = new Size(75, 66);
			button7.TabIndex = 3;
			button7.Text = "button4";
			button7.UseVisualStyleBackColor = true;
			// 
			// currencyLabel
			// 
			currencyLabel.AutoSize = true;
			currencyLabel.Location = new Point(851, 243);
			currencyLabel.Name = "currencyLabel";
			currencyLabel.Size = new Size(38, 15);
			currencyLabel.TabIndex = 4;
			currencyLabel.Text = "label2";
			// 
			// pictureVisa
			// 
			pictureVisa.BackColor = Color.FromArgb(33, 33, 39);
			pictureVisa.BackgroundImageLayout = ImageLayout.None;
			pictureVisa.Image = (Image)resources.GetObject("pictureVisa.Image");
			pictureVisa.Location = new Point(249, 114);
			pictureVisa.Name = "pictureVisa";
			pictureVisa.Size = new Size(404, 250);
			pictureVisa.TabIndex = 5;
			pictureVisa.TabStop = false;
			// 
			// label_cardNumber
			// 
			label_cardNumber.AutoSize = true;
			label_cardNumber.Location = new Point(335, 271);
			label_cardNumber.Name = "label_cardNumber";
			label_cardNumber.Size = new Size(38, 15);
			label_cardNumber.TabIndex = 6;
			label_cardNumber.Text = "label3";
			// 
			// label_cardTo
			// 
			label_cardTo.AutoSize = true;
			label_cardTo.Location = new Point(395, 157);
			label_cardTo.Name = "label_cardTo";
			label_cardTo.Size = new Size(38, 15);
			label_cardTo.TabIndex = 7;
			label_cardTo.Text = "label3";
			// 
			// label_cardCvv
			// 
			label_cardCvv.AutoSize = true;
			label_cardCvv.Location = new Point(447, 318);
			label_cardCvv.Name = "label_cardCvv";
			label_cardCvv.Size = new Size(38, 15);
			label_cardCvv.TabIndex = 8;
			label_cardCvv.Text = "label4";
			label_cardCvv.Click += label_cardCvv_Click;
			// 
			// balanceLabel
			// 
			balanceLabel.AutoSize = true;
			balanceLabel.Location = new Point(347, 338);
			balanceLabel.Name = "balanceLabel";
			balanceLabel.Size = new Size(38, 15);
			balanceLabel.TabIndex = 9;
			balanceLabel.Text = "label5";
			// 
			// pictureBoxMasterCard
			// 
			pictureBoxMasterCard.BackColor = Color.FromArgb(33, 33, 39);
			pictureBoxMasterCard.Image = (Image)resources.GetObject("pictureBoxMasterCard.Image");
			pictureBoxMasterCard.Location = new Point(249, 116);
			pictureBoxMasterCard.Name = "pictureBoxMasterCard";
			pictureBoxMasterCard.Size = new Size(399, 248);
			pictureBoxMasterCard.TabIndex = 5;
			pictureBoxMasterCard.TabStop = false;
			// 
			// CardsComboBox
			// 
			CardsComboBox.FormattingEnabled = true;
			CardsComboBox.Location = new Point(374, 76);
			CardsComboBox.Name = "CardsComboBox";
			CardsComboBox.Size = new Size(121, 23);
			CardsComboBox.TabIndex = 10;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(33, 33, 33);
			ClientSize = new Size(1017, 696);
			Controls.Add(CardsComboBox);
			Controls.Add(balanceLabel);
			Controls.Add(label_cardCvv);
			Controls.Add(label_cardTo);
			Controls.Add(label_cardNumber);
			Controls.Add(pictureBoxMasterCard);
			Controls.Add(pictureVisa);
			Controls.Add(currencyLabel);
			Controls.Add(button7);
			Controls.Add(button6);
			Controls.Add(button5);
			Controls.Add(paybtn);
			Controls.Add(label1);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			FormBorderStyle = FormBorderStyle.None;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MainForm";
			Text = "MainForm";
			Load += MainForm_Load;
			((System.ComponentModel.ISupportInitialize)pictureVisa).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxMasterCard).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button button1;
		private Button button2;
		private Button button3;
		private Label label1;
		private Button paybtn;
		private Button button5;
		private Button button6;
		private Button button7;
		private Label currencyLabel;
		private PictureBox pictureVisa;
		private Label label_cardNumber;
		private Label label_cardTo;
		private Label label_cardCvv;
		private Label balanceLabel;
		private PictureBox pictureBoxMasterCard;
		private ComboBox CardsComboBox;
	}
}