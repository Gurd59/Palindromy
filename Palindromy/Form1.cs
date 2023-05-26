using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindromy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public Boolean JePalindrom(String p)
        {
            p = p.ToLower();
            bool result = true;
            for (int i = 0; i < Convert.ToInt32(p.Length / 2.0); i++)
            {
                if (!p[i].Equals(p[p.Length - i - 1])) result = false;

            }
            return result;
        }

        public String obrat(String p)
        {
            char[] charArray = p.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private void btnPalindrom_Click(object sender, EventArgs e)
        {
            String vstup = txtVstup.Text.Replace(" ", "").ToLower();
            String doplneni = "";
            int delka = 0;

            while (!JePalindrom(vstup+doplneni))
            {
                delka++;
                doplneni = obrat(vstup.Substring(0, delka));
            }

            txtVystup.Text = vstup + doplneni;
        }
    }
}
