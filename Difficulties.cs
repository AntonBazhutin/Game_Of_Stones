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
    public partial class Difficulties : Form
    {
        public Difficulties()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (radioBtnEasy.Checked)
            {
                this.Hide();
                EasyLevel easyLevel = new EasyLevel();
                easyLevel.ShowDialog();
                this.Close();
            }
            else
             if (radioBtnMedium.Checked)
            {
                this.Hide();
                MediumLevel mediumLevel = new MediumLevel();
                mediumLevel.ShowDialog();
                this.Close();
            }
            else
             if (radioBtnHard.Checked)
            {
                this.Hide();
                HardLevel hardLevel = new HardLevel();
                hardLevel.ShowDialog();
                this.Close();
            }
        }
    }
}
