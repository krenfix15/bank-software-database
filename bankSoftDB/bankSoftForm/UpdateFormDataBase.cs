using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibrarieClient;
using NivelAccesDate;
using System.Collections.Generic;
using System.IO;

namespace bankSoftForm
{
    public partial class UpdateFormDataBase : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        const int CIFRE_CNP = 13;
        const int CIFRE_TELEFON = 9;
        const int MAX_PERIOADA = 1200;
        const int MIN_PERIOADA = 3;
        const int NO_ITEMS_CMB = -1;

        public Client client;
        public Cont cont;

        public bankDataBase bankDB = new bankDataBase();

        //initializare obiecte utilizate pentru salvarea datelor in baza de date
        IStocareClienti stocareClienti = (IStocareClienti)new StocareFactory().GetTipStocare(typeof(Client));
        IStocareConturi stocareConturi = (IStocareConturi)new StocareFactory().GetTipStocare(typeof(Cont));
        IStocareLocatii stocareLocatii = (IStocareLocatii)new StocareFactory().GetTipStocare(typeof(Locatie));
        IStocareCarduri stocareCarduri = (IStocareCarduri)new StocareFactory().GetTipStocare(typeof(Card));

        public UpdateFormDataBase()
        {
            InitializeComponent();
        }

        private void UpdateFormDataBase_Load(object sender, EventArgs e)
        {
            IncarcaCarduri();
            IncarcaLocatii();
        }

        private void IncarcaLocatii()
        {
            try
            {
                //se elimina itemii deja adaugati
                cmbJudetUpdate.Items.Clear();

                var locatii = stocareLocatii.GetLocatii();
                if (locatii != null && locatii.Any())
                {
                    foreach (var locatie in locatii)
                    {
                        cmbJudetUpdate.Items.Add(new ComboItem(locatie.Judet, (Int32)locatie.ID_LOCATIE));
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
                cmbCardUpdate.Items.Clear();

                var carduri = stocareCarduri.GetCarduri();
                if (carduri != null && carduri.Any())
                {
                    foreach (var card in carduri)
                    {
                        cmbCardUpdate.Items.Add(new ComboItem(card.Tip, (Int32)card.ID_CARD));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void NumeText_Enter(object sender, EventArgs e)
        {
            if (textNumeUpdate.Text == "Nume")
            {
                textNumeUpdate.Text = "";
                textNumeUpdate.ForeColor = Color.White;
            }
        }

        private void NumeText_Leave(object sender, EventArgs e)
        {
            if (textNumeUpdate.Text == "")
            {
                textNumeUpdate.Text = "Nume";
                textNumeUpdate.ForeColor = Color.Gray;
            }
        }

        private void PrenumeText_Enter(object sender, EventArgs e)
        {
            if (textPrenumeUpdate.Text == "Prenume")
            {
                textPrenumeUpdate.Text = "";
                textPrenumeUpdate.ForeColor = Color.White;
            }
        }

        private void PrenumeText_Leave(object sender, EventArgs e)
        {
            if (textPrenumeUpdate.Text == "")
            {
                textPrenumeUpdate.Text = "Prenume";
                textPrenumeUpdate.ForeColor = Color.Gray;
            }
        }

        private void CNPText_Enter(object sender, EventArgs e)
        {
            if (textCNPUpdate.Text == "CNP")
            {
                textCNPUpdate.Text = "";
                textCNPUpdate.ForeColor = Color.White;
            }
        }

        private void CNPText_Leave(object sender, EventArgs e)
        {
            if (textCNPUpdate.Text == "")
            {
                textCNPUpdate.Text = "CNP";
                textCNPUpdate.ForeColor = Color.Gray;
            }
        }

        private void SoldText_Enter(object sender, EventArgs e)
        {
            if (textSoldUpdate.Text == "Sold [LEI]")
            {
                textSoldUpdate.Text = "";

                textSoldUpdate.ForeColor = Color.White;
            }
        }

        private void SoldText_Leave(object sender, EventArgs e)
        {
            if (textSoldUpdate.Text == "")
            {
                textSoldUpdate.Text = "Sold [LEI]";
                textSoldUpdate.ForeColor = Color.Gray;
            }
        }

        private void PerioadaText_Enter(object sender, EventArgs e)
        {
            if (textPerioadaDepUpdate.Text == "Perioada [LUNI]")
            {
                textPerioadaDepUpdate.Text = "";
                textPerioadaDepUpdate.ForeColor = Color.White;
            }
        }

        private void PerioadaText_Leave(object sender, EventArgs e)
        {
            if (textPerioadaDepUpdate.Text == "")
            {
                textPerioadaDepUpdate.Text = "Perioada [LUNI]";
                textPerioadaDepUpdate.ForeColor = Color.Gray;
            }
        }

        private void TelefonText_Enter(object sender, EventArgs e)
        {
            if (textTelefonUpdate.Text == "Telefon [+40]")
            {
                textTelefonUpdate.Text = "";
                textTelefonUpdate.ForeColor = Color.White;
            }
        }

        private void TelefonText_Leave(object sender, EventArgs e)
        {
            if (textTelefonUpdate.Text == "")
            {
                textTelefonUpdate.Text = "Telefon [+40]";
                textTelefonUpdate.ForeColor = Color.Gray;
            }
        }

        private void EmailText_Enter(object sender, EventArgs e)
        {
            if (textEmailUpdate.Text == "Email")
            {
                textEmailUpdate.Text = "";
                textEmailUpdate.ForeColor = Color.White;
            }
        }

        private void EmailText_Leave(object sender, EventArgs e)
        {
            if (textEmailUpdate.Text == "")
            {
                textEmailUpdate.Text = "Email";
                textEmailUpdate.ForeColor = Color.Gray;
            }
        }

        private void DobandaText_Enter(object sender, EventArgs e)
        {
            if (textDobandaUpdate.Text == "Dobândă")
            {
                textDobandaUpdate.Text = "";
                textDobandaUpdate.ForeColor = Color.White;
            }
        }

        private void DobandaText_Leave(object sender, EventArgs e)
        {
            if (textDobandaUpdate.Text == "")
            {
                textDobandaUpdate.Text = "Dobândă";
                textDobandaUpdate.ForeColor = Color.Gray;
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

            if (cmbCardUpdate.SelectedIndex == NO_ITEMS_CMB)
            {
                rezultatValidare |= CodEroare.CARD_NESELECTAT;
            }

            if (cmbJudetUpdate.SelectedIndex == NO_ITEMS_CMB)
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
                textNumeUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PRENUME_INCORECT) == CodEroare.PRENUME_INCORECT)
            {
                textPrenumeUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CNP_INCORECT) == CodEroare.CNP_INCORECT)
            {
                textCNPUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.EMAIL_INCORECT) == CodEroare.EMAIL_INCORECT)
            {
                textEmailUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.PERIOADA_INCORECT) == CodEroare.PERIOADA_INCORECT)
            {
                textPerioadaDepUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.SOLD_INCORECT) == CodEroare.SOLD_INCORECT)
            {
                textSoldUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.TELEFON_INCORECT) == CodEroare.TELEFON_INCORECT)
            {
                textTelefonUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.JUDET_NESELECTAT) == CodEroare.JUDET_NESELECTAT)
            {
                cmbJudetUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.CARD_NESELECTAT) == CodEroare.CARD_NESELECTAT)
            {
                cmbCardUpdate.ForeColor = Color.Red;
            }
            if ((codValidare & CodEroare.DOBANDA_INCORECT) == CodEroare.DOBANDA_INCORECT)
            {
                textDobandaUpdate.ForeColor = Color.Red;
            }
        }

        private void ResetareControale()
        {
            textCNPUpdate.ForeColor = Color.Gray;
            textNumeUpdate.ForeColor = Color.Gray;
            textPrenumeUpdate.ForeColor = Color.Gray;
            textTelefonUpdate.ForeColor = Color.Gray;
            textEmailUpdate.ForeColor = Color.Gray;
            textSoldUpdate.ForeColor = Color.Gray;
            textPerioadaDepUpdate.ForeColor = Color.Gray;
            textCNPUpdate.Text = "CNP";
            textNumeUpdate.Text = "Nume";
            textPrenumeUpdate.Text = "Prenume";
            textTelefonUpdate.Text = "Telefon [+40]";
            textEmailUpdate.Text = "Email";
            textSoldUpdate.Text = "Sold [LEI]";
            textPerioadaDepUpdate.Text = "Perioada [LUNI]";
            textDobandaUpdate.Text = "Dobândă";
            cmbCardUpdate.ForeColor = Color.Gray;
            cmbCardUpdate.Text = "Card";
            cmbJudetUpdate.ForeColor = Color.Gray;
            cmbJudetUpdate.Text = "Județ";
        }

        private void butonUpdateClient_MouseClick(object sender, MouseEventArgs e)
        {
            CodEroare codValidare = Validare(textNumeUpdate.Text, textPrenumeUpdate.Text, textCNPUpdate.Text, textSoldUpdate.Text,
                textPerioadaDepUpdate.Text, textTelefonUpdate.Text, textEmailUpdate.Text, textDobandaUpdate.Text);

            if (codValidare != CodEroare.CORECT)
            {
                MarcheazaControaleCuDateIncorecte(codValidare);
            }
            else
            {
                try
                {
                    var client = new Client(
                        textNumeUpdate.Text,
                        textPrenumeUpdate.Text,
                        textCNPUpdate.Text,
                        textTelefonUpdate.Text,
                        textEmailUpdate.Text,
                        Convert.ToDateTime(datePickerDataNasterii.Text),
                        cmbJudetUpdate.Text,
                        Int32.Parse(lbIdClient.Text)
                        );

                    var cont = new Cont(
                        Convert.ToInt32(textPerioadaDepUpdate.Text),
                        textCNPUpdate.Text,
                        Convert.ToInt32(textSoldUpdate.Text),
                        Convert.ToDateTime(datePickerDepunereUpdate.Text),
                        Convert.ToDecimal(textDobandaUpdate.Text),
                        cmbCardUpdate.Text,
                        Int32.Parse(lbIdCont.Text)
                        );

                    var rezultatClient = stocareClienti.UpdateClient(client);
                    var rezultatCont = stocareConturi.UpdateCont(cont);

                    if ((rezultatClient == SUCCES) && (rezultatCont == SUCCES))
                    {
                        MessageBox.Show("Clientul a fost actualizat impreuna cu depozitul");
                        ResetareControale();
                        bankDB.AfiseazaClienti();
                    }
                    else if((rezultatClient != SUCCES))
                    {
                        MessageBox.Show("Eroare la actualizare client");
                    }
                    else if((rezultatCont != SUCCES))
                    {
                        MessageBox.Show("Eroare la actualizare cont");
                    }
                    else
                    {
                        MessageBox.Show("Eroare la actualizare client impreuna cu cont");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exceptie" + ex.Message);
                }
            }
        }

        public void SetTextForLabelIdClient(string myText)
        {
            this.lbIdClient.Text = myText;
        }

        public void SetTextForLabelIdCont(string myText)
        {
            this.lbIdCont.Text = myText;
        }

        public void SetDataNasterii(DateTime dataNastere)
        {
            this.datePickerDataNasterii.Value = dataNastere;
        }

        public void SetDataDepunerii(DateTime dataDepunere)
        {
            this.datePickerDepunereUpdate.Value = dataDepunere;
        }

        
    }
}
