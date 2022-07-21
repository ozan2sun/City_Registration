using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string nameSurname;
        string job;
        string city;
        string district;
        int numberofRecords;
        
        private void Form1_Load(object sender, EventArgs e)
        {                   
            cmbSehir.Items.Add("Istanbul");
            cmbSehir.Items.Add("Ankara");
            cmbSehir.Items.Add("Izmir");
            RecordsOfNumbers();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            nameSurname = txtAdSoyad.Text;
            job = txtMeslek.Text;
            city = cmbSehir.Text;
            district = cmbIlce.Text;
            string[] info = {nameSurname,job,city,district};
            

            if (nameSurname !="" && job!= "" && city !="" && district !="")
            {
                ListViewItem lvi = new ListViewItem(info);
                listView1.Items.Add(lvi);
            }
            else
            {
                MessageBox.Show("Missing information available", "WARNING!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            RecordsOfNumbers();
        }

        private void cmbSehir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSehir.Text =="Istanbul")
            {
                cmbIlce.Visible = true;
                cmbIlce.Items.Clear();
                cmbIlce.Items.Add("Beyoğlu");
                cmbIlce.Items.Add("Şişli");
                cmbIlce.Items.Add("Kadıköy");
                cmbIlce.Items.Add("Beşiktaş");
                cmbIlce.Items.Add("Fatih");
                cmbIlce.Items.Add("Kağıthane");
                cmbIlce.Items.Add("Adalar");
                cmbIlce.Items.Add("Bahçelievler");
                cmbIlce.Items.Add("Esenler");
            }
            else if (cmbSehir.Text == "Ankara")
            {
                cmbIlce.Visible = true;
                cmbIlce.Items.Clear();
                cmbIlce.Items.Add("Çankaya");
                cmbIlce.Items.Add("Etimesgut");
                cmbIlce.Items.Add("Beypazarı");
                cmbIlce.Items.Add("Sincan");
                cmbIlce.Items.Add("Keçiören");
                cmbIlce.Items.Add("Yenimahalle");
                cmbIlce.Items.Add("Haymana");
                cmbIlce.Items.Add("Akyurt");
                cmbIlce.Items.Add("Altındağ");
            }
            else
            {
                cmbIlce.Visible = true;
                cmbIlce.Items.Clear();
                cmbIlce.Items.Add("Aliağa");
                cmbIlce.Items.Add("Balçova");
                cmbIlce.Items.Add("Karşıyaka");
                cmbIlce.Items.Add("Bayraklı");
                cmbIlce.Items.Add("Bergama");
                cmbIlce.Items.Add("Bornova");
                cmbIlce.Items.Add("Çeşme");
                cmbIlce.Items.Add("Selçuk");
                cmbIlce.Items.Add("Konak");
            }
        }

        private void btnKaldir_Click(object sender, EventArgs e)
        {
            
            int choosenNumber = listView1.SelectedItems.Count;
            foreach (ListViewItem registrationInfo in listView1.SelectedItems)
            {
                registrationInfo.Remove();
            }
            MessageBox.Show(choosenNumber + " Records deleted");
            int newRecordsNumber = numberofRecords - choosenNumber;
            numberofRecords = newRecordsNumber;
            lblKayitSayisi.Text = numberofRecords.ToString();
        }
        private void RecordsOfNumbers()
        {
            numberofRecords = listView1.Items.Count;
            lblKayitSayisi.Text = Convert.ToString(numberofRecords);         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Clear();
            RecordsOfNumbers();
        }     
    }
}
