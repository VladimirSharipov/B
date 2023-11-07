using BANK.Controller;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANK.Forms
{
	public partial class RegistForm : Form
	{
		public RegistForm()
		{
			InitializeComponent();
		}
		DBConnection database = new DBConnection();

		private void RegistForm_Load(object sender, EventArgs e)
		{
			txtboxLastName.Select();

		}
		private void Savebtn_Click(object sender, EventArgs e)
		{
			MessageBoxButtons btn = MessageBoxButtons.OK;
			MessageBoxIcon ico = MessageBoxIcon.Information;
			string caption = "Дата регистрации";
			if (!Regex.IsMatch(txtboxLastName.Text, "[А-Яа-я]+$"))
			{
				MessageBox.Show("Пожалуйста , ввидете фамилию повторно !", caption, btn, ico);
				txtboxLastName.Select();
				return;

			}
			if (!Regex.IsMatch(txtboxFirstName.Text, "[А-Яа-я]+$"))
			{
				MessageBox.Show("Пожалуйста , имя повторно !", caption, btn, ico);
				txtboxFirstName.Select();
				return;

			}
			if (!Regex.IsMatch(txtboxMiddleName.Text, "[А-Яа-я]+$"))
			{
				MessageBox.Show("Пожалуйста , ввидете отчество  повторно !", caption, btn, ico);
				txtboxMiddleName.Select();
				return;

			}
			if (string.IsNullOrEmpty(GendercomboBox.SelectedItem.ToString()))
			{
				MessageBox.Show("Пожалуйста , выберите пол  !", caption, btn, ico);
				txtboxMiddleName.Select();
				return;

			}
			if (!Regex.IsMatch(Passwordtxtbox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
			{
				MessageBox.Show("Пожалуйста , ввидете  пароль !", caption, btn, ico);
				Passwordtxtbox.Select();
				return;

			}
			if (!Regex.IsMatch(ConfirmPasswordtxtbox.Text, "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$"))
			{
				MessageBox.Show("Пожалуйста ,ввидете подтверждения пароля !", caption, btn, ico);
				Passwordtxtbox.Select();
				return;

			}
			if (Passwordtxtbox.Text != ConfirmPasswordtxtbox.Text)
			{
				MessageBox.Show("Ваш пароль и пароль подтверждения не совпадают  !", caption, btn, ico);
				ConfirmPasswordtxtbox.Select();
				return;

			}
			if (!Regex.IsMatch(txtmail.Text, @"^([\w.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
			{
				MessageBox.Show("Пожалуйста , ввидете вашу почту  !", caption, btn, ico);
				txtmail.Select();
				return;

			}
			if (!Regex.IsMatch(txtNumberPhone.Text, "^[+][7][0-9]{7,14}$"))
			{
				MessageBox.Show("Пожалуйста , ввидете номер телефона !", caption, btn, ico);
				txtNumberPhone.Select();
				return;

			}
			string yourSql = "Select client_phone_number From  client Where client_phone_number = '" + txtNumberPhone.Text + "'";
			SqlDataAdapter adapter = new();
			DataTable table = new DataTable();
			SqlCommand cmd = new SqlCommand(yourSql, database.getConnection());
			adapter.SelectCommand = cmd;
			adapter.Fill(table);
			if (table.Rows.Count > 0)
			{
				MessageBox.Show("Номер Телефона уже сущуствует .Невозможно зарегистрировать аккаунт ", "Ошибка", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
				txtNumberPhone.SelectAll();
				return;
			}
			DialogResult result;
			result = MessageBox.Show("Вы хотите сохранить запись ?", "Сохранение данных ", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
			if (result == DialogResult.Yes)
			{
				string mySql = string.Empty;
				mySql += "insert Into client (client_last_name,client_first_name,client_middle_name,client_gender,client_password,client_email,client_phone_number)";
				mySql += "Values ('" + txtboxLastName.Text + "','" + txtboxFirstName.Text + "','" + txtboxMiddleName.Text + "',";
				mySql += "'" + GendercomboBox.SelectedItem.ToString() + "','" + Passwordtxtbox.Text + "','" + txtmail.Text + "','" + txtNumberPhone.Text + "')";
				database.openConnection();
				SqlCommand sqlCommand = new SqlCommand(mySql, database.getConnection());
				sqlCommand.ExecuteNonQuery();
				MessageBox.Show("Запись успешна сохранена ", "Данные успешна сохранены ", MessageBoxButtons.OK, MessageBoxIcon.Information);
				ClearControls();
				database.closeConnection();
				Close();

			}


		}
		private void ClearControls()
		{
			foreach (TextBox textBox in Controls.OfType<TextBox>())
			{
				textBox.Text = string.Empty;
			}
			foreach (ComboBox comboBox in Controls.OfType<ComboBox>())
			{
				comboBox.SelectedItem = null;
			}
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		private void ShowPassswordcheckBox1_CheckedChanged(object sender, EventArgs e)
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
		private void Cleartxtbox_Click(object sender, EventArgs e)
		{
			txtboxLastName.SelectAll();
			ClearControls();
		}
	}
}
