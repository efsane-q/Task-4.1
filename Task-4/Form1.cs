using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbKurs.Items.Add("1-ci kurs");
            cmbKurs.Items.Add("2-ci kurs");
            cmbKurs.Items.Add("3-cü kurs");
            cmbKurs.Items.Add("4-cü kurs");

            cmbKurs.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnElaveEt_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            int yas = (int)nudYas.Value;
            string kurs = cmbKurs.Text;
            string cins = rbQadin.Checked ? "Qadın" : "Kişi";

            if (ad == "")
            {
                MessageBox.Show("Ad boş ola bilməz!");
                return;
            }

            string telebe = $"{ad} - {yas} yaş - {kurs} - {cins}";

            lstTelebeler.Items.Add(telebe);

            txtAd.Clear();
            nudYas.Value = 16;
            cmbKurs.SelectedIndex = 0;
            rbQadin.Checked = false;
            rbKisi.Checked = false;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstTelebeler.SelectedIndex == -1)
            {
                MessageBox.Show("Əvvəlcə tələbə seçin!");
                return;
            }

            DialogResult cavab = MessageBox.Show(
                "Seçilmiş tələbəni silmək istəyirsiniz?",
                "Təsdiq",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (cavab == DialogResult.Yes)
            {
                lstTelebeler.Items.RemoveAt(lstTelebeler.SelectedIndex);
                lblMelumat.Text = "";
            }
        }

        private void lstTelebeler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTelebeler.SelectedIndex != -1)
            {
                lblMelumat.Text = lstTelebeler.SelectedItem.ToString();
            }
        }
    }
}
