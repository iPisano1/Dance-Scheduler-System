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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Dance_Scheduler_System
{
    public partial class AdminForm: Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        public void showOnlyPanel(Panel panel) { 
            usersPanel.Visible = false;
            schedulePanel.Visible = false;
            bookingsPanel.Visible = false;

            panel.Visible = true;
        }

        public void selectColorButton(Button btn) {
            usersBtn.BackColor = Color.White;
            schedulesBtn.BackColor = Color.White;
            bookingsBtn.BackColor = Color.White;

            btn.BackColor = Color.LightGray;
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            selectedUserID = -1;
            displayUsersGrid();
            ClearUsersTextFields();
            users_DataGrid.ClearSelection();
            showOnlyPanel(usersPanel);
            selectColorButton(usersBtn);

        }

        private void schedulesBtn_Click(object sender, EventArgs e)
        {
            selectedUserID = -1;
            ClearUsersTextFields();
            displaySchedulesGrid();
            users_DataGrid.ClearSelection();
            showOnlyPanel(schedulePanel);
            selectColorButton(schedulesBtn);
        }

        private void bookingsBtn_Click(object sender, EventArgs e)
        {
            selectedBookingID = -1;
            ClearBookingTextFields();
            displayBookingsGrid();
            bookings_DataGrid.ClearSelection();
            FillClassBox();
            showOnlyPanel(bookingsPanel);
            selectColorButton(bookingsBtn);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        public void ClearUsersTextFields() {
            users_UsernameTextBox.Text = "";
            users_PasswordTextBox.Text = "";
            users_PermissionTextBox.Text = "";
        }

        public void ClearSchedulesTextFields() {
            schedules_Day.Value = DateTime.Now;
            schedules_TypeTextBox.Text = "";
            schedules_TimeTextBox.Text = "";
            schedules_InstructorTextBox.Text = "";
            schedules_SlotsTextBox.Text = "";
        }

        public void ClearBookingTextFields() {
            bookings_NameTextBox.Text = "";
            bookings_EmailTextBox.Text = "";
            bookings_PhoneNumberTextBox.Text = "";
            bookings_ClassBox.SelectedIndex = -1;
            bookings_DateBooked.Value = DateTime.Now;
        }

        public void displayUsersGrid() {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;")) 
            { 
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM users", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                
                users_DataGrid.DataSource = dt;
                users_DataGrid.Columns["User ID"].Visible = false;


                users_DataGrid.ReadOnly = true;
                users_DataGrid.AllowUserToAddRows = false;
                users_DataGrid.RowHeadersVisible = false;
                users_DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                users_DataGrid.RowHeadersWidth = 30;
                users_DataGrid.MultiSelect = false;
                users_DataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

                users_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                users_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                users_DataGrid.AllowUserToResizeColumns = false;
                users_DataGrid.AllowUserToResizeRows = false;
                users_DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                users_DataGrid.RowHeadersWidth = 30;
                users_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            }
        }

        public void displaySchedulesGrid() {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM schedule", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                schedules_DataGrid.DataSource = dt;
                schedules_DataGrid.Columns["Schedule ID"].Visible = false;

                schedules_DataGrid.ReadOnly = true;
                schedules_DataGrid.AllowUserToAddRows = false;
                schedules_DataGrid.RowHeadersVisible = false;
                schedules_DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                schedules_DataGrid.RowHeadersWidth = 30;
                schedules_DataGrid.MultiSelect = false;
                schedules_DataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

                schedules_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                schedules_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                schedules_DataGrid.AllowUserToResizeColumns = false;
                schedules_DataGrid.AllowUserToResizeRows = false;
                schedules_DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                schedules_DataGrid.RowHeadersWidth = 30;
                schedules_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

                schedules_DataGrid.Columns["Day"].FillWeight = 80;
                schedules_DataGrid.Columns["Type"].FillWeight = 110;
                schedules_DataGrid.Columns["Time"].FillWeight = 130;
                schedules_DataGrid.Columns["Instructor"].FillWeight = 80;
                schedules_DataGrid.Columns["Slots"].FillWeight = 40;

            }
        }

        public void displayBookingsGrid() {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                MySqlCommand searchCommand = new MySqlCommand("SELECT b.`Booking ID` , b.`Name`, b.`Email`, b.`Phone Number`, s.`Type` AS `Class`, b.`Class` AS `Schedule ID`, b.`Date Booked` FROM booking b JOIN schedule s ON b.`Class` = s.`Schedule ID`", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                bookings_DataGrid.DataSource = dt;
                bookings_DataGrid.Columns["Booking ID"].Visible = false;
                bookings_DataGrid.Columns["Schedule ID"].Visible = false;

                bookings_DataGrid.ReadOnly = true;
                bookings_DataGrid.AllowUserToAddRows = false;
                bookings_DataGrid.RowHeadersVisible = false;
                bookings_DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                bookings_DataGrid.RowHeadersWidth = 30;
                bookings_DataGrid.MultiSelect = false;
                bookings_DataGrid.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

                bookings_DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                bookings_DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                bookings_DataGrid.AllowUserToResizeColumns = false;
                bookings_DataGrid.AllowUserToResizeRows = false;
                bookings_DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                bookings_DataGrid.RowHeadersWidth = 30;
                bookings_DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            }
        }

        // USERS PANEL

        public bool CheckIfUserExist() {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM users WHERE `Username` = @Username", connection);
                searchCommand.Parameters.AddWithValue("@Username", users_UsernameTextBox.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        private int selectedUserID = -1;

        private void users_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {   
                selectedUserID = Convert.ToInt32(users_DataGrid.Rows[e.RowIndex].Cells[0].Value);
                users_UsernameTextBox.Text = users_DataGrid.Rows[e.RowIndex].Cells[1].Value.ToString();
                users_PasswordTextBox.Text = users_DataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                users_PermissionTextBox.Text = users_DataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }

        private void users_AddBtn_Click(object sender, EventArgs e)
        {
            if (users_UsernameTextBox.Text == "" || users_PasswordTextBox.Text == "") {
                MessageBox.Show("Empty Fields.");
                return;
            }
            if (CheckIfUserExist()) {
                MessageBox.Show("Credentials Already Exist.");
                ClearUsersTextFields();
                users_DataGrid.ClearSelection();
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {   
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO users(`Username`, `Password`, `Permission`) VALUES(@Username, @Password, @Permission)", connection);
                insertCommand.Parameters.AddWithValue("@Username", users_UsernameTextBox.Text);
                insertCommand.Parameters.AddWithValue("@Password", users_PasswordTextBox.Text);
                insertCommand.Parameters.AddWithValue("@Permission", users_PermissionTextBox.Text);

                try
                {
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Added.");

                    selectedUserID = -1;
                    ClearUsersTextFields();
                    displayUsersGrid();
                    users_DataGrid.ClearSelection();
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

        private void users_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedUserID == -1) {
                MessageBox.Show("Select a valid user to delete.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;")) 
            {
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM users WHERE `User ID` = @UserID", connection);
                deleteCommand.Parameters.AddWithValue("@UserID", selectedUserID);
                try
                {
                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Deleted.");

                    selectedUserID = -1;
                    displayUsersGrid();
                    ClearUsersTextFields();
                    users_DataGrid.ClearSelection();
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

        private void users_UpdateBtm_Click(object sender, EventArgs e)
        {
            if (users_UsernameTextBox.Text == "" || users_PasswordTextBox.Text == "")
            {
                MessageBox.Show("Empty Fields.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;")) 
            {
                MySqlCommand updateCommand = new MySqlCommand("UPDATE users SET `Username` = @Username, `Password` = @Password, `Permission` = @Permission WHERE `User ID` = @UserID", connection);
                updateCommand.Parameters.AddWithValue("@Username", users_UsernameTextBox.Text);
                updateCommand.Parameters.AddWithValue("@Password", users_PasswordTextBox.Text);
                updateCommand.Parameters.AddWithValue("@Permission", users_PermissionTextBox.Text);
                updateCommand.Parameters.AddWithValue("@UserID", selectedUserID);
                try
                {
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("User Successfully Updated.");

                    selectedUserID = -1;
                    ClearUsersTextFields();
                    displayUsersGrid();
                    users_DataGrid.ClearSelection();
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

        private void users_RefreshBtn_Click(object sender, EventArgs e)
        {
            selectedUserID = -1;
            ClearUsersTextFields();
            displayUsersGrid();
            users_DataGrid.ClearSelection();
        }

        // SCHEDULE PANEL

        public bool CheckIfScheduleExist() {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;")) 
            {
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM schedule WHERE `Day` = @Day AND `Type` = @Type AND `Time` = @Time", connection);
                searchCommand.Parameters.AddWithValue("@Day", schedules_Day.Value.Date);
                searchCommand.Parameters.AddWithValue("@Type", schedules_TypeTextBox.Text);
                searchCommand.Parameters.AddWithValue("@Time", schedules_TimeTextBox.Text);

                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        private int selectedScheduleID = -1;

        private void schedules_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                selectedScheduleID = Convert.ToInt32(schedules_DataGrid.Rows[e.RowIndex].Cells[0].Value.ToString());
                schedules_Day.Value = Convert.ToDateTime(schedules_DataGrid.Rows[e.RowIndex].Cells[1].Value.ToString());
                schedules_TypeTextBox.Text = schedules_DataGrid.Rows[e.RowIndex].Cells[2].Value.ToString();
                schedules_TimeTextBox.Text = schedules_DataGrid.Rows[e.RowIndex].Cells[3].Value.ToString();
                schedules_InstructorTextBox.Text = schedules_DataGrid.Rows[e.RowIndex].Cells[4].Value.ToString();
                schedules_SlotsTextBox.Text = schedules_DataGrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }

        private void schedules_AddBtn_Click(object sender, EventArgs e)
        {
            if (schedules_TypeTextBox.Text == "" || schedules_TimeTextBox.Text == "" || schedules_InstructorTextBox.Text == "" || schedules_SlotsTextBox.Text == "")
            {
                MessageBox.Show("Empty Fields.");
                return;
            }
            if (CheckIfScheduleExist())
            {
                MessageBox.Show("Schedule Already Exist.");
                ClearSchedulesTextFields();
                schedules_DataGrid.ClearSelection();
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO schedule(`Day`, `Type`, `Time`, `Instructor`, `Slots`) VALUES(@Day, @Type, @Time, @Instructor, @Slots)", connection);
                insertCommand.Parameters.AddWithValue("@Day", schedules_Day.Value.Date);
                insertCommand.Parameters.AddWithValue("@Type", schedules_TypeTextBox.Text);
                insertCommand.Parameters.AddWithValue("@Time", schedules_TimeTextBox.Text);
                insertCommand.Parameters.AddWithValue("@Instructor", schedules_InstructorTextBox.Text);
                insertCommand.Parameters.AddWithValue("@Slots", schedules_SlotsTextBox.Text);

                try
                {
                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Schedule Successfully Added.");

                    selectedScheduleID = -1;
                    ClearSchedulesTextFields();
                    displaySchedulesGrid();
                    schedules_DataGrid.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void schedules_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedScheduleID == -1)
            {
                MessageBox.Show("Select a valid schedule to delete.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM schedule WHERE `Schedule ID` = @ScheduleID", connection);
                deleteCommand.Parameters.AddWithValue("@ScheduleID", selectedScheduleID);
                try
                {
                    connection.Open();
                    deleteCommand.ExecuteNonQuery();
                    MessageBox.Show("Schedule Successfully Deleted.");

                    selectedScheduleID = -1;
                    displaySchedulesGrid();
                    ClearSchedulesTextFields();
                    schedules_DataGrid.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void schedules_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (schedules_TypeTextBox.Text == "" || schedules_TimeTextBox.Text == "" || schedules_InstructorTextBox.Text == "" || schedules_SlotsTextBox.Text == "")
            {
                MessageBox.Show("Empty Fields.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                MySqlCommand updateCommand = new MySqlCommand("UPDATE schedule SET `Day` = @Day, `Type` = @Type, `Time` = @Time, `Instructor` = @Instructor, `Slots` = @Slots WHERE `Schedule ID` = @ScheduleID", connection);
                updateCommand.Parameters.AddWithValue("@ScheduleID", selectedScheduleID);
                updateCommand.Parameters.AddWithValue("@Day", schedules_Day.Value.Date);
                updateCommand.Parameters.AddWithValue("@Type", schedules_TypeTextBox.Text);
                updateCommand.Parameters.AddWithValue("@Time", schedules_TimeTextBox.Text);
                updateCommand.Parameters.AddWithValue("@Instructor", schedules_InstructorTextBox.Text);
                updateCommand.Parameters.AddWithValue("@Slots", schedules_SlotsTextBox.Text);

                try
                {
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Schedule Successfully Updated.");

                    selectedScheduleID = -1;
                    ClearSchedulesTextFields();
                    displaySchedulesGrid();
                    schedules_DataGrid.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void schedules_RefreshBtn_Click(object sender, EventArgs e)
        {
            selectedScheduleID = -1;
            ClearSchedulesTextFields();
            displaySchedulesGrid(); 
            schedules_DataGrid.ClearSelection();
        }

        // Booking Panel

        public bool CheckIfBookingExist()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM booking WHERE `Name` = @Name AND `Email` = @Email AND `Phone Number` = @PhoneNumber", connection);
                searchCommand.Parameters.AddWithValue("@Name", bookings_NameTextBox.Text);
                searchCommand.Parameters.AddWithValue("@Email", bookings_EmailTextBox.Text);
                searchCommand.Parameters.AddWithValue("@PhoneNumber", bookings_PhoneNumberTextBox.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private int selectedBookingID = -1;

        private void bookings_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedBookingID = Convert.ToInt32(bookings_DataGrid.Rows[e.RowIndex].Cells["Booking ID"].Value.ToString());
                bookings_NameTextBox.Text = bookings_DataGrid.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                bookings_EmailTextBox.Text = bookings_DataGrid.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                bookings_PhoneNumberTextBox.Text = bookings_DataGrid.Rows[e.RowIndex].Cells["Phone Number"].Value.ToString();
                bookings_ClassBox.SelectedValue = bookings_DataGrid.Rows[e.RowIndex].Cells["Schedule ID"].Value;
                bookings_DateBooked.Value = Convert.ToDateTime(bookings_DataGrid.Rows[e.RowIndex].Cells["Date Booked"].Value.ToString());
            }
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

                    bookings_ClassBox.DataSource = dt;
                    bookings_ClassBox.DisplayMember = "Type";
                    bookings_ClassBox.ValueMember = "Schedule ID";

                    bookings_ClassBox.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void bookings_AddBtn_Click(object sender, EventArgs e)
        {
            if (bookings_NameTextBox.Text == "" || bookings_EmailTextBox.Text == "" || bookings_PhoneNumberTextBox.Text == "")
            {
                MessageBox.Show("Empty Fields.");
                return;
            }
            if (CheckIfBookingExist())
            {
                MessageBox.Show("Booking Already Exist.");
                ClearBookingTextFields();
                bookings_DataGrid.ClearSelection();
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;")) 
            {
                connection.Open();
                MySqlCommand checkSlotsCommand = new MySqlCommand("SELECT `Slots` FROM schedule WHERE `Schedule ID` = @ScheduleID", connection);
                checkSlotsCommand.Parameters.AddWithValue("@ScheduleID", bookings_ClassBox.SelectedValue);
                int availableSlots = Convert.ToInt32(checkSlotsCommand.ExecuteScalar());

                if (availableSlots <= 0)
                {
                    MessageBox.Show("No more slots available for this class.");
                    connection.Close();
                    return;
                }

                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO booking(`Name`, `Email`, `Phone Number`, `Class`, `Date Booked`) VALUES(@Name, @Email, @PhoneNumber, @Class, @DateBooked)", connection);
                insertCommand.Parameters.AddWithValue("@Name", bookings_NameTextBox.Text);
                insertCommand.Parameters.AddWithValue("@Email", bookings_EmailTextBox.Text);
                insertCommand.Parameters.AddWithValue("@PhoneNumber", bookings_PhoneNumberTextBox.Text);
                insertCommand.Parameters.AddWithValue("@Class", bookings_ClassBox.SelectedValue);
                insertCommand.Parameters.AddWithValue("@DateBooked", bookings_DateBooked.Value.Date);

                try
                {
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Booking Successfully Added.");

                    MySqlCommand reduceSlotsCommand = new MySqlCommand("UPDATE schedule SET `Slots` = `Slots` - 1 WHERE `Schedule ID` = @ScheduleID", connection);
                    reduceSlotsCommand.Parameters.AddWithValue("@ScheduleID", bookings_ClassBox.SelectedValue);
                    reduceSlotsCommand.ExecuteNonQuery();

                    selectedBookingID = -1;
                    ClearBookingTextFields();
                    displayBookingsGrid();
                    bookings_DataGrid.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void bookings_DeleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedBookingID == -1) {
                MessageBox.Show("Select a valid booking to delete.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            {
                connection.Open();

                MySqlCommand getClassCommand = new MySqlCommand("SELECT `Class` FROM booking WHERE `Booking ID` = @BookingID", connection);
                getClassCommand.Parameters.AddWithValue("@BookingID", selectedBookingID);
                object scheduleIDObj = getClassCommand.ExecuteScalar();

                if (scheduleIDObj == null)
                {
                    MessageBox.Show("Schedule not found for this booking.");
                    return;
                }

                MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM booking WHERE `Booking ID` = @BookingID", connection);
                deleteCommand.Parameters.AddWithValue("@BookingID", selectedBookingID);

                try
                {
                    int rowsAffected = deleteCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MySqlCommand restoreSlotsCommand = new MySqlCommand("UPDATE schedule SET `Slots` = `Slots` + 1 WHERE `Schedule ID` = @ScheduleID", connection);
                        restoreSlotsCommand.Parameters.AddWithValue("@ScheduleID", Convert.ToInt32(scheduleIDObj));
                        restoreSlotsCommand.ExecuteNonQuery();

                        MessageBox.Show("Booking Successfully Deleted.");

                        selectedBookingID = -1;
                        displayBookingsGrid();
                        ClearBookingTextFields();
                        bookings_DataGrid.ClearSelection();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete booking.");
                    }

                    selectedBookingID = -1;
                    displayBookingsGrid();
                    ClearBookingTextFields();
                    bookings_DataGrid.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void bookings_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (bookings_NameTextBox.Text == "" || bookings_EmailTextBox.Text == "" || bookings_PhoneNumberTextBox.Text == "")
            {
                MessageBox.Show("Empty Fields.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=dance_scheduler_system;password=;"))
            { 
                MySqlCommand updateCommand = new MySqlCommand("UPDATE booking SET `Name` = @Name, `Email` = @Email, `Phone Number` = @PhoneNumber, `Class` = @Class, `Date Booked` = @DateBooked WHERE `Booking ID` = @BookingID", connection);
                updateCommand.Parameters.AddWithValue("@Name", bookings_NameTextBox.Text);
                updateCommand.Parameters.AddWithValue("@Email", bookings_EmailTextBox.Text);
                updateCommand.Parameters.AddWithValue("@PhoneNumber", bookings_PhoneNumberTextBox.Text);
                updateCommand.Parameters.AddWithValue("@Class", bookings_ClassBox.SelectedValue);
                updateCommand.Parameters.AddWithValue("@DateBooked", bookings_DateBooked.Value.Date);
                updateCommand.Parameters.AddWithValue("@BookingID", selectedBookingID);
                try
                {
                    connection.Open();
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Booking Successfully Updated.");

                    selectedBookingID = -1;
                    ClearBookingTextFields();
                    displayBookingsGrid();
                    bookings_DataGrid.ClearSelection();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void bookings_RefreshBtn_Click(object sender, EventArgs e)
        {
            selectedBookingID = -1;
            ClearBookingTextFields();
            displayBookingsGrid();
            bookings_DataGrid.ClearSelection();
        }
    }
}
