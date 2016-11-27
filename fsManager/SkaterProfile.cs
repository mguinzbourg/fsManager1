using System;
using System.Windows.Forms;

namespace fsManager
{
    public partial class SkaterProfile : Form
    {
        private Skater sktr;

        internal Skater Sktr
        {
            get
            {
                return sktr;
            }

            set
            {
                sktr = value;
            }
        }

        public SkaterProfile()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            UpdateProfileFromGUI();
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void UpdateProfileFromGUI()
        {
            sktr.FirstName = txtFirstName.Text;
            sktr.LastName = txtLastName.Text;
            sktr.DOB = txtDOB.Text;
            sktr.Phone = txtPhone.Text;
            sktr.CellPhone = txtCellPhone.Text;
            sktr.Email = txtEmail.Text;
            sktr.Sex = txtSex.Text;
            sktr.StreetAddress = txtStreetAddress.Text;
            sktr.City = txtCity.Text;
            sktr.Province = txtProvince.Text;
            sktr.PostalCode = txtPostalCode.Text;
            sktr.ParentName = txtParentName.Text;
            sktr.SkateCanadaN = txtSkateCanadaN.Text;
            sktr.ClubName = txtClubName.Text;
            sktr.ClubNo = txtClubNo.Text;
            sktr.HealthCardNo = txtHealthCardNo.Text;
            sktr.CoachName = txtCoachName.Text;
            sktr.LevelRegistered = txtLevelRegistered.Text;
            sktr.TestFreeSkate = txtTestFreeSkate.Text;
            sktr.TestSkills = txtTestSkills.Text;
            sktr.TestDance = txtTestDance.Text;
            sktr.HighestBadge = txtHighestBadge.Text;
            sktr.LTSDay = txtLTSDay.Text;
            sktr.Notes = txtNotes.Text;
        }

        private void UpdateGUIfromProfile()
        {
            txtFirstName.Text = sktr.FirstName;
            txtLastName.Text = sktr.LastName;
            txtDOB.Text = sktr.DOB;
            txtPhone.Text = sktr.Phone;
            txtCellPhone.Text = sktr.CellPhone;
            txtEmail.Text = sktr.Email;
            txtSex.Text = sktr.Sex;
            txtStreetAddress.Text = sktr.StreetAddress;
            txtCity.Text = sktr.City;
            txtProvince.Text = sktr.Province;
            txtPostalCode.Text = sktr.PostalCode;
            txtParentName.Text = sktr.ParentName;
            txtSkateCanadaN.Text = sktr.SkateCanadaN;
            txtClubName.Text = sktr.ClubName;
            txtClubNo.Text = sktr.ClubNo;
            txtHealthCardNo.Text = sktr.HealthCardNo;
            txtCoachName.Text = sktr.CoachName;
            txtLevelRegistered.Text = sktr.LevelRegistered;
            txtTestFreeSkate.Text = sktr.TestFreeSkate;
            txtTestSkills.Text = sktr.TestSkills;
            txtTestDance.Text = sktr.TestDance;
            txtHighestBadge.Text = sktr.HighestBadge;
            txtLTSDay.Text = sktr.LTSDay;
            txtNotes.Text = sktr.Notes;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SkaterProfile_Load(object sender, EventArgs e)
        {
            if (sktr == null)
            {
                return;
            }

            UpdateGUIfromProfile();
        }
    }
}
