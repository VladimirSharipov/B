using BANK.Controller;
using BANK.Forms;
using BANK.Model;
using System.Data;
using System.Data.SqlClient;

namespace BANK
{
	public partial class Form1 : Form
	{
		DBConnection dBConnnection = new DBConnection();
		public Form1()
		{
			InitializeComponent();
		}
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool ReleaseCapture();
		private void Form1_Load(object sender, EventArgs e)
		{
			PhoneNumbertxtBox.Select();
		}
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (ShowPassswordcheckBox1.Checked == true)
			{
				Passwordtxtbox.UseSystemPasswordChar = false;
			}
			else
			{
				Passwordtxtbox.UseSystemPasswordChar = true;
			}
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			RegistForm registform = new RegistForm();
			registform.ShowDialog();
		}
		private void LoginButten_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(Passwordtxtbox.Text) && (!string.IsNullOrEmpty(PhoneNumbertxtBox.Text)))
			{
				var querySelectionClient = $"SELECT*FROM client WHERE client_phone_number = '{PhoneNumbertxtBox.Text} AND client_password = '{Passwordtxtbox.Text}'";
				var queryGetId = $"SELECT id_client FROM client WHERE client_phone_number = '{PhoneNumbertxtBox.Text}' ";
				var commandGetId = new SqlCommand(queryGetId, dBConnnection.getConnection());
				dBConnnection.getConnection();
				SqlDataReader reader = commandGetId.ExecuteReader();
				while (reader.Read())
				{
					DataStorage.idClient = reader[0].ToString();
				}
				reader.Close();
				SqlDataAdapter adapter = new SqlDataAdapter();
				DataTable Table = new DataTable();
				SqlCommand sqlCommand = new SqlCommand(querySelectionClient, dBConnnection.getConnection());
				adapter.SelectCommand = sqlCommand;
				adapter.Fill(Table);
				if (Table.Rows.Count > 0)
				{
					PhoneNumbertxtBox.Clear();
					Passwordtxtbox.Clear();
					ShowPassswordcheckBox1.Checked = false;
					Hide();
					MainForm mainform = new MainForm();
					mainform.ShowDialog();
					mainform = null;
					Show();
					PhoneNumbertxtBox.Select();

				}
				else
				{

					MessageBox.Show("Имя пользователя или пароль неверны .Попробуйте еще раз!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
					PhoneNumbertxtBox.Focus();
					PhoneNumbertxtBox.SelectAll();
				}
			}
			else
			{
				MessageBox.Show("Пожалуйста ,введите имя пользователя и пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
				PhoneNumbertxtBox.SelectAll();
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void Form1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
	}
}