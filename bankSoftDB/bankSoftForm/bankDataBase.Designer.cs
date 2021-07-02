namespace bankSoftForm
{
    partial class bankDataBase
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bankDataBase));
            this.panelData = new System.Windows.Forms.Panel();
            this.dataGridClienti = new System.Windows.Forms.DataGridView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelTopSide = new System.Windows.Forms.Panel();
            this.btnLogoDB = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.butonCauta = new System.Windows.Forms.Button();
            this.textCauta = new System.Windows.Forms.TextBox();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.cmsPanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.închideFereastraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ascundeMeniulToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afișeazăMeniuliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDepunere = new System.Windows.Forms.Label();
            this.lblDataNastere = new System.Windows.Forms.Label();
            this.datePickerDepunere = new System.Windows.Forms.DateTimePicker();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.cmbCard = new System.Windows.Forms.ComboBox();
            this.cmbJudet = new System.Windows.Forms.ComboBox();
            this.datePickerData = new System.Windows.Forms.DateTimePicker();
            this.textNume = new System.Windows.Forms.TextBox();
            this.textPrenume = new System.Windows.Forms.TextBox();
            this.textCNP = new System.Windows.Forms.TextBox();
            this.textSold = new System.Windows.Forms.TextBox();
            this.textPerioadaDep = new System.Windows.Forms.TextBox();
            this.textTelefon = new System.Windows.Forms.TextBox();
            this.butonAddClient = new System.Windows.Forms.Button();
            this.textDobanda = new System.Windows.Forms.TextBox();
            this.cmsDataGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ștergeÎnregistrareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reactualizeazăDateleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).BeginInit();
            this.panelTopSide.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.cmsPanel.SuspendLayout();
            this.cmsDataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelData
            // 
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panelData.Controls.Add(this.dataGridClienti);
            this.panelData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelData.Location = new System.Drawing.Point(200, 78);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(699, 445);
            this.panelData.TabIndex = 5;
            // 
            // dataGridClienti
            // 
            this.dataGridClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClienti.ContextMenuStrip = this.cmsDataGrid;
            this.dataGridClienti.Location = new System.Drawing.Point(22, 19);
            this.dataGridClienti.Name = "dataGridClienti";
            this.dataGridClienti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridClienti.Size = new System.Drawing.Size(646, 410);
            this.dataGridClienti.TabIndex = 0;
            this.dataGridClienti.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClienti_CellDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Graphicloads-Polygon-Bank.ico");
            this.imageList1.Images.SetKeyName(1, "Graphicloads-Colorful-Long-Shadow-Bank.ico");
            // 
            // panelTopSide
            // 
            this.panelTopSide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTopSide.BackgroundImage")));
            this.panelTopSide.Controls.Add(this.btnLogoDB);
            this.panelTopSide.Controls.Add(this.btnLogo);
            this.panelTopSide.Controls.Add(this.butonCauta);
            this.panelTopSide.Controls.Add(this.textCauta);
            this.panelTopSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopSide.Location = new System.Drawing.Point(200, 0);
            this.panelTopSide.Name = "panelTopSide";
            this.panelTopSide.Size = new System.Drawing.Size(699, 78);
            this.panelTopSide.TabIndex = 4;
            // 
            // btnLogoDB
            // 
            this.btnLogoDB.BackColor = System.Drawing.Color.Transparent;
            this.btnLogoDB.FlatAppearance.BorderSize = 0;
            this.btnLogoDB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogoDB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogoDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogoDB.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogoDB.ImageIndex = 0;
            this.btnLogoDB.ImageList = this.imageList1;
            this.btnLogoDB.Location = new System.Drawing.Point(631, 18);
            this.btnLogoDB.Name = "btnLogoDB";
            this.btnLogoDB.Size = new System.Drawing.Size(37, 44);
            this.btnLogoDB.TabIndex = 19;
            this.btnLogoDB.UseVisualStyleBackColor = false;
            this.btnLogoDB.MouseLeave += new System.EventHandler(this.buttonLogo_MouseLeave);
            this.btnLogoDB.MouseHover += new System.EventHandler(this.buttonLogo_MouseHover);
            // 
            // btnLogo
            // 
            this.btnLogo.BackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogo.ImageIndex = 0;
            this.btnLogo.Location = new System.Drawing.Point(631, 18);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(37, 44);
            this.btnLogo.TabIndex = 18;
            this.btnLogo.UseVisualStyleBackColor = false;
            // 
            // butonCauta
            // 
            this.butonCauta.BackColor = System.Drawing.Color.Olive;
            this.butonCauta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonCauta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.butonCauta.Image = ((System.Drawing.Image)(resources.GetObject("butonCauta.Image")));
            this.butonCauta.Location = new System.Drawing.Point(390, 32);
            this.butonCauta.Name = "butonCauta";
            this.butonCauta.Size = new System.Drawing.Size(44, 20);
            this.butonCauta.TabIndex = 16;
            this.butonCauta.UseVisualStyleBackColor = false;
            this.butonCauta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonCauta_MouseClick);
            // 
            // textCauta
            // 
            this.textCauta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textCauta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCauta.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCauta.Location = new System.Drawing.Point(110, 32);
            this.textCauta.Name = "textCauta";
            this.textCauta.Size = new System.Drawing.Size(285, 20);
            this.textCauta.TabIndex = 15;
            this.textCauta.Text = "Caută [CNP]";
            this.textCauta.Enter += new System.EventHandler(this.textCauta_Enter);
            this.textCauta.Leave += new System.EventHandler(this.textCauta_Leave);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSideMenu.BackgroundImage")));
            this.panelSideMenu.ContextMenuStrip = this.cmsPanel;
            this.panelSideMenu.Controls.Add(this.lblDepunere);
            this.panelSideMenu.Controls.Add(this.lblDataNastere);
            this.panelSideMenu.Controls.Add(this.datePickerDepunere);
            this.panelSideMenu.Controls.Add(this.textEmail);
            this.panelSideMenu.Controls.Add(this.cmbCard);
            this.panelSideMenu.Controls.Add(this.cmbJudet);
            this.panelSideMenu.Controls.Add(this.datePickerData);
            this.panelSideMenu.Controls.Add(this.textNume);
            this.panelSideMenu.Controls.Add(this.textPrenume);
            this.panelSideMenu.Controls.Add(this.textCNP);
            this.panelSideMenu.Controls.Add(this.textSold);
            this.panelSideMenu.Controls.Add(this.textPerioadaDep);
            this.panelSideMenu.Controls.Add(this.textTelefon);
            this.panelSideMenu.Controls.Add(this.butonAddClient);
            this.panelSideMenu.Controls.Add(this.textDobanda);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 523);
            this.panelSideMenu.TabIndex = 3;
            // 
            // cmsPanel
            // 
            this.cmsPanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.închideFereastraToolStripMenuItem,
            this.ascundeMeniulToolStripMenuItem,
            this.afișeazăMeniuliToolStripMenuItem});
            this.cmsPanel.Name = "contextMenuStrip2";
            this.cmsPanel.Size = new System.Drawing.Size(168, 70);
            // 
            // închideFereastraToolStripMenuItem
            // 
            this.închideFereastraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("închideFereastraToolStripMenuItem.Image")));
            this.închideFereastraToolStripMenuItem.Name = "închideFereastraToolStripMenuItem";
            this.închideFereastraToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.închideFereastraToolStripMenuItem.Text = "Închide fereastra";
            this.închideFereastraToolStripMenuItem.Click += new System.EventHandler(this.închideFereastraToolStripMenuItem_Click);
            // 
            // ascundeMeniulToolStripMenuItem
            // 
            this.ascundeMeniulToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ascundeMeniulToolStripMenuItem.Image")));
            this.ascundeMeniulToolStripMenuItem.Name = "ascundeMeniulToolStripMenuItem";
            this.ascundeMeniulToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.ascundeMeniulToolStripMenuItem.Text = "Blochează meniul";
            this.ascundeMeniulToolStripMenuItem.Click += new System.EventHandler(this.ascundeMeniulToolStripMenuItem_Click);
            // 
            // afișeazăMeniuliToolStripMenuItem
            // 
            this.afișeazăMeniuliToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("afișeazăMeniuliToolStripMenuItem.Image")));
            this.afișeazăMeniuliToolStripMenuItem.Name = "afișeazăMeniuliToolStripMenuItem";
            this.afișeazăMeniuliToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.afișeazăMeniuliToolStripMenuItem.Text = "Activează meniul";
            this.afișeazăMeniuliToolStripMenuItem.Click += new System.EventHandler(this.afișeazăMeniuliToolStripMenuItem_Click);
            // 
            // lblDepunere
            // 
            this.lblDepunere.AutoSize = true;
            this.lblDepunere.BackColor = System.Drawing.Color.Transparent;
            this.lblDepunere.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDepunere.Location = new System.Drawing.Point(46, 411);
            this.lblDepunere.Name = "lblDepunere";
            this.lblDepunere.Size = new System.Drawing.Size(76, 13);
            this.lblDepunere.TabIndex = 92;
            this.lblDepunere.Text = "Data depunerii";
            // 
            // lblDataNastere
            // 
            this.lblDataNastere.AutoSize = true;
            this.lblDataNastere.BackColor = System.Drawing.Color.Transparent;
            this.lblDataNastere.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblDataNastere.Location = new System.Drawing.Point(46, 235);
            this.lblDataNastere.Name = "lblDataNastere";
            this.lblDataNastere.Size = new System.Drawing.Size(66, 13);
            this.lblDataNastere.TabIndex = 91;
            this.lblDataNastere.Text = "Data nașterii";
            // 
            // datePickerDepunere
            // 
            this.datePickerDepunere.AccessibleDescription = "Data nasterii";
            this.datePickerDepunere.Location = new System.Drawing.Point(49, 424);
            this.datePickerDepunere.Name = "datePickerDepunere";
            this.datePickerDepunere.Size = new System.Drawing.Size(100, 20);
            this.datePickerDepunere.TabIndex = 90;
            // 
            // textEmail
            // 
            this.textEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmail.Location = new System.Drawing.Point(49, 182);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(100, 20);
            this.textEmail.TabIndex = 89;
            this.textEmail.Text = "Email";
            this.textEmail.Enter += new System.EventHandler(this.EmailText_Enter);
            this.textEmail.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // cmbCard
            // 
            this.cmbCard.BackColor = System.Drawing.Color.Olive;
            this.cmbCard.FormattingEnabled = true;
            this.cmbCard.Location = new System.Drawing.Point(49, 387);
            this.cmbCard.Name = "cmbCard";
            this.cmbCard.Size = new System.Drawing.Size(100, 21);
            this.cmbCard.TabIndex = 88;
            this.cmbCard.Text = "Card";
            // 
            // cmbJudet
            // 
            this.cmbJudet.BackColor = System.Drawing.Color.Olive;
            this.cmbJudet.FormattingEnabled = true;
            this.cmbJudet.Location = new System.Drawing.Point(49, 208);
            this.cmbJudet.Name = "cmbJudet";
            this.cmbJudet.Size = new System.Drawing.Size(100, 21);
            this.cmbJudet.TabIndex = 87;
            this.cmbJudet.Text = "Județ";
            // 
            // datePickerData
            // 
            this.datePickerData.AccessibleDescription = "Data nasterii";
            this.datePickerData.CalendarMonthBackground = System.Drawing.Color.Olive;
            this.datePickerData.Location = new System.Drawing.Point(49, 251);
            this.datePickerData.Name = "datePickerData";
            this.datePickerData.Size = new System.Drawing.Size(100, 20);
            this.datePickerData.TabIndex = 86;
            // 
            // textNume
            // 
            this.textNume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textNume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNume.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNume.Location = new System.Drawing.Point(49, 78);
            this.textNume.Name = "textNume";
            this.textNume.Size = new System.Drawing.Size(100, 20);
            this.textNume.TabIndex = 76;
            this.textNume.Text = "Nume";
            this.textNume.Enter += new System.EventHandler(this.NumeText_Enter);
            this.textNume.Leave += new System.EventHandler(this.NumeText_Leave);
            // 
            // textPrenume
            // 
            this.textPrenume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPrenume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrenume.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPrenume.Location = new System.Drawing.Point(49, 104);
            this.textPrenume.Name = "textPrenume";
            this.textPrenume.Size = new System.Drawing.Size(100, 20);
            this.textPrenume.TabIndex = 77;
            this.textPrenume.Text = "Prenume";
            this.textPrenume.Enter += new System.EventHandler(this.PrenumeText_Enter);
            this.textPrenume.Leave += new System.EventHandler(this.PrenumeText_Leave);
            // 
            // textCNP
            // 
            this.textCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textCNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCNP.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCNP.Location = new System.Drawing.Point(49, 130);
            this.textCNP.Name = "textCNP";
            this.textCNP.Size = new System.Drawing.Size(100, 20);
            this.textCNP.TabIndex = 78;
            this.textCNP.Text = "CNP";
            this.textCNP.Enter += new System.EventHandler(this.CNPText_Enter);
            this.textCNP.Leave += new System.EventHandler(this.CNPText_Leave);
            // 
            // textSold
            // 
            this.textSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textSold.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSold.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textSold.Location = new System.Drawing.Point(49, 335);
            this.textSold.Name = "textSold";
            this.textSold.Size = new System.Drawing.Size(100, 20);
            this.textSold.TabIndex = 79;
            this.textSold.Text = "Sold [LEI]";
            this.textSold.Enter += new System.EventHandler(this.SoldText_Enter);
            this.textSold.Leave += new System.EventHandler(this.SoldText_Leave);
            // 
            // textPerioadaDep
            // 
            this.textPerioadaDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPerioadaDep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPerioadaDep.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPerioadaDep.Location = new System.Drawing.Point(49, 309);
            this.textPerioadaDep.Name = "textPerioadaDep";
            this.textPerioadaDep.Size = new System.Drawing.Size(100, 20);
            this.textPerioadaDep.TabIndex = 80;
            this.textPerioadaDep.Text = "Perioada [LUNI]";
            this.textPerioadaDep.Enter += new System.EventHandler(this.PerioadaText_Enter);
            this.textPerioadaDep.Leave += new System.EventHandler(this.PerioadaText_Leave);
            // 
            // textTelefon
            // 
            this.textTelefon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefon.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textTelefon.Location = new System.Drawing.Point(49, 156);
            this.textTelefon.Name = "textTelefon";
            this.textTelefon.Size = new System.Drawing.Size(100, 20);
            this.textTelefon.TabIndex = 81;
            this.textTelefon.Text = "Telefon [+40]";
            this.textTelefon.Enter += new System.EventHandler(this.TelefonText_Enter);
            this.textTelefon.Leave += new System.EventHandler(this.TelefonText_Leave);
            // 
            // butonAddClient
            // 
            this.butonAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butonAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonAddClient.ForeColor = System.Drawing.Color.DimGray;
            this.butonAddClient.Location = new System.Drawing.Point(59, 468);
            this.butonAddClient.Name = "butonAddClient";
            this.butonAddClient.Size = new System.Drawing.Size(75, 23);
            this.butonAddClient.TabIndex = 83;
            this.butonAddClient.Text = "Adauga";
            this.butonAddClient.UseVisualStyleBackColor = false;
            this.butonAddClient.Click += new System.EventHandler(this.butonAddClient_Click);
            // 
            // textDobanda
            // 
            this.textDobanda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textDobanda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDobanda.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textDobanda.Location = new System.Drawing.Point(49, 361);
            this.textDobanda.Name = "textDobanda";
            this.textDobanda.Size = new System.Drawing.Size(100, 20);
            this.textDobanda.TabIndex = 82;
            this.textDobanda.Text = "Dobândă";
            this.textDobanda.Enter += new System.EventHandler(this.DobandaText_Enter);
            this.textDobanda.Leave += new System.EventHandler(this.DobandaText_Leave);
            // 
            // cmsDataGrid
            // 
            this.cmsDataGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ștergeÎnregistrareaToolStripMenuItem,
            this.reactualizeazăDateleToolStripMenuItem});
            this.cmsDataGrid.Name = "cmsDataGrid";
            this.cmsDataGrid.Size = new System.Drawing.Size(186, 70);
            // 
            // ștergeÎnregistrareaToolStripMenuItem
            // 
            this.ștergeÎnregistrareaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ștergeÎnregistrareaToolStripMenuItem.Image")));
            this.ștergeÎnregistrareaToolStripMenuItem.Name = "ștergeÎnregistrareaToolStripMenuItem";
            this.ștergeÎnregistrareaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.ștergeÎnregistrareaToolStripMenuItem.Text = "Șterge înregistrarea";
            this.ștergeÎnregistrareaToolStripMenuItem.Click += new System.EventHandler(this.ștergeÎnregistrareaToolStripMenuItem_Click);
            // 
            // reactualizeazăDateleToolStripMenuItem
            // 
            this.reactualizeazăDateleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reactualizeazăDateleToolStripMenuItem.Image")));
            this.reactualizeazăDateleToolStripMenuItem.Name = "reactualizeazăDateleToolStripMenuItem";
            this.reactualizeazăDateleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.reactualizeazăDateleToolStripMenuItem.Text = "Reactualizează datele";
            this.reactualizeazăDateleToolStripMenuItem.Click += new System.EventHandler(this.reactualizeazăDateleToolStripMenuItem_Click);
            // 
            // bankDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 523);
            this.Controls.Add(this.panelData);
            this.Controls.Add(this.panelTopSide);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "bankDataBase";
            this.Text = "bankDataBase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.bankDataBase_FormClosed);
            this.Load += new System.EventHandler(this.bankDataBase_Load);
            this.panelData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClienti)).EndInit();
            this.panelTopSide.ResumeLayout(false);
            this.panelTopSide.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelSideMenu.PerformLayout();
            this.cmsPanel.ResumeLayout(false);
            this.cmsDataGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelData;
        private System.Windows.Forms.DataGridView dataGridClienti;
        private System.Windows.Forms.Panel panelTopSide;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.Button butonCauta;
        private System.Windows.Forms.TextBox textCauta;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.TextBox textNume;
        private System.Windows.Forms.TextBox textPrenume;
        private System.Windows.Forms.TextBox textCNP;
        private System.Windows.Forms.TextBox textSold;
        private System.Windows.Forms.TextBox textPerioadaDep;
        private System.Windows.Forms.TextBox textTelefon;
        private System.Windows.Forms.Button butonAddClient;
        private System.Windows.Forms.TextBox textDobanda;
        private System.Windows.Forms.ComboBox cmbCard;
        private System.Windows.Forms.ComboBox cmbJudet;
        public System.Windows.Forms.DateTimePicker datePickerData;
        private System.Windows.Forms.DateTimePicker datePickerDepunere;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnLogoDB;
        private System.Windows.Forms.Label lblDepunere;
        private System.Windows.Forms.Label lblDataNastere;
        private System.Windows.Forms.ContextMenuStrip cmsPanel;
        private System.Windows.Forms.ToolStripMenuItem închideFereastraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ascundeMeniulToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afișeazăMeniuliToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsDataGrid;
        private System.Windows.Forms.ToolStripMenuItem ștergeÎnregistrareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reactualizeazăDateleToolStripMenuItem;
    }
}