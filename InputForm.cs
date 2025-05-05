using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dance_Scheduler_System
{   
    public partial class InputForm: Form
    {
        MainForm mainForm = new MainForm();
        string Type;

        private void InputForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        public InputForm(string Type)
        {
            this.Type = Type;
            InitializeComponent();
            FillClassBox();
        }

        public void FillClassBox()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                MySqlCommand fillCommand = new MySqlCommand("SELECT `Schedule ID`, `Type` FROM schedule", connection);
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(fillCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    information_Class_Box.DataSource = dt;
                    information_Class_Box.DisplayMember = "Type";
                    information_Class_Box.ValueMember = "Schedule ID";

                    if (!string.IsNullOrEmpty(Type))
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            if (row["Type"].ToString() == Type)
                            {
                                information_Class_Box.SelectedValue = row["Schedule ID"];
                                break;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void clearFields() { 
            information_Name_TextBox.Text = "";
            information_Email_TextBox.Text = "";
            information_PhoneNumber_TextBox.Text = "";
            information_Class_Box.SelectedIndex = -1;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;")) 
            {
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO booking(`Name`, `Email`, `Phone Number`, `Class`) VALUES(@Name, @Email, @PhoneNumber, @Class)", connection);
                insertCommand.Parameters.AddWithValue("@Name", information_Name_TextBox.Text);
                insertCommand.Parameters.AddWithValue("@Email", information_Email_TextBox.Text);
                if (!Regex.IsMatch(information_PhoneNumber_TextBox.Text, @"^09\d{9}$"))
                {
                    MessageBox.Show("Phone Number must start with '09' and be 11 digits long.");
                    information_PhoneNumber_TextBox.Text = "";
                    information_PhoneNumber_TextBox.Focus();
                    return;
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", information_PhoneNumber_TextBox.Text);
                }
                insertCommand.Parameters.AddWithValue("@Class", information_Class_Box.SelectedValue);

                try
                {
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Booking Successful!");
                    clearFields();
                    mainForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally {
                    connection.Close();
                }
            }
        }

    }
}
