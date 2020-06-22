using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра
{
    public partial class Menu : Form
    {
        bool enabledSound = true;
        public Menu()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulties difficulties = new Difficulties();
            difficulties.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (enabledSound)
            {
                button1.Image = Properties.Resources.volumeOff;
                enabledSound = false;
            }
            else
            {
                button1.Image = Properties.Resources.volumeOn;
                enabledSound = true;
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            RulesForm rulesForm = new RulesForm();
            rulesForm.ShowDialog();
            this.Close();
        }
    }
}
