namespace fsManager
{
    partial class MainFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SkatersGrid = new System.Windows.Forms.DataGridView();
            this.buttonAll = new System.Windows.Forms.Button();
            this.buttonUnlimited = new System.Windows.Forms.Button();
            this.buttonStarskate = new System.Windows.Forms.Button();
            this.buttonLTS = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SkatersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // SkatersGrid
            // 
            this.SkatersGrid.AllowUserToAddRows = false;
            this.SkatersGrid.AllowUserToDeleteRows = false;
            this.SkatersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkatersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SkatersGrid.Location = new System.Drawing.Point(0, 0);
            this.SkatersGrid.Name = "SkatersGrid";
            this.SkatersGrid.ReadOnly = true;
            this.SkatersGrid.RowHeadersVisible = false;
            this.SkatersGrid.RowTemplate.Height = 28;
            this.SkatersGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SkatersGrid.Size = new System.Drawing.Size(1172, 750);
            this.SkatersGrid.TabIndex = 0;
            // 
            // buttonAll
            // 
            this.buttonAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAll.Location = new System.Drawing.Point(1178, 8);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(142, 36);
            this.buttonAll.TabIndex = 1;
            this.buttonAll.Text = "All skaters";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // buttonUnlimited
            // 
            this.buttonUnlimited.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUnlimited.Location = new System.Drawing.Point(1178, 50);
            this.buttonUnlimited.Name = "buttonUnlimited";
            this.buttonUnlimited.Size = new System.Drawing.Size(142, 36);
            this.buttonUnlimited.TabIndex = 2;
            this.buttonUnlimited.Text = "Unlimited";
            this.buttonUnlimited.UseVisualStyleBackColor = true;
            this.buttonUnlimited.Click += new System.EventHandler(this.buttonUnlimited_Click);
            // 
            // buttonStarskate
            // 
            this.buttonStarskate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStarskate.Location = new System.Drawing.Point(1178, 92);
            this.buttonStarskate.Name = "buttonStarskate";
            this.buttonStarskate.Size = new System.Drawing.Size(142, 36);
            this.buttonStarskate.TabIndex = 3;
            this.buttonStarskate.Text = "Star Skate";
            this.buttonStarskate.UseVisualStyleBackColor = true;
            this.buttonStarskate.Click += new System.EventHandler(this.buttonStarskate_Click);
            // 
            // buttonLTS
            // 
            this.buttonLTS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLTS.Location = new System.Drawing.Point(1178, 134);
            this.buttonLTS.Name = "buttonLTS";
            this.buttonLTS.Size = new System.Drawing.Size(142, 36);
            this.buttonLTS.TabIndex = 4;
            this.buttonLTS.Text = "Learn To Skate";
            this.buttonLTS.UseVisualStyleBackColor = true;
            this.buttonLTS.Click += new System.EventHandler(this.buttonLTS_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonProfile.Location = new System.Drawing.Point(1178, 176);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(142, 36);
            this.buttonProfile.TabIndex = 5;
            this.buttonProfile.Text = "Profile";
            this.buttonProfile.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClose.Location = new System.Drawing.Point(1178, 702);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(142, 36);
            this.buttonClose.TabIndex = 6;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 750);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonLTS);
            this.Controls.Add(this.buttonStarskate);
            this.Controls.Add(this.buttonUnlimited);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.SkatersGrid);
            this.Name = "MainFrm";
            this.Text = "Skaters";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SkatersGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SkatersGrid;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Button buttonUnlimited;
        private System.Windows.Forms.Button buttonStarskate;
        private System.Windows.Forms.Button buttonLTS;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonClose;
    }
}

