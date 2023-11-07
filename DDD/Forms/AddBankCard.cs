using BANK.Controller;
using BANK.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK.Forms
{
	public partial class AddBankCard : Form
	{

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		DBConnection database = new DBConnection();
		Random Random = new Random();
		SqlDataAdapter adapter = new SqlDataAdapter();
		DataTable table = new DataTable();

		public AddBankCard()
		{
			InitializeComponent();
		}

		private void Button2_Click(object sender, EventArgs e)
		{
			Close();
		}
		private void Createbtn_Layout(object sender, LayoutEventArgs e)
		{
			TypeCardcmdbox.SelectedIndex = 0;
			CurrencyCombx.SelectedIndex = 0;
			SystemPaycmbbx.SelectedIndex = 0;
		}
		private void AddBankCard_Load(object sender, EventArgs e)
		{
			TypeCardcmdbox.SelectedIndex = 0;
			CurrencyCombx.SelectedIndex = 0;
			SystemPaycmbbx.SelectedIndex = 0;
		}
		private void Createbtn_Click(object sender, EventArgs e)
		{
			var cardType = TypeCardcmdbox.GetItemText(TypeCardcmdbox.SelectedIndex);
			var currency = CurrencyCombx.GetItemText(CurrencyCombx.SelectedIndex);
			var paymentSystem = SystemPaycmbbx.GetItemText(CurrencyCombx.SelectedIndex);
			var cardNumber = "";
			var cardPin = numericUpDownPin.Value;
			var cvvCode = "";
			bool isCardFree = false;
			DateTime dateTime = DateTime.Now;
			var cardDate = dateTime.AddYears(4);

			for (int i = 0; i < 3; i++)
			{
				cvvCode = Convert.ToString(Random.Next(0, 10));
			}
			//создание номера карты 
			do
			{
				if (paymentSystem == "Visa")
				{
					cardNumber = "4";
					for (int i = 0; i < 15; i++)
					{
						cardNumber = Convert.ToString(Random.Next(0, 10));
					}

				}
				else
				{
					cardNumber = "5";
					for (int i = 0; i < 15; i++)
					{
						cardNumber = Convert.ToString(Random.Next(0, 10));
					}
				}
				var queryCheckCardNumber = $"select*from bank_card where bank_card_number = '{cardNumber}'";
				SqlCommand sqlCommand = new SqlCommand(queryCheckCardNumber, database.getConnection());
				adapter.SelectCommand = sqlCommand;
				adapter.Fill(table);
				if (table.Rows.Count == 0)
				{
					isCardFree = true;
				}
				//если в базе она уже есть повторяем цикл повторно 
			} while (isCardFree == false);
			var queryAddNewCard = $"insert into bank_card(bank_card_type,bank_card_number,bank_card_cvv_code,bank_card_currency,bank_card_paymentSystem,bank_card_date,id_client,bank_card_pin) values ('{cardType} ','{cardNumber}','{cvvCode}','{currency}','{paymentSystem}','{cardDate}','{DataStorage.idClient}','{cardPin}')";
			 SqlCommand commandAddNewCard = new(queryAddNewCard, database.getConnection());
			database.openConnection();
			commandAddNewCard.ExecuteNonQuery();
			database.closeConnection();
			MessageBox.Show("Карта успешна создана ", "Данные сохранены ", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Close();
		}
		private void Createbtn_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}


















		private void label6_Click(object sender, EventArgs e)
		{

		}

		
	}
}

