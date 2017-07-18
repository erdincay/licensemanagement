namespace LicenseManagement
{
    partial class frmLicenseManagement
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLicenseManagement));
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.lblQuickSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlPadding = new System.Windows.Forms.Panel();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnSaveCustomer = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.lblContactPerson = new System.Windows.Forms.Label();
            this.dtpLastMaintenance = new System.Windows.Forms.DateTimePicker();
            this.txtSoftwareVersion = new System.Windows.Forms.TextBox();
            this.lblSoftwareVersion = new System.Windows.Forms.Label();
            this.txtLicenseKeys = new System.Windows.Forms.TextBox();
            this.lblLicenseKeys = new System.Windows.Forms.Label();
            this.lblSupportService = new System.Windows.Forms.Label();
            this.lblLastMaintenance = new System.Windows.Forms.Label();
            this.txtRentFee = new System.Windows.Forms.TextBox();
            this.lblRentFee = new System.Windows.Forms.Label();
            this.txtLicenseAmount = new System.Windows.Forms.TextBox();
            this.lblLicenseAmount = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.lstLicenseOwners = new System.Windows.Forms.ListView();
            this.dgvLicenseOwners = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chbSupportService = new System.Windows.Forms.CheckBox();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.mnuMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlPadding.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseOwners)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.BackColor = System.Drawing.Color.LightGray;
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(1331, 24);
            this.mnuMenu.TabIndex = 1;
            this.mnuMenu.Text = "Menu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "&Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblQuickSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1331, 48);
            this.panel1.TabIndex = 5;
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "customer.png");
            // 
            // lblQuickSearch
            // 
            this.lblQuickSearch.AutoSize = true;
            this.lblQuickSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuickSearch.ForeColor = System.Drawing.Color.White;
            this.lblQuickSearch.Location = new System.Drawing.Point(16, 19);
            this.lblQuickSearch.Name = "lblQuickSearch";
            this.lblQuickSearch.Size = new System.Drawing.Size(80, 13);
            this.lblQuickSearch.TabIndex = 0;
            this.lblQuickSearch.Text = "QuickSearch";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(119, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // pnlPadding
            // 
            this.pnlPadding.BackColor = System.Drawing.Color.LightGray;
            this.pnlPadding.Controls.Add(this.lstLicenseOwners);
            this.pnlPadding.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlPadding.Location = new System.Drawing.Point(0, 487);
            this.pnlPadding.Name = "pnlPadding";
            this.pnlPadding.Padding = new System.Windows.Forms.Padding(5, 15, 5, 5);
            this.pnlPadding.Size = new System.Drawing.Size(1331, 84);
            this.pnlPadding.TabIndex = 11;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.Color.DarkGray;
            this.pnlDetails.Controls.Add(this.btnDeleteCustomer);
            this.pnlDetails.Controls.Add(this.chbSupportService);
            this.pnlDetails.Controls.Add(this.btnSaveCustomer);
            this.pnlDetails.Controls.Add(this.btnNewCustomer);
            this.pnlDetails.Controls.Add(this.txtContactPerson);
            this.pnlDetails.Controls.Add(this.lblContactPerson);
            this.pnlDetails.Controls.Add(this.dtpLastMaintenance);
            this.pnlDetails.Controls.Add(this.txtSoftwareVersion);
            this.pnlDetails.Controls.Add(this.lblSoftwareVersion);
            this.pnlDetails.Controls.Add(this.txtLicenseKeys);
            this.pnlDetails.Controls.Add(this.lblLicenseKeys);
            this.pnlDetails.Controls.Add(this.lblSupportService);
            this.pnlDetails.Controls.Add(this.lblLastMaintenance);
            this.pnlDetails.Controls.Add(this.txtRentFee);
            this.pnlDetails.Controls.Add(this.lblRentFee);
            this.pnlDetails.Controls.Add(this.txtLicenseAmount);
            this.pnlDetails.Controls.Add(this.lblLicenseAmount);
            this.pnlDetails.Controls.Add(this.txtCustomerName);
            this.pnlDetails.Controls.Add(this.lblCustomerName);
            this.pnlDetails.Controls.Add(this.txtCustomerID);
            this.pnlDetails.Controls.Add(this.lblCustomerID);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlDetails.Location = new System.Drawing.Point(0, 72);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(342, 415);
            this.pnlDetails.TabIndex = 12;
            // 
            // btnSaveCustomer
            // 
            this.btnSaveCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSaveCustomer.Location = new System.Drawing.Point(203, 365);
            this.btnSaveCustomer.Name = "btnSaveCustomer";
            this.btnSaveCustomer.Size = new System.Drawing.Size(125, 26);
            this.btnSaveCustomer.TabIndex = 10;
            this.btnSaveCustomer.Text = "save";
            this.btnSaveCustomer.UseVisualStyleBackColor = false;
            this.btnSaveCustomer.Click += new System.EventHandler(this.btnSaveCustomer_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewCustomer.Location = new System.Drawing.Point(119, 365);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(78, 26);
            this.btnNewCustomer.TabIndex = 11;
            this.btnNewCustomer.Text = "new";
            this.btnNewCustomer.UseVisualStyleBackColor = false;
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Location = new System.Drawing.Point(119, 321);
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(209, 20);
            this.txtContactPerson.TabIndex = 9;
            // 
            // lblContactPerson
            // 
            this.lblContactPerson.AutoSize = true;
            this.lblContactPerson.Location = new System.Drawing.Point(17, 324);
            this.lblContactPerson.Name = "lblContactPerson";
            this.lblContactPerson.Size = new System.Drawing.Size(80, 13);
            this.lblContactPerson.TabIndex = 16;
            this.lblContactPerson.Text = "Contact Person";
            // 
            // dtpLastMaintenance
            // 
            this.dtpLastMaintenance.CustomFormat = "yyyy-MM-dd";
            this.dtpLastMaintenance.Location = new System.Drawing.Point(119, 158);
            this.dtpLastMaintenance.Name = "dtpLastMaintenance";
            this.dtpLastMaintenance.Size = new System.Drawing.Size(209, 20);
            this.dtpLastMaintenance.TabIndex = 5;
            // 
            // txtSoftwareVersion
            // 
            this.txtSoftwareVersion.Location = new System.Drawing.Point(119, 286);
            this.txtSoftwareVersion.Name = "txtSoftwareVersion";
            this.txtSoftwareVersion.Size = new System.Drawing.Size(209, 20);
            this.txtSoftwareVersion.TabIndex = 8;
            // 
            // lblSoftwareVersion
            // 
            this.lblSoftwareVersion.AutoSize = true;
            this.lblSoftwareVersion.Location = new System.Drawing.Point(17, 289);
            this.lblSoftwareVersion.Name = "lblSoftwareVersion";
            this.lblSoftwareVersion.Size = new System.Drawing.Size(87, 13);
            this.lblSoftwareVersion.TabIndex = 14;
            this.lblSoftwareVersion.Text = "Software Version";
            // 
            // txtLicenseKeys
            // 
            this.txtLicenseKeys.Location = new System.Drawing.Point(119, 224);
            this.txtLicenseKeys.Multiline = true;
            this.txtLicenseKeys.Name = "txtLicenseKeys";
            this.txtLicenseKeys.Size = new System.Drawing.Size(209, 49);
            this.txtLicenseKeys.TabIndex = 7;
            // 
            // lblLicenseKeys
            // 
            this.lblLicenseKeys.AutoSize = true;
            this.lblLicenseKeys.Location = new System.Drawing.Point(17, 227);
            this.lblLicenseKeys.Name = "lblLicenseKeys";
            this.lblLicenseKeys.Size = new System.Drawing.Size(70, 13);
            this.lblLicenseKeys.TabIndex = 12;
            this.lblLicenseKeys.Text = "License Keys";
            // 
            // lblSupportService
            // 
            this.lblSupportService.AutoSize = true;
            this.lblSupportService.Location = new System.Drawing.Point(17, 194);
            this.lblSupportService.Name = "lblSupportService";
            this.lblSupportService.Size = new System.Drawing.Size(44, 13);
            this.lblSupportService.TabIndex = 10;
            this.lblSupportService.Text = "Support";
            // 
            // lblLastMaintenance
            // 
            this.lblLastMaintenance.AutoSize = true;
            this.lblLastMaintenance.Location = new System.Drawing.Point(17, 161);
            this.lblLastMaintenance.Name = "lblLastMaintenance";
            this.lblLastMaintenance.Size = new System.Drawing.Size(92, 13);
            this.lblLastMaintenance.TabIndex = 8;
            this.lblLastMaintenance.Text = "Last Maintenance";
            // 
            // txtRentFee
            // 
            this.txtRentFee.Location = new System.Drawing.Point(119, 125);
            this.txtRentFee.Name = "txtRentFee";
            this.txtRentFee.Size = new System.Drawing.Size(209, 20);
            this.txtRentFee.TabIndex = 4;
            this.txtRentFee.TextChanged += new System.EventHandler(this.txtRentFee_TextChanged);
            // 
            // lblRentFee
            // 
            this.lblRentFee.AutoSize = true;
            this.lblRentFee.Location = new System.Drawing.Point(17, 128);
            this.lblRentFee.Name = "lblRentFee";
            this.lblRentFee.Size = new System.Drawing.Size(51, 13);
            this.lblRentFee.TabIndex = 6;
            this.lblRentFee.Text = "Rent Fee";
            // 
            // txtLicenseAmount
            // 
            this.txtLicenseAmount.Location = new System.Drawing.Point(119, 92);
            this.txtLicenseAmount.Name = "txtLicenseAmount";
            this.txtLicenseAmount.Size = new System.Drawing.Size(209, 20);
            this.txtLicenseAmount.TabIndex = 3;
            this.txtLicenseAmount.TextChanged += new System.EventHandler(this.txtLicenseAmount_TextChanged);
            // 
            // lblLicenseAmount
            // 
            this.lblLicenseAmount.AutoSize = true;
            this.lblLicenseAmount.Location = new System.Drawing.Point(17, 95);
            this.lblLicenseAmount.Name = "lblLicenseAmount";
            this.lblLicenseAmount.Size = new System.Drawing.Size(83, 13);
            this.lblLicenseAmount.TabIndex = 4;
            this.lblLicenseAmount.Text = "License Amount";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(119, 59);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(209, 20);
            this.txtCustomerName.TabIndex = 2;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(16, 62);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(35, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Name";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(119, 26);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(209, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerID.Location = new System.Drawing.Point(16, 29);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(20, 13);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "ID";
            // 
            // lstLicenseOwners
            // 
            this.lstLicenseOwners.BackColor = System.Drawing.Color.LightGray;
            this.lstLicenseOwners.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstLicenseOwners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstLicenseOwners.LargeImageList = this.imgList;
            this.lstLicenseOwners.Location = new System.Drawing.Point(5, 15);
            this.lstLicenseOwners.MultiSelect = false;
            this.lstLicenseOwners.Name = "lstLicenseOwners";
            this.lstLicenseOwners.Size = new System.Drawing.Size(1321, 64);
            this.lstLicenseOwners.SmallImageList = this.imgList;
            this.lstLicenseOwners.TabIndex = 9;
            this.lstLicenseOwners.TileSize = new System.Drawing.Size(10, 10);
            this.lstLicenseOwners.UseCompatibleStateImageBehavior = false;
            this.lstLicenseOwners.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstLicenseOwners_ItemSelectionChanged);
            // 
            // dgvLicenseOwners
            // 
            this.dgvLicenseOwners.AllowUserToOrderColumns = true;
            this.dgvLicenseOwners.BackgroundColor = System.Drawing.Color.White;
            this.dgvLicenseOwners.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLicenseOwners.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLicenseOwners.Location = new System.Drawing.Point(342, 72);
            this.dgvLicenseOwners.Name = "dgvLicenseOwners";
            this.dgvLicenseOwners.Size = new System.Drawing.Size(989, 415);
            this.dgvLicenseOwners.TabIndex = 13;
            this.dgvLicenseOwners.SelectionChanged += new System.EventHandler(this.dgvLicenseOwners_SelectionChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSearch.Location = new System.Drawing.Point(292, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(36, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = ">";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chbSupportService
            // 
            this.chbSupportService.AutoSize = true;
            this.chbSupportService.Location = new System.Drawing.Point(119, 194);
            this.chbSupportService.Name = "chbSupportService";
            this.chbSupportService.Size = new System.Drawing.Size(68, 17);
            this.chbSupportService.TabIndex = 6;
            this.chbSupportService.Text = "available";
            this.chbSupportService.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteCustomer.Location = new System.Drawing.Point(19, 365);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(58, 26);
            this.btnDeleteCustomer.TabIndex = 12;
            this.btnDeleteCustomer.Text = "delete";
            this.btnDeleteCustomer.UseVisualStyleBackColor = false;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // frmLicenseManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1331, 571);
            this.Controls.Add(this.dgvLicenseOwners);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlPadding);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmLicenseManagement";
            this.Text = "License Management";
            this.Load += new System.EventHandler(this.frmLicenseManagement_Load);
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPadding.ResumeLayout(false);
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLicenseOwners)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imgList;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblQuickSearch;
        private System.Windows.Forms.Panel pnlPadding;
        private System.Windows.Forms.ListView lstLicenseOwners;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.Button btnSaveCustomer;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label lblContactPerson;
        private System.Windows.Forms.DateTimePicker dtpLastMaintenance;
        private System.Windows.Forms.TextBox txtSoftwareVersion;
        private System.Windows.Forms.Label lblSoftwareVersion;
        private System.Windows.Forms.TextBox txtLicenseKeys;
        private System.Windows.Forms.Label lblLicenseKeys;
        private System.Windows.Forms.Label lblSupportService;
        private System.Windows.Forms.Label lblLastMaintenance;
        private System.Windows.Forms.TextBox txtRentFee;
        private System.Windows.Forms.Label lblRentFee;
        private System.Windows.Forms.TextBox txtLicenseAmount;
        private System.Windows.Forms.Label lblLicenseAmount;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.DataGridView dgvLicenseOwners;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chbSupportService;
        private System.Windows.Forms.Button btnDeleteCustomer;
    }
}

