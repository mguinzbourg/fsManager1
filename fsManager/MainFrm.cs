using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fsManager
{
    public partial class MainFrm : Form
    {
        SQLiteConnection m_dbConnection;
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
