using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace fsManager
{
    public enum ViewMode
    {
        ALL,
        UNLIMITED,
        STARSKATE,
        LTS
    }
    public partial class MainFrm : Form
    {
        SQLiteConnection m_dbConnection;
        ViewMode currentView;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Application.StartupPath + "\\rtc.db"))
            {
                MessageBox.Show("skaters db file not found");
                Close();
                return;
            }

            m_dbConnection = new SQLiteConnection("Data Source=rtc.db;Version=3;");
            m_dbConnection.Open();

            showAllSkaters();

            ResizeColumns();
        }

        private void ResizeColumns()
        {
            for (int x = 0; x < SkatersGrid.ColumnCount; x++)
            {
                SkatersGrid.Columns[x].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }

            SkatersGrid.Columns[SkatersGrid.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void showAllSkaters()
        {
            string SQL = "SELECT FirstName, LastName, DOB, Sex, Phone, Email, ParentName, SkateCanadaN, CoachName, LevelRegistered, LTSDay, Notes FROM skaters";
            SQLiteCommand cmd = new SQLiteCommand(SQL, m_dbConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                SkatersGrid.DataSource = dt;
                currentView = ViewMode.ALL;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showUnlimitedSkaters()
        {
            string SQL = "SELECT FirstName, LastName, DOB, Sex, Phone, Email, ParentName, SkateCanadaN, CoachName, LevelRegistered, LTSDay, Notes FROM skaters WHERE LevelRegistered like '%unlimited%'";
            SQLiteCommand cmd = new SQLiteCommand(SQL, m_dbConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                SkatersGrid.DataSource = dt;
                currentView = ViewMode.UNLIMITED;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showLTSSkaters()
        {
            string SQL = "SELECT FirstName, LastName, DOB, Sex, Phone, Email, ParentName, SkateCanadaN, CoachName, LevelRegistered, LTSDay, Notes FROM skaters WHERE LevelRegistered like '%learn%'";
            SQLiteCommand cmd = new SQLiteCommand(SQL, m_dbConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                SkatersGrid.DataSource = dt;
                currentView = ViewMode.LTS;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showStarskateSkaters()
        {
            string SQL = "SELECT FirstName, LastName, DOB, Sex, Phone, Email, ParentName, SkateCanadaN, CoachName, LevelRegistered, LTSDay, Notes FROM skaters WHERE LevelRegistered like '%starskate%'";
            SQLiteCommand cmd = new SQLiteCommand(SQL, m_dbConnection);
            SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                DataTable dt = ds.Tables[0];
                SkatersGrid.DataSource = dt;
                currentView = ViewMode.STARSKATE;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Skater FillSkaterProfileFromSelected ()
        {
            Skater sktr = new Skater();

            if (SkatersGrid.SelectedRows.Count == 0)
            {
                SkatersGrid.Rows[0].Selected = true;
            }

            string FirstName = SkatersGrid.SelectedRows[0].Cells["FirstName"].Value.ToString();
            string LastName = SkatersGrid.SelectedRows[0].Cells["LastName"].Value.ToString();
            string DOB = SkatersGrid.SelectedRows[0].Cells["DOB"].Value.ToString();
            string Phone = SkatersGrid.SelectedRows[0].Cells["Phone"].Value.ToString();
            string Email = SkatersGrid.SelectedRows[0].Cells["Email"].Value.ToString();

            string sql = string.Format("SELECT * from Skaters WHERE FirstName = '{0}' AND " +
                                        "LastName = '{1}' AND " +
                                        "DOB = '{2}' AND " +
                                        "Phone = '{3}' AND " +
                                        "Email = '{4}'",
                                        FirstName,
                                        LastName,
                                        DOB,
                                        Phone,
                                        Email);

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);
           
            SQLiteDataReader reader = cmd.ExecuteReader();

            reader.Read(); //peak first match

            sktr.Id = Convert.ToInt32 (reader["Id"]);
            sktr.FirstName = reader["FirstName"].ToString();
            sktr.LastName = reader["LastName"].ToString();
            sktr.DOB = reader["DOB"].ToString();
            sktr.Phone = reader["Phone"].ToString();
            sktr.CellPhone = reader["CellPhone"].ToString();
            sktr.Email = reader["Email"].ToString();
            sktr.Sex = reader["Sex"].ToString();
            sktr.StreetAddress = reader["StreetAddress"].ToString();
            sktr.City = reader["City"].ToString();
            sktr.Province = reader["Province"].ToString();
            sktr.PostalCode = reader["PostalCode"].ToString();
            sktr.ParentName = reader["ParentName"].ToString();
            sktr.SkateCanadaN = reader["SkateCanadaN"].ToString();
            sktr.ClubName = reader["ClubName"].ToString();
            sktr.ClubNo = reader["ClubNo"].ToString();
            sktr.HealthCardNo = reader["HealthCardNo"].ToString();
            sktr.CoachName = reader["CoachName"].ToString();
            sktr.LevelRegistered = reader["LevelRegistered"].ToString();
            sktr.TestFreeSkate = reader["TestFreeSkate"].ToString();
            sktr.TestSkills = reader["TestSkills"].ToString();
            sktr.TestDance = reader["TestDance"].ToString();
            sktr.HighestBadge = reader["HighestBadge"].ToString();
            sktr.LTSDay = reader["LTSDay"].ToString();
            sktr.Notes = reader["Notes"].ToString();

            return sktr;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            showAllSkaters();
        }

        private void buttonUnlimited_Click(object sender, EventArgs e)
        {
            showUnlimitedSkaters();
        }

        private void buttonStarskate_Click(object sender, EventArgs e)
        {
            showStarskateSkaters();
        }

        private void buttonLTS_Click(object sender, EventArgs e)
        {
            showLTSSkaters();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Skater s = FillSkaterProfileFromSelected();
            SkaterProfile dlg = new SkaterProfile();
            dlg.Sktr = s;
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            s = dlg.Sktr;

            UpdateDBfromSkaterProfile(s);
            RefreshCurrentView();            
        }

        private void RefreshCurrentView ()
        {
            switch (currentView)
            {
                case ViewMode.ALL:
                    showAllSkaters();
                    break;
                case ViewMode.UNLIMITED:
                    showUnlimitedSkaters();
                    break;
                case ViewMode.STARSKATE:
                    showStarskateSkaters();
                    break;
                case ViewMode.LTS:
                    showLTSSkaters();
                    break;
            }
        }

        private void UpdateDBfromSkaterProfile(Skater s)
        {
            string sql = string.Format("UPDATE Skaters SET FirstName = '{0}', " +
                                        "LastName = '{1}'," +
                                        "DOB = '{2}', " +
                                        "Phone = '{3}', " +
                                        "CellPhone = '{4}', " +
                                        "Email = '{5}', " +
                                        "Sex = '{6}', " +
                                        "StreetAddress = '{7}', " +
                                        "City = '{8}', " +
                                        "Province = '{9}', " +
                                        "PostalCode = '{10}', " +
                                        "ParentName = '{11}', " +
                                        "SkateCanadaN = '{12}', " +
                                        "ClubName = '{13}', " +
                                        "ClubNo = '{14}', " +
                                        "HealthCardNo = '{15}', " +
                                        "CoachName = '{16}', " +
                                        "LevelRegistered = '{17}', " +
                                        "TestFreeSkate = '{18}', " +
                                        "TestSkills = '{19}', " +
                                        "TestDance = '{20}', " +
                                        "HighestBadge = '{21}', " +
                                        "LTSDay = '{22}', " +
                                        "Notes = '{23}' WHERE Id = {24}",
                                        s.FirstName,
                                        s.LastName,
                                        s.DOB,
                                        s.Phone,
                                        s.CellPhone,
                                        s.Email,
                                        s.Sex,
                                        s.StreetAddress,
                                        s.City,
                                        s.Province,
                                        s.PostalCode,
                                        s.ParentName,
                                        s.SkateCanadaN,
                                        s.ClubName,
                                        s.ClubNo,
                                        s.HealthCardNo,
                                        s.CoachName,
                                        s.LevelRegistered,
                                        s.TestFreeSkate,
                                        s.TestSkills,
                                        s.TestDance,
                                        s.HighestBadge,
                                        s.LTSDay,
                                        s.Notes,
                                        s.Id);

            SQLiteCommand cmd = new SQLiteCommand(sql, m_dbConnection);

            cmd.ExecuteNonQuery();
        }
    }
}
