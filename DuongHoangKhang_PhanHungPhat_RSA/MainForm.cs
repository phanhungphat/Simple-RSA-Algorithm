using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace DuongHoangKhang_PhanHungPhat_RSA
{
    public partial class MainForm : Form
    {
        HeMatRSA_512 myRsa_512;
        HeMatRSA_1024 myRsa_1024;
        HeMatRSA_2048 myRsa_2048;
        public MainForm()
        {
            InitializeComponent();
            myRsa_512 = new HeMatRSA_512();
            myRsa_1024 = new HeMatRSA_1024();
            myRsa_2048 = new HeMatRSA_2048();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String input = txtplantext.Text;
            int i = cbb.SelectedIndex;
            switch (i)
            {
                case 0:
                    txtcyphertext.Text = myRsa_512.Mahoa(input);
                    break;
                case 1:
                    txtcyphertext.Text = myRsa_1024.Mahoa(input);
                    break;
                case 2:
                    txtcyphertext.Text = myRsa_2048.Mahoa(input);
                    break;
            }
        }

        private void but_Decryption_Click(object sender, EventArgs e)
        {
            String output = txtcyphertext.Text;
            int i = cbb.SelectedIndex;
            switch (i)
            {
                case 0:
                    txtKetqua.Text = myRsa_512.GiaiMa(output);
                    break;
                case 1:
                    txtKetqua.Text = myRsa_1024.GiaiMa(output);
                    break;
                case 2:
                    txtKetqua.Text = myRsa_2048.GiaiMa(output);
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcyphertext.Text = string.Empty;
            txtKetqua.Text = string.Empty;
            txtplantext.Text = string.Empty;
            txtThongTin.Text = string.Empty;
        }

        private void butThongTin_Click(object sender, EventArgs e)
        {

            int i = cbb.SelectedIndex;
            switch (i)
            {
                case 0:
                    txtThongTin.Text = myRsa_512.GetPrivateKey();
                    break;
                case 1:
                    txtThongTin.Text = myRsa_1024.GetPrivateKey();
                    break;
                case 2:
                    txtThongTin.Text = myRsa_2048.GetPrivateKey();
                    break;
            }
        }
    }
}
