using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranspoaitionCipher
{
    public partial class Шифр : Form
    {
        Transposition t;
        public Шифр()
        {
            InitializeComponent();

            t = new Transposition();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            t.SetKey(KeyTextBox.Text);

            if (EncryptRadioButton.Checked)
                outputTextBox.Text = t.Encrypt(InputTextBox.Text);
            else
                outputTextBox.Text = t.Decrypt(InputTextBox.Text);
        }
    }
}
