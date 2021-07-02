namespace bankSoftForm
{
    partial class UpdateFormDataBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFormDataBase));
            this.panelUpdate = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerDataNasterii = new System.Windows.Forms.DateTimePicker();
            this.lbIdCont = new System.Windows.Forms.Label();
            this.lbIdClient = new System.Windows.Forms.Label();
            this.textDobandaUpdate = new System.Windows.Forms.TextBox();
            this.cmbCardUpdate = new System.Windows.Forms.ComboBox();
            this.cmbJudetUpdate = new System.Windows.Forms.ComboBox();
            this.lbData = new System.Windows.Forms.Label();
            this.datePickerDepunereUpdate = new System.Windows.Forms.DateTimePicker();
            this.butonUpdateClient = new System.Windows.Forms.Button();
            this.textTelefonUpdate = new System.Windows.Forms.TextBox();
            this.textEmailUpdate = new System.Windows.Forms.TextBox();
            this.textNumeUpdate = new System.Windows.Forms.TextBox();
            this.textPrenumeUpdate = new System.Windows.Forms.TextBox();
            this.textCNPUpdate = new System.Windows.Forms.TextBox();
            this.textSoldUpdate = new System.Windows.Forms.TextBox();
            this.textPerioadaDepUpdate = new System.Windows.Forms.TextBox();
            this.panelUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelUpdate
            // 
            this.panelUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUpdate.BackgroundImage")));
            this.panelUpdate.Controls.Add(this.label1);
            this.panelUpdate.Controls.Add(this.datePickerDataNasterii);
            this.panelUpdate.Controls.Add(this.lbIdCont);
            this.panelUpdate.Controls.Add(this.lbIdClient);
            this.panelUpdate.Controls.Add(this.textDobandaUpdate);
            this.panelUpdate.Controls.Add(this.cmbCardUpdate);
            this.panelUpdate.Controls.Add(this.cmbJudetUpdate);
            this.panelUpdate.Controls.Add(this.lbData);
            this.panelUpdate.Controls.Add(this.datePickerDepunereUpdate);
            this.panelUpdate.Controls.Add(this.butonUpdateClient);
            this.panelUpdate.Controls.Add(this.textTelefonUpdate);
            this.panelUpdate.Controls.Add(this.textEmailUpdate);
            this.panelUpdate.Controls.Add(this.textNumeUpdate);
            this.panelUpdate.Controls.Add(this.textPrenumeUpdate);
            this.panelUpdate.Controls.Add(this.textCNPUpdate);
            this.panelUpdate.Controls.Add(this.textSoldUpdate);
            this.panelUpdate.Controls.Add(this.textPerioadaDepUpdate);
            this.panelUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUpdate.Location = new System.Drawing.Point(0, 0);
            this.panelUpdate.Name = "panelUpdate";
            this.panelUpdate.Size = new System.Drawing.Size(321, 350);
            this.panelUpdate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(32, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 104;
            this.label1.Text = "Data nașterii";
            // 
            // datePickerDataNasterii
            // 
            this.datePickerDataNasterii.Location = new System.Drawing.Point(35, 221);
            this.datePickerDataNasterii.Name = "datePickerDataNasterii";
            this.datePickerDataNasterii.Size = new System.Drawing.Size(100, 20);
            this.datePickerDataNasterii.TabIndex = 103;
            // 
            // lbIdCont
            // 
            this.lbIdCont.AutoSize = true;
            this.lbIdCont.BackColor = System.Drawing.Color.Transparent;
            this.lbIdCont.ForeColor = System.Drawing.Color.Transparent;
            this.lbIdCont.Location = new System.Drawing.Point(53, 9);
            this.lbIdCont.Name = "lbIdCont";
            this.lbIdCont.Size = new System.Drawing.Size(0, 13);
            this.lbIdCont.TabIndex = 102;
            this.lbIdCont.Visible = false;
            // 
            // lbIdClient
            // 
            this.lbIdClient.AutoSize = true;
            this.lbIdClient.BackColor = System.Drawing.Color.Transparent;
            this.lbIdClient.ForeColor = System.Drawing.Color.Transparent;
            this.lbIdClient.Location = new System.Drawing.Point(3, 9);
            this.lbIdClient.Name = "lbIdClient";
            this.lbIdClient.Size = new System.Drawing.Size(0, 13);
            this.lbIdClient.TabIndex = 101;
            this.lbIdClient.Visible = false;
            // 
            // textDobandaUpdate
            // 
            this.textDobandaUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textDobandaUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textDobandaUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textDobandaUpdate.Location = new System.Drawing.Point(182, 102);
            this.textDobandaUpdate.Name = "textDobandaUpdate";
            this.textDobandaUpdate.Size = new System.Drawing.Size(100, 20);
            this.textDobandaUpdate.TabIndex = 100;
            this.textDobandaUpdate.Text = "Dobândă";
            this.textDobandaUpdate.Enter += new System.EventHandler(this.DobandaText_Enter);
            this.textDobandaUpdate.Leave += new System.EventHandler(this.DobandaText_Leave);
            // 
            // cmbCardUpdate
            // 
            this.cmbCardUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbCardUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCardUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbCardUpdate.FormattingEnabled = true;
            this.cmbCardUpdate.Location = new System.Drawing.Point(182, 128);
            this.cmbCardUpdate.Name = "cmbCardUpdate";
            this.cmbCardUpdate.Size = new System.Drawing.Size(101, 21);
            this.cmbCardUpdate.TabIndex = 99;
            this.cmbCardUpdate.Text = "Card";
            // 
            // cmbJudetUpdate
            // 
            this.cmbJudetUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmbJudetUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbJudetUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.cmbJudetUpdate.FormattingEnabled = true;
            this.cmbJudetUpdate.Location = new System.Drawing.Point(35, 183);
            this.cmbJudetUpdate.Name = "cmbJudetUpdate";
            this.cmbJudetUpdate.Size = new System.Drawing.Size(101, 21);
            this.cmbJudetUpdate.TabIndex = 98;
            this.cmbJudetUpdate.Text = "Județ";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.BackColor = System.Drawing.Color.Transparent;
            this.lbData.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lbData.Location = new System.Drawing.Point(179, 207);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(80, 13);
            this.lbData.TabIndex = 96;
            this.lbData.Text = "Data depozitării";
            // 
            // datePickerDepunereUpdate
            // 
            this.datePickerDepunereUpdate.AccessibleDescription = "Data nasterii";
            this.datePickerDepunereUpdate.Location = new System.Drawing.Point(183, 221);
            this.datePickerDepunereUpdate.Name = "datePickerDepunereUpdate";
            this.datePickerDepunereUpdate.Size = new System.Drawing.Size(100, 20);
            this.datePickerDepunereUpdate.TabIndex = 91;
            // 
            // butonUpdateClient
            // 
            this.butonUpdateClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.butonUpdateClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butonUpdateClient.ForeColor = System.Drawing.Color.DimGray;
            this.butonUpdateClient.Location = new System.Drawing.Point(106, 279);
            this.butonUpdateClient.Name = "butonUpdateClient";
            this.butonUpdateClient.Size = new System.Drawing.Size(105, 40);
            this.butonUpdateClient.TabIndex = 91;
            this.butonUpdateClient.Text = "Modifica";
            this.butonUpdateClient.UseVisualStyleBackColor = false;
            this.butonUpdateClient.MouseClick += new System.Windows.Forms.MouseEventHandler(this.butonUpdateClient_MouseClick);
            // 
            // textTelefonUpdate
            // 
            this.textTelefonUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textTelefonUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textTelefonUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textTelefonUpdate.Location = new System.Drawing.Point(35, 128);
            this.textTelefonUpdate.Name = "textTelefonUpdate";
            this.textTelefonUpdate.Size = new System.Drawing.Size(100, 20);
            this.textTelefonUpdate.TabIndex = 87;
            this.textTelefonUpdate.Text = "Telefon [+40]";
            this.textTelefonUpdate.Enter += new System.EventHandler(this.TelefonText_Enter);
            this.textTelefonUpdate.Leave += new System.EventHandler(this.TelefonText_Leave);
            // 
            // textEmailUpdate
            // 
            this.textEmailUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textEmailUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEmailUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textEmailUpdate.Location = new System.Drawing.Point(35, 154);
            this.textEmailUpdate.Name = "textEmailUpdate";
            this.textEmailUpdate.Size = new System.Drawing.Size(100, 20);
            this.textEmailUpdate.TabIndex = 88;
            this.textEmailUpdate.Text = "Email";
            this.textEmailUpdate.Enter += new System.EventHandler(this.EmailText_Enter);
            this.textEmailUpdate.Leave += new System.EventHandler(this.EmailText_Leave);
            // 
            // textNumeUpdate
            // 
            this.textNumeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textNumeUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNumeUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textNumeUpdate.Location = new System.Drawing.Point(35, 50);
            this.textNumeUpdate.Name = "textNumeUpdate";
            this.textNumeUpdate.Size = new System.Drawing.Size(100, 20);
            this.textNumeUpdate.TabIndex = 81;
            this.textNumeUpdate.Text = "Nume";
            this.textNumeUpdate.Enter += new System.EventHandler(this.NumeText_Enter);
            this.textNumeUpdate.Leave += new System.EventHandler(this.NumeText_Leave);
            // 
            // textPrenumeUpdate
            // 
            this.textPrenumeUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPrenumeUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPrenumeUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPrenumeUpdate.Location = new System.Drawing.Point(35, 76);
            this.textPrenumeUpdate.Name = "textPrenumeUpdate";
            this.textPrenumeUpdate.Size = new System.Drawing.Size(100, 20);
            this.textPrenumeUpdate.TabIndex = 82;
            this.textPrenumeUpdate.Text = "Prenume";
            this.textPrenumeUpdate.Enter += new System.EventHandler(this.PrenumeText_Enter);
            this.textPrenumeUpdate.Leave += new System.EventHandler(this.PrenumeText_Leave);
            // 
            // textCNPUpdate
            // 
            this.textCNPUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textCNPUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textCNPUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textCNPUpdate.Location = new System.Drawing.Point(35, 102);
            this.textCNPUpdate.Name = "textCNPUpdate";
            this.textCNPUpdate.Size = new System.Drawing.Size(100, 20);
            this.textCNPUpdate.TabIndex = 83;
            this.textCNPUpdate.Text = "CNP";
            this.textCNPUpdate.Enter += new System.EventHandler(this.CNPText_Enter);
            this.textCNPUpdate.Leave += new System.EventHandler(this.CNPText_Leave);
            // 
            // textSoldUpdate
            // 
            this.textSoldUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textSoldUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSoldUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textSoldUpdate.Location = new System.Drawing.Point(182, 76);
            this.textSoldUpdate.Name = "textSoldUpdate";
            this.textSoldUpdate.Size = new System.Drawing.Size(100, 20);
            this.textSoldUpdate.TabIndex = 84;
            this.textSoldUpdate.Text = "Sold [LEI]";
            this.textSoldUpdate.Enter += new System.EventHandler(this.SoldText_Enter);
            this.textSoldUpdate.Leave += new System.EventHandler(this.SoldText_Leave);
            // 
            // textPerioadaDepUpdate
            // 
            this.textPerioadaDepUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.textPerioadaDepUpdate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPerioadaDepUpdate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textPerioadaDepUpdate.Location = new System.Drawing.Point(182, 50);
            this.textPerioadaDepUpdate.Name = "textPerioadaDepUpdate";
            this.textPerioadaDepUpdate.Size = new System.Drawing.Size(100, 20);
            this.textPerioadaDepUpdate.TabIndex = 85;
            this.textPerioadaDepUpdate.Text = "Perioada [LUNI]";
            this.textPerioadaDepUpdate.Enter += new System.EventHandler(this.PerioadaText_Enter);
            this.textPerioadaDepUpdate.Leave += new System.EventHandler(this.PerioadaText_Leave);
            // 
            // UpdateFormDataBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 350);
            this.Controls.Add(this.panelUpdate);
            this.Name = "UpdateFormDataBase";
            this.Text = "UpdateFormDataBase";
            this.Load += new System.EventHandler(this.UpdateFormDataBase_Load);
            this.panelUpdate.ResumeLayout(false);
            this.panelUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelUpdate;
        private System.Windows.Forms.Button butonUpdateClient;
        public System.Windows.Forms.TextBox textTelefonUpdate;
        public System.Windows.Forms.TextBox textNumeUpdate;
        public System.Windows.Forms.TextBox textPrenumeUpdate;
        public System.Windows.Forms.TextBox textCNPUpdate;
        public System.Windows.Forms.TextBox textSoldUpdate;
        public System.Windows.Forms.TextBox textPerioadaDepUpdate;
        public System.Windows.Forms.TextBox textEmailUpdate;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.DateTimePicker datePickerDepunereUpdate;
        public System.Windows.Forms.ComboBox cmbCardUpdate;
        public System.Windows.Forms.ComboBox cmbJudetUpdate;
        public System.Windows.Forms.TextBox textDobandaUpdate;
        private System.Windows.Forms.Label lbIdCont;
        private System.Windows.Forms.Label lbIdClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerDataNasterii;
    }
}