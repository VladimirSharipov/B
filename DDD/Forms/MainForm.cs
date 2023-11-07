using BANK.Controller;
using BANK.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace BANK.Forms
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[System.Runtime.InteropServices.DllImport("user32.dll")]

		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		[System.Runtime.InteropServices.DllImport("user32.dll")]

		public static extern bool ReleaseCapture();
		DBConnection database = new DBConnection();
		private void MainForm_Load(object sender, EventArgs e)
		{
			label_cardNumber.BringToFront();
			label_cardCvv.BringToFront();
			label_cardNumber.Text = "";
			label_cardTo.BringToFront();
			balanceLabel.BringToFront();
			currencyLabel.BringToFront();
			pictureBoxMasterCard.Visible = false;
			pictureVisa.Visible = false;

			var query = $"select id_bank_card,bank_card_number from bank_card where id_client = '{DataStorage.idClient}'";
			SqlDataAdapter commandMycards = new SqlDataAdapter(query, database.getConnection());
			database.openConnection();
			DataTable cards = new DataTable();
			commandMycards.Fill(cards);
			CardsComboBox.DataSource = cards;
			CardsComboBox.ValueMember = "id_bank_card";
			CardsComboBox.DisplayMember = "bank_card_number";
			database.closeConnection();
			selectBankCard();
		}
		private void selectBankCard()
		{
			label_cardNumber.Text = "";
			string paymentSystem = "";
			string querySelectedCard = $"select bank_card_number, banl_card_cvv_code, CONCAT(FORMAT(bank_card_date, '%M'), '/',FORMAT(bank_card_date, '%y')), bank_card_paymentSystem, bank_card_balance, bank_card_currency from bank_card where bank_card_number= '{(CardsComboBox.GetItemText(CardsComboBox.SelectedText))}')";
			SqlCommand command = new(querySelectedCard, database.getConnection());
			database.openConnection();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				var cardNumber = reader[0].ToString();
				int tmp = 0;
				int tmp1 = 4;
				for (int m = 0; m < 4; m++)
				{
					for (int n = tmp; n < tmp1; n++)
					{
						label_cardNumber.Text += cardNumber[n].ToString();
					}
					label_cardNumber.Text += " ";
					tmp += 4;
					tmp1 += 4;

				}
				label_cardCvv.Text = reader[1].ToString();
				label_cardTo.Text = reader[2].ToString();
				paymentSystem = reader[3].ToString();
				balanceLabel.Text = Math.Round(Convert.ToDouble(reader[4]), 2).ToString();
				currencyLabel.Text = reader[5].ToString();
				DataStorage.cardCvv = label_cardCvv.Text;
				label_cardCvv.Text = "***";
			}
			reader.Close();
			if (paymentSystem == "Visa")
			{
				pictureBoxMasterCard.Visible = false;
				pictureVisa.Visible = true;

			}
			else
			{
				pictureBoxMasterCard.Visible = true;
				pictureVisa.Visible = false;
			}


		}
		private void button1_Click(object sender, EventArgs e)
		{

			Application.Exit();
		}

		private void label_cardCvv_Click(object sender, EventArgs e)
		{
			if (label_cardCvv.Text == "***") label_cardCvv.Text = DataStorage.cardCvv;
			else label_cardCvv.Text = "***";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var guery = $"select id_bank_card, bank_card_number from bank_card where id_client = '{DataStorage.idClient}'";
			SqlDataAdapter adapter = new(guery, database.getConnection());
			database.openConnection();
			DataTable cards = new();
			adapter.Fill(cards);
			CardsComboBox.DataSource = cards;
			CardsComboBox.ValueMember = "id_bank_card";
			CardsComboBox.DisplayMember = "bank_card_number";
			database.closeConnection();
			selectBankCard();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			AddBankCard addBankCard = new();
			addBankCard.ShowDialog();
		}

		private void paybtn_Click(object sender, EventArgs e)
		{
			//SendToForm sendToForm = new();
			DataStorage.bankCard = CardsComboBox.Text;
			DataStorage.cardNumber = CardsComboBox.GetItemText(CardsComboBox.SelectedItem);
			CardsComboBox.Text = "";
			//SendToForm.ShoDialog();
		}
	}
}
