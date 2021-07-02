using System;
using System.Linq;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieClient;
using System.Drawing;
using System.Collections.Generic;

namespace bankSoftForm
{
    public partial class bankDataBase : Form
    {
        const int PRIMA_COLOANA = 0;
        const bool SUCCES = true;
        const int CIFRE_CNP = 13;
        const int CIFRE_TELEFON = 9;
        const int MAX_PERIOADA = 1200;
        const int MIN_PERIOADA = 3;
        const int NO_ITEMS_CMB = -1;
        const int COLOANA_CNP = 3;

        //initializare obiecte utilizate pentru salvarea datelor in baza de date
        IStocareClienti stocareClienti = (IStocareClienti)new StocareFactory().GetTipStocare(typeof(Client));
        IStocareConturi stocareConturi = (IStocareConturi)new StocareFactory().GetTipStocare(typeof(Cont));
        IStocareLocatii stocareLocatii = (IStocareLocatii)new StocareFactory().GetTipStocare(typeof(Locatie));
        IStocareCarduri stocareCarduri = (IStocareCarduri)new StocareFactory().GetTipStocare(typeof(Card));


        public bankDataBase()
        {
            InitializeComponent();

            if ((stocareClienti == null) || (stocareConturi == null) || (stocareLocatii == null) || (stocareCarduri == null))
            {
                
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void bankDataBase_Load(object sender, EventArgs e)
        {
            dataGridClienti.BorderStyle = BorderStyle.None;
            dataGridClienti.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridClienti.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridClienti.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 60, 0);
            dataGridClienti.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridClienti.BackgroundColor = Color.White;
            dataGridClienti.EnableHeadersVisualStyles = false;
            dataGridClienti.DefaultCellStyle.ForeColor = Color.Black;
            dataGridClienti.DefaultCellStyle.Font = new Font("Segoe UI", 8);
            dataGridClienti.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridClienti.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(40, 40, 0);
            dataGridClienti.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            AfiseazaClienti();
            IncarcaCarduri();
            IncarcaLocatii();
        }

        private void bankDataBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void NumeText_Enter(object sender, EventArgs e)
        {
            if (textNume.Text == "Nume")
            {
                textNume.Text = "";
                textNume.ForeColor = Color.White;
            }
        }

        private void NumeText_Leave(object sender, EventArgs e)
        {
            if (textNume.Text == "")
            {
                textNume.Text = "Nume";
                textNume.ForeColor = Color.Gray;
            }
        }

        private void PrenumeText_Enter(object sender, EventArgs e)
        {
            if (textPrenume.Text == "Prenume")
            {
                textPrenume.Text = "";
                textPrenume.ForeColor = Color.White;
            }
        }

        private void PrenumeText_Leave(object sender, EventArgs e)
        {
            if (textPrenume.Text == "")
            {
                textPrenume.Text = "Prenume";
                textPrenume.ForeColor = Color.Gray;
            }
        }

        private void CNPText_Enter(object sender, EventArgs e)
        {
            if (textCNP.Text == "CNP")
            {
                textCNP.Text = "";
                textCNP.ForeColor = Color.White;
            }
        }

        private void CNPText_Leave(object sender, EventArgs e)
        {
            if (textCNP.Text == "")
            {
                textCNP.Text = "CNP";
                textCNP.ForeColor = Color.Gray;
            }
        }

        private void SoldText_Enter(object sender, EventArgs e)
        {
            if (textSold.Text == "Sold [LEI]")
            {
                textSold.Text = "";

                textSold.ForeColor = Color.White;
            }
        }

        private void SoldText_Leave(object sender, EventArgs e)
        {
            if (textSold.Text == "")
            {
                textSold.Text = "Sold [LEI]";
                textSold.ForeColor = Color.Gray;
            }
        }

        private void PerioadaText_Enter(object sender, EventArgs e)
        {
            if (textPerioadaDep.Text == "Perioada [LUNI]")
            {
                textPerioadaDep.Text = "";
                textPerioadaDep.ForeColor = Color.White;
            }
        }

        private void PerioadaText_Leave(object sender, EventArgs e)
        {
            if (textPerioadaDep.Text == "")
            {
                textPerioadaDep.Text = "Perioada [LUNI]";
                textPerioadaDep.ForeColor = Color.Gray;
            }
        }

        private void TelefonText_Enter(object sender, EventArgs e)
        {
            if (textTelefon.Text == "Telefon [+40]")
            {
                textTelefon.Text = "";
                textTelefon.ForeColor = Color.White;
            }
        }

        private void TelefonText_Leave(object sender, EventArgs e)
        {
            if (textTelefon.Text == "")
            {
                textTelefon.Text = "Telefon [+40]";
                textTelefon.ForeColor = Color.Gray;
            }
        }

        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (textEmail.Text == "Email")
            {
                textEmail.Text = "";
                textEmail.ForeColor = Color.White;
            }
        }

        private void EmailText_Leave(object sender, EventArgs e)
        {
            if (textEmail.Text == "")
            {
                textEmail.Text = "Email";
                textEmail.ForeColor = Color.Gray;
            }
        }

        private void DobandaText_Enter(object sender, EventArgs e)
        {
            if (textDobanda.Text == "Dobândă")
            {
                textDobanda.Text = "";
                textDobanda.ForeColor = Color.White;
            }
        }

        private void DobandaText_Leave(object sender, EventArgs e)
        {
            if (textDobanda.Text == "")
            {
                textDobanda.Text = "Dobândă";
                textDobanda.ForeColor = Color.Gray;
            }
        }

        private void textCauta_Enter(object sender, EventArgs e)
        {
            if (textCauta.Text == "Caută [CNP]")
            {
                textCauta.Text = "";
                textCauta.ForeColor = Color.White;
            }
        }

        private void textCauta_Leave(object sender, EventArgs e)
        {
            if (textCauta.Text == "")
            {
                textCauta.Text = "Caută [CNP]";
                textCauta.ForeColor = Color.Gray;
            }
        }

        private CodEroare Validare(string nume, string prenume, string CNP, string sold, string perioada, string telefon, string email, string dobanda)
        {
            CodEroare rezultatValidare = CodEroare.CORECT;

            bool numeContainsInt = nume.Any(char.IsDigit);
            bool prenumeContainsInt = prenume.Any(char.IsDigit);
            bool cnpContainsChar = CNP.Any(char.IsLetter);          

            if (nume == "Nume" || numeContainsInt)
            {
                rezultatValidare |= CodEroare.NUME_INCORECT;
            }

            if (prenume == "Prenume" || prenumeContainsInt)
            {
                rezultatValidare |= CodEroare.PRENUME_INCORECT;
            }

            var isCNPNumeric = int.TryParse(CNP, out _);
            if (CNP == "CNP" || CNP.Length != CIFRE_CNP || cnpContainsChar)
            {
                rezultatValidare |= CodEroare.CNP_INCORECT;
            }

            var isSoldNumeric = int.TryParse(sold, out _);
            if (sold == "Sold" || !isSoldNumeric)
            {
                rezultatValidare |= CodEroare.SOLD_INCORECT;
            }

            var isPerioadaNumeric = int.TryParse(perioada, out _);
            if (perioada == "Perioada" || !isPerioadaNumeric || Int32.Parse(perioada) > MAX_PERIOADA || Int32.Parse(perioada) < MIN_PERIOADA)
            {
                rezultatValidare |= CodEroare.PERIOADA_INCORECT;
            }

            var isTelefonNumeric = int.TryParse(telefon, out _);
            if (telefon == "Telefon [+40]" || telefon.Length != CIFRE_TELEFON || !isTelefonNumeric)
            {
                rezultatValidare |= CodEroare.TELEFON_INCORECT;
            }

            bool IsValidEmail(string _email)
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(_email);
                    return addr.Address == email;
                }
                catch
                {
                    return false;
                }
            }

            if (email == "Email" || !IsValidEmail(email))
            {
                rezultatValidare |= CodEroare.EMAIL_INCORECT;
            }

            if (cmbCard.SelectedIndex == NO_ITEMS_CMB)
            {
                rezultatValidare |= CodEroare.CARD_NESELECTAT;
            }

            if (cmbJudet.SelectedIndex == NO_ITEMS_CMB)
            {
                rezultatValidare |= CodEroare.JUDET_NESELECTAT;
            }

            var isDobandaNumeric = int.TryParse(dobanda, out _);
            if (dobanda == "Dobândă" || !isDobandaNumeric)
            {
                rezultatValidare |= CodEroare.DOBANDA_INCORECT;
            }

            return rezultatValidare;
        }

        private void MarcheazaControaleCuDateIncorecte(CodEroare codValidare)
        {
            if ((codValidare & CodEroare.NUME_INCORECT) == CodEroare.NUME_INCORECT)
            {
                textNume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRENUME_INCORECT) == CodEroare.PRENUME_INCORECT)
            {
                textPrenume.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CNP_INCORECT) == CodEroare.CNP_INCORECT)
            {
                textCNP.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.EMAIL_INCORECT) == CodEroare.EMAIL_INCORECT)
            {
                textEmail.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PERIOADA_INCORECT) == CodEroare.PERIOADA_INCORECT)
            {
                textPerioadaDep.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.SOLD_INCORECT) == CodEroare.SOLD_INCORECT)
            {
                textSold.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.TELEFON_INCORECT) == CodEroare.TELEFON_INCORECT)
            {
                textTelefon.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.JUDET_NESELECTAT) == CodEroare.JUDET_NESELECTAT)
            {
                cmbJudet.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CARD_NESELECTAT) == CodEroare.CARD_NESELECTAT)
            {
                cmbCard.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.DOBANDA_INCORECT) == CodEroare.DOBANDA_INCORECT)
            {
                textDobanda.ForeColor = Color.Red;
            }
        }

        private void ResetareControale()
        {
            textCNP.ForeColor = Color.Gray;
            textNume.ForeColor = Color.Gray;
            textPrenume.ForeColor = Color.Gray;
            textTelefon.ForeColor = Color.Gray;
            textEmail.ForeColor = Color.Gray;
            textSold.ForeColor = Color.Gray;
            textPerioadaDep.ForeColor = Color.Gray;
            textCauta.ForeColor = Color.Gray;
            textCNP.Text = "CNP";
            textNume.Text = "Nume";
            textPrenume.Text = "Prenume";
            textTelefon.Text = "Telefon [+40]";
            textEmail.Text = "Email";
            textSold.Text = "Sold [LEI]";
            textPerioadaDep.Text = "Perioada [LUNI]";
            textCauta.Text = "Cauta [CNP]";
            textDobanda.Text = "Dobândă";
            cmbCard.ForeColor = Color.Gray;
            cmbCard.Text = "Card";
            cmbJudet.ForeColor = Color.Gray;
            cmbJudet.Text = "Județ";
        }

        public void ResetareEtichete()
        {
            if (textCauta.Text != "Caută [CNP]")
                textCauta.ForeColor = Color.White;
            else
                textCauta.ForeColor = Color.Gray;
        }

        private void butonAddClient_Click(object sender, EventArgs e)
        {
            ResetareEtichete();
            CodEroare codValidare = Validare(textNume.Text, textPrenume.Text, textCNP.Text, textSold.Text, textPerioadaDep.Text, textTelefon.Text, textEmail.Text, textDobanda.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                try
                {
                    var client = new Client(
                        textNume.Text,
                        textPrenume.Text,
                        textCNP.Text,
                        textTelefon.Text,
                        textEmail.Text,
                        Convert.ToDateTime(datePickerData.Text),
                        cmbJudet.Text,
                        ((ComboItem)cmbJudet.SelectedItem).Value
                        );

                    var cont = new Cont(
                        Convert.ToInt32(textPerioadaDep.Text),
                        textCNP.Text,
                        Convert.ToInt32(textSold.Text),
                        Convert.ToDateTime(datePickerDepunere.Text),
                        Convert.ToDecimal(textDobanda.Text),
                        cmbCard.Text,
                        ((ComboItem)cmbCard.SelectedItem).Value
                        );

                    var rezultatClient = stocareClienti.AddClient(client);
                    var rezultatCont = stocareConturi.AddCont(cont);

                    if ((rezultatClient == SUCCES) && (rezultatCont == SUCCES))
                    {
                        MessageBox.Show("Clientul a fost adaugat impreuna cu depozitul");
                        ResetareControale();
                        AfiseazaClienti();
                    }                 
                    else
                    {
                        MessageBox.Show("Eroare la adaugare client impreuna cu depozit");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exceptie" + ex.Message);
                }
            }           
        }

        /// <summary>
        /// afiseaza informatiile complete despre clienti
        /// </summary>
        public void AfiseazaClienti()
        {
            try
            {
                var clienti = stocareClienti.GetClienti();
                var conturi = stocareConturi.GetConturi();

                if ((clienti != null) && (clienti.Any()) && (conturi != null) && (conturi.Any()))
                {
                    dataGridClienti.DataSource = clienti.Select(c => new { c.ID_CLIENT, c.Nume, c.Prenume, c.CNP, c.Telefon, c.Email, c.DataNastere, c.Judet}).ToList();                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void butonCauta_MouseClick(object sender, MouseEventArgs e)
        {
            ResetareEtichete();

            textCauta.ForeColor = Color.Gray;

            List<Client> clienti = stocareClienti.GetClienti();

            string searchValue = textCauta.Text;

            dataGridClienti.ClearSelection();
            dataGridClienti.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            try
            {
                foreach (DataGridViewRow row in dataGridClienti.Rows)
                {
                    if (row.Cells[3].Value.ToString().Equals(searchValue))
                    {
                        row.Selected = true;
                        textCauta.ForeColor = Color.White;
                        dataGridClienti.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                    else
                        textCauta.ForeColor = Color.Red;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dataGridClienti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateFormDataBase uFormDB = new UpdateFormDataBase();

            int currentRowIndex = dataGridClienti.CurrentCell.RowIndex;

            string idClient = dataGridClienti[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            string cnpCont = dataGridClienti[COLOANA_CNP, currentRowIndex].Value.ToString();

            try
            {
                Client c = stocareClienti.GetClient(Int32.Parse(idClient));
                Cont cont = stocareConturi.GetCont(cnpCont);

                //incarcarea datelor in controalele de pe forma
                if ((c != null) && (cont != null))
                {
                    uFormDB.SetTextForLabelIdClient(c.ID_CLIENT.ToString());
                    uFormDB.textNumeUpdate.Text = c.Nume;
                    uFormDB.textPrenumeUpdate.Text = c.Prenume;
                    uFormDB.textCNPUpdate.Text = c.CNP;
                    uFormDB.textTelefonUpdate.Text = c.Telefon;
                    uFormDB.textEmailUpdate.Text = c.Email;
                    uFormDB.SetDataNasterii(c.DataNastere);
                    uFormDB.cmbJudetUpdate.SelectedItem = c.Judet;

                    uFormDB.SetTextForLabelIdCont(cont.ID_CONT.ToString());
                    uFormDB.textPerioadaDepUpdate.Text = cont.Perioada.ToString();
                    uFormDB.textSoldUpdate.Text = cont.Sold.ToString();
                    uFormDB.SetDataDepunerii(cont.DataDepunere);
                    uFormDB.textDobandaUpdate.Text = cont.Dobanda.ToString();
                    uFormDB.cmbCardUpdate.SelectedItem = cont.TipCard;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

            uFormDB.ShowDialog();
        }

        private void IncarcaLocatii()
        {
            try
            {
                //se elimina itemii deja adaugati
                cmbJudet.Items.Clear();

                var locatii = stocareLocatii.GetLocatii();
                if (locatii != null && locatii.Any())
                {
                    foreach (var locatie in locatii)
                    {
                        cmbJudet.Items.Add(new ComboItem(locatie.Judet, (Int32)locatie.ID_LOCATIE));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void IncarcaCarduri()
        {
            try
            {
                //se elimina itemii deja adaugati
                cmbCard.Items.Clear();

                var carduri = stocareCarduri.GetCarduri();
                if (carduri != null && carduri.Any())
                {
                    foreach (var card in carduri)
                    {
                        cmbCard.Items.Add(new ComboItem(card.Tip, (Int32)card.ID_CARD));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonLogo_MouseHover(object sender, EventArgs e) => btnLogoDB.ImageIndex = 1;

        private void buttonLogo_MouseLeave(object sender, EventArgs e) => btnLogoDB.ImageIndex = 0;

        private void închideFereastraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ascundeMeniulToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textNume.Enabled = false;
            textPrenume.Enabled = false;
            textCNP.Enabled = false;
            textPerioadaDep.Enabled = false;
            textSold.Enabled = false;
            textTelefon.Enabled = false;
            textEmail.Enabled = false;
            cmbJudet.Enabled = false;
            cmbCard.Enabled = false;
            textDobanda.Enabled = false;
            butonAddClient.Enabled = false;
        }

        private void afișeazăMeniuliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textNume.Enabled = true;
            textPrenume.Enabled = true;
            textCNP.Enabled = true;
            textPerioadaDep.Enabled = true;
            textSold.Enabled = true;
            textTelefon.Enabled = true;
            textEmail.Enabled = true;
            cmbJudet.Enabled = true;
            cmbCard.Enabled = true;
            textDobanda.Enabled = true;
            butonAddClient.Enabled = true;
        }

        private void reactualizeazăDateleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var conturi = stocareConturi.GetConturi();

            foreach (Cont c in conturi)
            {
                DateTime DATA_FINAL_PERIOADA = c.DataDepunere.AddMonths(c.Perioada);

                if (DATA_FINAL_PERIOADA < DateTime.Now)
                {
                    c.Sold = Convert.ToInt32(c.Sold + c.Sold * Convert.ToInt32(c.Dobanda) / 100);
                    c.Perioada = 0;
                    stocareConturi.UpdateCont(c);
                }
            }

            AfiseazaClienti();
        }

        private void ștergeÎnregistrareaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int currentRowIndex = dataGridClienti.CurrentCell.RowIndex;

            string cnpClient = dataGridClienti[COLOANA_CNP, currentRowIndex].Value.ToString();
            string cnpCont = dataGridClienti[COLOANA_CNP, currentRowIndex].Value.ToString();

            try
            {              
                stocareClienti.DeleteClient(cnpClient);
                stocareConturi.DeleteCont(cnpCont);
                MessageBox.Show("Clientul a fost sters impreuna cu depozitul");
                AfiseazaClienti();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }
    }
}
