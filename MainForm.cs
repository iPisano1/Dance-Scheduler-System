using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dance_Scheduler_System
{
    public partial class MainForm: Form
    {
        private int selectedScheduleID = -1;

        public MainForm()
        {
            InitializeComponent();
            schedule_DataGridView.ReadOnly = true;
            schedule_DataGridView.AllowUserToAddRows = false;
            schedule_DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            schedule_DataGridView.RowHeadersWidth = 30;
            schedule_DataGridView.MultiSelect = false;
            schedule_DataGridView.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            displayScheduleGrid();
            selectedScheduleID = -1;
        }

        private void displayScheduleGrid()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM schedule", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                schedule_DataGridView.DataSource = dt;
                schedule_DataGridView.Columns["Schedule ID"].Visible = false;

                schedule_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                schedule_DataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                schedule_DataGridView.AllowUserToResizeColumns = false;
                schedule_DataGridView.AllowUserToResizeRows = false;
                schedule_DataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                schedule_DataGridView.RowHeadersWidth = 30;
                schedule_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                schedule_DataGridView.Columns["Day"].FillWeight = 80;
                schedule_DataGridView.Columns["Type"].FillWeight = 120;
                schedule_DataGridView.Columns["Time"].FillWeight = 100;
                schedule_DataGridView.Columns["Instructor"].FillWeight = 130;
                schedule_DataGridView.Columns["Slots"].FillWeight = 40;

                if (schedule_DataGridView.Rows.Count > 0)
                {
                    schedule_DataGridView.Rows[0].Selected = true;
                }
            }
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            displayScheduleGrid();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                connection.Open();
                MySqlCommand checkSlotsCommand = new MySqlCommand("SELECT `Slots` FROM schedule WHERE `Schedule ID` = @ScheduleID", connection);
                checkSlotsCommand.Parameters.AddWithValue("@ScheduleID", selectedScheduleID);
                int availableSlots = Convert.ToInt32(checkSlotsCommand.ExecuteScalar());

                if (availableSlots <= 0)
                {
                    MessageBox.Show("No more slots available for this class.");
                    connection.Close();
                    return;
                }
            }

            string Day, Type, Time, Instructor;
            Day = schedule_DataGridView.CurrentRow.Cells[0].Value.ToString();
            Type = schedule_DataGridView.CurrentRow.Cells[1].Value.ToString();
            Time = schedule_DataGridView.CurrentRow.Cells[2].Value.ToString();
            Instructor = schedule_DataGridView.CurrentRow.Cells[3].Value.ToString();

            InputForm inputForm = new InputForm(Type, selectedScheduleID);
            inputForm.Show();
            this.Hide();

        }

        private void bookBtn_Click(object sender, EventArgs e)
        {
            schedulePanel.Visible = true;
            homePanel.Visible = false;
        }

        private void schedule_backBtn_Click(object sender, EventArgs e)
        {
            schedulePanel.Visible = false;
            homePanel.Visible = true;
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void schedule_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                selectedScheduleID = Convert.ToInt32(schedule_DataGridView.Rows[e.RowIndex].Cells["Schedule ID"].Value.ToString());
            }
        }
    }
}
