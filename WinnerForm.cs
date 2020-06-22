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
    public partial class WinnerForm : Form
    {
        private string form;
        private int minutes;
        private int seconds;
        private string difficulty;

        public string Form
        {
            get { return form; }
            set { form = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public string Difficulty
        {
            get { return difficulty; }
            set
            {
                if (value == "easy")
                    difficulty = "Лёгкий уровень был пройден за";
                else
                if (value == "medium")
                    difficulty = "Средний уровень был пройден за";
                else
                if (value == "hard")
                    difficulty = "Тяжелый уровень был пройден за";
            }
        }


        public WinnerForm(string form, int minutes, int seconds, string difficulty)
        {
            InitializeComponent();

            Form = form;
            Minutes = minutes;
            Seconds = seconds;
            Difficulty = difficulty;

        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (form == "easy")
            {
                EasyLevel easyLevel = new EasyLevel();
                easyLevel.ShowDialog();
            }
            else
            if (form == "medium")
            {
                MediumLevel mediumLevel = new MediumLevel();
                mediumLevel.ShowDialog();
            }
            else
            if (form == "hard")
            {
                HardLevel hardLevel = new HardLevel();
                hardLevel.ShowDialog();
            }
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
            this.Close();
        }

        private void WinnerForm_Load(object sender, EventArgs e)
        {
            labelMinutes.Text = minutes.ToString();
            labelSeconds.Text = seconds.ToString();
            labelDifficulty.Text = difficulty.ToString();
        }
    }
}
