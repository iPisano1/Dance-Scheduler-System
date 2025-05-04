using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Dance_Scheduler_System
{
    public partial class LoginForm: Form
    {

        public MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;");
        public string status;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            login_Username_TextBox.Focus();
            status = "login";
        }

        private void signupLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPanel.Enabled = false;
            loginPanel.Visible = false;
            signupPanel.Enabled = true;
            signupPanel.Visible = true;
            signup_Username_TextBox.Focus();
        }

        private void loginLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPanel.Enabled = true;
            loginPanel.Visible = true;
            signupPanel.Enabled = false;
            signupPanel.Visible = false;
            login_Username_TextBox.Focus();
        }

        public bool isEmpty()
        {
            if (status == "signup")
            {
                if (signup_Username_TextBox.Text == "" || signup_Password_TextBox.Text == "")
                {
                    return true;
                }
            }
            if (status == "login")
            {
                if (login_Username_TextBox.Text == "" || login_Password_TextBox.Text == "")
                {
                    return true;
                }
            }
            return false;
        }

        public void clearFields()
        {
            if (status == "signup") {
                signup_Username_TextBox.Text = "";
                signup_Password_TextBox.Text = "";
            }
            if (status == "login") {
                login_Username_TextBox.Text = "";
                login_Password_TextBox.Text = "";
            }
        }

        private void EnterKey_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (status == "login")
                {
                    loginBtn_Click(sender, e);
                }
                else if (status == "signup")
                {
                    signupBtn_Click(sender, e);
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }


        private void signupBtn_Click(object sender, EventArgs e)
        {
            status = "signup";
            MySqlCommand insertCommand = new MySqlCommand("INSERT INTO users(`Username`, `Password`) VALUES(@username, @password)", connection);
            insertCommand.Parameters.AddWithValue("@username", signup_Username_TextBox.Text);
            insertCommand.Parameters.AddWithValue("@password", signup_Password_TextBox.Text);

            MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM users WHERE Username = @username", connection);
            searchCommand.Parameters.AddWithValue("@username", signup_Username_TextBox.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            try
            {
                if (isEmpty())
                {
                    signup_Username_TextBox.Focus();
                    MessageBox.Show("Please fill in all fields");
                    clearFields();
                    return;
                }
                if (dt.Rows.Count > 0) {
                    signup_Username_TextBox.Focus();
                    MessageBox.Show("Username already exists. Please choose another username.");
                    clearFields();
                    return;
                }

                connection.Open();
                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Registered.");
                signupPanel.Enabled = false;
                signupPanel.Visible = false;
                loginPanel.Enabled = true;
                loginPanel.Visible = true;
                login_Username_TextBox.Focus();
                clearFields();
                status = "login";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {   
            status = "login";

            if (isEmpty())
            {
                login_Username_TextBox.Focus();
                MessageBox.Show("Please fill in all fields");
                clearFields();
                return;
            }

            MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM users WHERE Username = @username AND Password = @password", connection);
            searchCommand.Parameters.AddWithValue("@username", login_Username_TextBox.Text);
            searchCommand.Parameters.AddWithValue("@password", login_Password_TextBox.Text);

            MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
            DataTable dt = new DataTable();  
            adapter.Fill(dt);

            try
            {
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Successfully Log In.");
                    clearFields();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    login_Username_TextBox.Focus();
                    MessageBox.Show("Invalid Username or Password.");
                    clearFields();
                    return;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
