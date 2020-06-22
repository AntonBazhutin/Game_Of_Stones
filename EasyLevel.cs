using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Игра
{
    public partial class EasyLevel : Form
    {
        public EasyLevel()
        {
            InitializeComponent();
        }
        string form = "easy";
        int Plus;
        int Times;
        int totalCountOfStones;
        int currentCountOfStones;
        bool MyTurn = true;

        private void EasyLevel_Load(object sender, EventArgs e)
        {

            Random random = new Random();

            totalCountOfStones = random.Next(57, 67);
            currentCountOfStones = random.Next(2, 9);

            labelCountOfStones.Text = totalCountOfStones.ToString();
            labelCurrentCountOfStones.Text = currentCountOfStones.ToString();

            Plus = random.Next(1, 4);
            Times = random.Next(2, 3);

            BtnPlus.Text = "+ " + Plus.ToString();
            BtnTimes.Text = "x " + Times.ToString();

            GameTimer.Start();
        }

        private void RobotTurn(ref bool MyTurn)
        {
            if (MyTurn == false)
            {
                Random random = new Random();

                labelWhosTurn.Text = "ХОД РОБОТА"; labelWhosTurn.ForeColor = Color.Red;
                Cursor = Cursors.WaitCursor;
                TurnTimer.Interval = random.Next(5000, 7000);
                TurnTimer.Start();
            }
        }


        private void CheckCountOfStones(int currentCountOfStones, int totalCountOfStones)
        {
            if (currentCountOfStones == totalCountOfStones)
            {
                GameTimer.Stop();
                this.Hide();
                WinnerForm winnerForm = new WinnerForm(form,minutes,seconds,form);
                winnerForm.ShowDialog();
                this.Close();
            }
            if (currentCountOfStones > totalCountOfStones)
            {
                GameTimer.Stop();
                this.Hide();
                LoserForm loseForm = new LoserForm(form, minutes, seconds, form);
                loseForm.ShowDialog();
                this.Close();
            }
        }

        int seconds = 0, minutes = 0;

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (seconds < 59)
            {
                seconds++;

                if (seconds < 10)
                {
                    labelSeconds.Text = "0" + seconds.ToString();
                }
                else
                {
                    labelSeconds.Text = seconds.ToString();
                }
            }
            else
            {
                if (minutes < 59)
                {
                    minutes++;
                    if (minutes < 10)
                    {
                        labelMinutes.Text = "0" + minutes.ToString();
                    }
                    else
                    {
                        labelMinutes.Text = minutes.ToString();
                    }

                    seconds = 0;
                    labelSeconds.Text = "00";
                }
                else
                {
                    minutes = 0;
                    labelMinutes.Text = "00";
                }
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (MyTurn == true)
            {
                labelWhosTurn.Text = "ВАШ ХОД"; labelWhosTurn.ForeColor = Color.LimeGreen;
                currentCountOfStones += Plus;
                labelCurrentCountOfStones.Text = currentCountOfStones.ToString();
                MyTurn = false;
            }

            CheckCountOfStones(currentCountOfStones, totalCountOfStones);
            RobotTurn(ref MyTurn);
        }

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            if (MyTurn == true)
            {

                labelWhosTurn.Text = "ВАШ ХОД"; labelWhosTurn.ForeColor = Color.LimeGreen;
                currentCountOfStones = currentCountOfStones * Times;
                labelCurrentCountOfStones.Text = currentCountOfStones.ToString();
                MyTurn = false;

            }


            CheckCountOfStones(currentCountOfStones, totalCountOfStones);
            RobotTurn(ref MyTurn);

        }

        private void TurnTimer_Tick(object sender, EventArgs e)
        {
            if (MyTurn == false)
            {
                TurnTimer.Stop();
                Cursor = Cursors.Default;

                Random random = new Random();
                int choise = random.Next(1, 2);

                if (choise == 1)
                {
                    currentCountOfStones = currentCountOfStones * Times;
                    labelCurrentCountOfStones.Text = currentCountOfStones.ToString();
                }
                else
                {
                    currentCountOfStones += Plus;
                    labelCurrentCountOfStones.Text = currentCountOfStones.ToString();
                }

                if (currentCountOfStones == totalCountOfStones)
                {
                    GameTimer.Stop();
                    this.Hide();
                    LoserForm loseForm = new LoserForm(form, minutes, seconds, form);
                    loseForm.ShowDialog();
                    this.Close();
                }

                if (currentCountOfStones > totalCountOfStones)
                {
                    GameTimer.Stop();
                    this.Hide();
                    WinnerForm winnerForm = new WinnerForm(form,minutes,seconds,form);
                    winnerForm.ShowDialog();
                    this.Close();
                }

                labelWhosTurn.Text = "ВАШ ХОД"; labelWhosTurn.ForeColor = Color.LimeGreen;
                MyTurn = true;
            }
        }
    }
}
