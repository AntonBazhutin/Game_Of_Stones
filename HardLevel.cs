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
    public partial class HardLevel : Form
    {
        public HardLevel()
        {
            InitializeComponent();
        }

        bool isCreated = false;
        string form = "hard";
        int Plus;
        int Times;
        int Minus;
        int Divide;
        int totalCountOfStones;
        int currentCountOfStonesInFirstHeap;
        int currentCountOfStonesInSecondHeap;
        int currentCountOfStonesInThirdHeap;
        bool MyTurn = true;

        private void BtnTimes_Click(object sender, EventArgs e)
        {
            if (MyTurn == true)
            {
                labelWhosTurn.Text = "ВАШ ХОД"; labelWhosTurn.ForeColor = Color.LimeGreen;
                if (labelCurrentCountOfStonesInFirstHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    currentCountOfStonesInFirstHeap = Times * currentCountOfStonesInFirstHeap;
                    labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                }
                else
                  if (labelCurrentCountOfStonesInSecondHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    currentCountOfStonesInSecondHeap = Times * currentCountOfStonesInSecondHeap;
                    labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                }
                else
                    if (labelCurrentCountOfStonesInThirdHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    currentCountOfStonesInThirdHeap = Times * currentCountOfStonesInThirdHeap;
                    labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                }

                MyTurn = false;
            }

            CheckCountOfStones(totalCountOfStones, currentCountOfStonesInFirstHeap, currentCountOfStonesInSecondHeap, currentCountOfStonesInThirdHeap);
            RobotTurn(ref MyTurn);
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (MyTurn == true)
            {
                labelWhosTurn.Text = "ВАШ ХОД"; labelWhosTurn.ForeColor = Color.LimeGreen;
                if (labelCurrentCountOfStonesInFirstHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    currentCountOfStonesInFirstHeap += Plus;
                    labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                }
                else
                  if (labelCurrentCountOfStonesInSecondHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    currentCountOfStonesInSecondHeap += Plus;
                    labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                }
                else
                    if (labelCurrentCountOfStonesInThirdHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    currentCountOfStonesInThirdHeap += Plus;
                    labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                }

                MyTurn = false;
            }

            CheckCountOfStones(totalCountOfStones, currentCountOfStonesInFirstHeap, currentCountOfStonesInSecondHeap, currentCountOfStonesInThirdHeap);
            RobotTurn(ref MyTurn);
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (MyTurn == true)
            {
                labelWhosTurn.Text = "ВАШ ХОД"; labelWhosTurn.ForeColor = Color.LimeGreen;
                if (labelCurrentCountOfStonesInFirstHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    if (currentCountOfStonesInFirstHeap - Minus > 2)
                    {
                        currentCountOfStonesInFirstHeap = currentCountOfStonesInFirstHeap - Minus;
                        labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                        MyTurn = false;
                    }
                    else
                    {
                        MyTurn = true;
                    }
                }
                else
                  if (labelCurrentCountOfStonesInSecondHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    if (currentCountOfStonesInSecondHeap - Minus > 2)
                    {
                        currentCountOfStonesInSecondHeap = currentCountOfStonesInSecondHeap - Minus;
                        labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                        MyTurn = false;
                    }
                    else
                    {
                        MyTurn = true;
                    }
                }
                else
                    if (labelCurrentCountOfStonesInThirdHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    if (currentCountOfStonesInThirdHeap - Minus > 2)
                    {
                        currentCountOfStonesInThirdHeap = currentCountOfStonesInThirdHeap - Minus;
                        labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                        MyTurn = false;
                    }
                    else
                    {
                        MyTurn = true;
                    }
                }
            }

            CheckCountOfStones(totalCountOfStones, currentCountOfStonesInFirstHeap, currentCountOfStonesInSecondHeap, currentCountOfStonesInThirdHeap);
            RobotTurn(ref MyTurn);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (MyTurn == true)
            {
                labelWhosTurn.Text = "ВАШ ХОД"; labelWhosTurn.ForeColor = Color.LimeGreen;
                if (labelCurrentCountOfStonesInFirstHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    if (currentCountOfStonesInFirstHeap / Divide > 2)
                    {
                        currentCountOfStonesInFirstHeap = currentCountOfStonesInFirstHeap / 2;
                        labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                        MyTurn = false;
                    }
                    else
                    {
                        MyTurn = true;
                    }
                }
                else
                  if (labelCurrentCountOfStonesInSecondHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    if (currentCountOfStonesInSecondHeap / Divide > 2)
                    {
                        currentCountOfStonesInSecondHeap = currentCountOfStonesInSecondHeap / 2;
                        labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                        MyTurn = false;
                    }
                    else
                    {
                        MyTurn = true;
                    }
                }
                else
                    if (labelCurrentCountOfStonesInThirdHeap.BorderStyle == BorderStyle.FixedSingle)
                {
                    if (currentCountOfStonesInThirdHeap / Divide > 2)
                    {
                        currentCountOfStonesInThirdHeap = currentCountOfStonesInThirdHeap / 2;
                        labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                        MyTurn = false;
                    }
                    else
                    {
                        MyTurn = true;
                    }
                }
            }

            CheckCountOfStones(totalCountOfStones, currentCountOfStonesInFirstHeap, currentCountOfStonesInSecondHeap, currentCountOfStonesInThirdHeap);
            RobotTurn(ref MyTurn);
        }

        private void labelCurrentCountOfStonesInFirstHeap_Click(object sender, EventArgs e)
        {
            labelCurrentCountOfStonesInFirstHeap.BorderStyle = BorderStyle.FixedSingle;
            labelCurrentCountOfStonesInSecondHeap.BorderStyle = BorderStyle.None;
            labelCurrentCountOfStonesInThirdHeap.BorderStyle = BorderStyle.None;
        }

        private void labelCurrentCountOfStonesInSecondHeap_Click(object sender, EventArgs e)
        {
            labelCurrentCountOfStonesInSecondHeap.BorderStyle = BorderStyle.FixedSingle;
            labelCurrentCountOfStonesInFirstHeap.BorderStyle = BorderStyle.None;
            labelCurrentCountOfStonesInThirdHeap.BorderStyle = BorderStyle.None;
        }

        private void labelCurrentCountOfStonesInThirdHeap_Click(object sender, EventArgs e)
        {
            labelCurrentCountOfStonesInThirdHeap.BorderStyle = BorderStyle.FixedSingle;
            labelCurrentCountOfStonesInFirstHeap.BorderStyle = BorderStyle.None;
            labelCurrentCountOfStonesInSecondHeap.BorderStyle = BorderStyle.None;
        }

        private void HardLevel_Load(object sender, EventArgs e)
        {
            Random random = new Random();

            totalCountOfStones = random.Next(119, 138);
            currentCountOfStonesInFirstHeap = random.Next(11, 20);
            currentCountOfStonesInSecondHeap = random.Next(13, 19);
            currentCountOfStonesInThirdHeap = random.Next(12, 21);

            labelCountOfStones.Text = totalCountOfStones.ToString();
            labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
            labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
            labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();

            Plus = random.Next(1, 4);
            Times = random.Next(2, 3);
            Minus = random.Next(3, 4);
            Divide = random.Next(2, 3);


            BtnPlus.Text = "+ " + Plus.ToString();
            BtnTimes.Text = "x " + Times.ToString();
            btnMinus.Text = "- " + Minus.ToString();
            btnDivide.Text = ": " + Divide.ToString();

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

        private void CheckCountOfStones(int totalCountOfStones, int currentCountOfStonesInFirstHeap, int currentCountOfStonesInSecondHeap, int currentCountOfStonesInThirdHeap)
        {
            if (currentCountOfStonesInFirstHeap + currentCountOfStonesInSecondHeap + currentCountOfStonesInThirdHeap == totalCountOfStones)
            {
                if (isCreated == false)
                {
                    GameTimer.Stop();
                    this.Hide();
                    WinnerForm winnerForm = new WinnerForm(form, minutes, seconds, form);
                    winnerForm.ShowDialog();
                    this.Close();
                    isCreated = true;
                }
            }
            if (currentCountOfStonesInFirstHeap + currentCountOfStonesInSecondHeap + currentCountOfStonesInThirdHeap > totalCountOfStones)
            {
                if (isCreated == false)
                {
                    GameTimer.Stop();
                    this.Hide();
                    LoserForm loseForm = new LoserForm(form, minutes, seconds, form);
                    loseForm.ShowDialog();
                    this.Close();
                    isCreated = true;
                }
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

        private void TurnTimer_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            TurnTimer.Stop();

            if (MyTurn == false)
            {
                Cursor = Cursors.Default;

                Random random = new Random();
                int choise = random.Next(1, 4);
                int choiseOfHeap = random.Next(1, 3);
                if (choise == 1)
                {
                    if (choiseOfHeap == 1)
                    {
                        currentCountOfStonesInFirstHeap += Plus;
                        labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                    }
                    else
                   if (choiseOfHeap == 2)
                    {
                        currentCountOfStonesInSecondHeap += Plus;
                        labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                    }
                    else
                   if (choiseOfHeap == 3)
                    {
                        currentCountOfStonesInThirdHeap += Plus;
                        labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                    }
                }
                else
                if (choise == 2)
                {
                    if (choiseOfHeap == 1)
                    {
                        currentCountOfStonesInFirstHeap = Times * currentCountOfStonesInFirstHeap;
                        labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                    }
                    else
                  if (choiseOfHeap == 2)
                    {
                        currentCountOfStonesInSecondHeap = Times * currentCountOfStonesInSecondHeap;
                        labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                    }
                    else
                  if (choiseOfHeap == 3)
                    {
                        currentCountOfStonesInThirdHeap = Times * currentCountOfStonesInThirdHeap;
                        labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                    }
                }
                else
                if (choise == 3)
                {
                    if (choiseOfHeap == 1)
                    {
                        if (currentCountOfStonesInFirstHeap - Minus > 2)
                        {
                            currentCountOfStonesInFirstHeap = currentCountOfStonesInFirstHeap - Minus;
                            labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                        }
                        else
                        {
                            choise = random.Next(1, 3);
                            ChoiseOfHeapD(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap);
                        }
                    }
                    else
                    if (choiseOfHeap == 2)
                    {
                        if (currentCountOfStonesInSecondHeap - Minus > 2)
                        {
                            currentCountOfStonesInSecondHeap = currentCountOfStonesInSecondHeap - Minus;
                            labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                        }
                        else
                        {
                            choise = random.Next(1, 3);
                            ChoiseOfHeapD(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap);
                        }
                    }
                    else
                        if (choiseOfHeap == 3)
                    {
                        if (currentCountOfStonesInThirdHeap - Minus > 2)
                        {
                            currentCountOfStonesInThirdHeap = currentCountOfStonesInThirdHeap - Minus;
                            labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                        }
                        else
                        {
                            choise = random.Next(1, 3);
                            ChoiseOfHeapD(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap);
                        }
                    }
                }
                else
                if (choise == 4)
                {
                    if (choiseOfHeap == 1)
                    {
                        if (currentCountOfStonesInFirstHeap / Divide > 2)
                        {
                            currentCountOfStonesInFirstHeap = currentCountOfStonesInFirstHeap / Divide;
                            labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                        }
                        else
                        {
                            choise = random.Next(1, 3);
                            ChoiseOfHeapM(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap);
                        }
                    }
                    else
                   if (choiseOfHeap == 2)
                    {
                        if (currentCountOfStonesInSecondHeap / Divide > 2)
                        {
                            currentCountOfStonesInSecondHeap = currentCountOfStonesInSecondHeap / Divide;
                            labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                        }
                        else
                        {
                            choise = random.Next(1, 3);
                            ChoiseOfHeapM(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap);
                        }
                    }
                    else
                       if (choiseOfHeap == 3)
                    {
                        if (currentCountOfStonesInThirdHeap / Divide > 2)
                        {
                            currentCountOfStonesInThirdHeap = currentCountOfStonesInThirdHeap / Divide;
                            labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                        }
                        else
                        {
                            choise = random.Next(1, 3);
                            ChoiseOfHeapM(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap);
                        }
                    }
                }
            }

            if (currentCountOfStonesInFirstHeap + currentCountOfStonesInSecondHeap + currentCountOfStonesInThirdHeap == totalCountOfStones)
            {
                if (isCreated == false)
                {
                    GameTimer.Stop();
                    this.Hide();
                    LoserForm loseForm = new LoserForm(form, minutes, seconds, form);
                    loseForm.ShowDialog();
                    this.Close();
                    isCreated = true;
                }
            }

            if (currentCountOfStonesInFirstHeap + currentCountOfStonesInSecondHeap + currentCountOfStonesInThirdHeap > totalCountOfStones)
            {
                if (isCreated == false)
                {
                    GameTimer.Stop();
                    this.Hide();
                    WinnerForm winnerForm = new WinnerForm(form, minutes, seconds, form);
                    winnerForm.ShowDialog();
                    this.Close();
                    isCreated = true;
                }
            }
            labelWhosTurn.Text = "ВАШ ХОД"; labelWhosTurn.ForeColor = Color.LimeGreen;
            MyTurn = true;
        }


        private void ChoiseOfHeapM(int choise, int choiseOfHeap, ref int currentCountOfStonesInFirstHeap, ref int currentCountOfStonesInSecondHeap)
        {
            if (choise == 1)
            {
                if (choiseOfHeap == 1)
                {
                    currentCountOfStonesInFirstHeap += Plus;
                    labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                }
                else
                    if (choiseOfHeap == 2)
                {
                    currentCountOfStonesInSecondHeap += Plus;
                    labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                }
                else
                    if (choiseOfHeap == 3)
                {
                    currentCountOfStonesInThirdHeap += Plus;
                    labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                }
            }
            if (choise == 2)
            {
                if (choiseOfHeap == 1)
                {
                    currentCountOfStonesInFirstHeap = Times * currentCountOfStonesInFirstHeap;
                    labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                }
                else
                   if (choiseOfHeap == 2)
                {
                    currentCountOfStonesInSecondHeap = Times * currentCountOfStonesInSecondHeap;
                    labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                }
                else
                   if (choiseOfHeap == 3)
                {
                    currentCountOfStonesInThirdHeap = Times * currentCountOfStonesInThirdHeap;
                    labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                }
            }
            if (choise == 3)
            {
                Random random = new Random();
                if (choiseOfHeap == 1)
                {
                    if (currentCountOfStonesInFirstHeap - Minus > 2)
                    {
                        currentCountOfStonesInFirstHeap = currentCountOfStonesInFirstHeap - Minus;
                        labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                    }
                    else
                    {
                        choise = random.Next(1, 2);
                        ChoiseOfHeap(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap, ref currentCountOfStonesInThirdHeap);
                    }
                }
                else
                if (choiseOfHeap == 2)
                {
                    if (currentCountOfStonesInSecondHeap - Minus > 2)
                    {
                        currentCountOfStonesInSecondHeap = currentCountOfStonesInSecondHeap - Minus;
                        labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                    }
                    else
                    {
                        choise = random.Next(1, 2);
                        ChoiseOfHeap(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap, ref currentCountOfStonesInThirdHeap);
                    }
                }
                else
                if (choiseOfHeap == 3)
                {
                    if (currentCountOfStonesInThirdHeap - Minus > 2)
                    {
                        currentCountOfStonesInThirdHeap = currentCountOfStonesInThirdHeap - Minus;
                        labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                    }
                    else
                    {
                        choise = random.Next(1, 2);
                        ChoiseOfHeap(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap, ref currentCountOfStonesInThirdHeap);
                    }
                }
            }
        }

        private void ChoiseOfHeapD(int choise, int choiseOfHeap, ref int currentCountOfStonesInFirstHeap, ref int currentCountOfStonesInSecondHeap)
        {
            Random random = new Random();
            if (choise == 1)
            {
                if (choiseOfHeap == 1)
                {
                    currentCountOfStonesInFirstHeap += Plus;
                    labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                }
                else
                    if (choiseOfHeap == 2)
                {
                    currentCountOfStonesInSecondHeap += Plus;
                    labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                }
                else
                    if (choiseOfHeap == 3)
                {
                    currentCountOfStonesInThirdHeap += Plus;
                    labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                }
            }
            if (choise == 2)
            {
                if (choiseOfHeap == 1)
                {
                    currentCountOfStonesInFirstHeap = Times * currentCountOfStonesInFirstHeap;
                    labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                }
                else
                   if (choiseOfHeap == 2)
                {
                    currentCountOfStonesInSecondHeap = Times * currentCountOfStonesInSecondHeap;
                    labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                }
                else
                   if (choiseOfHeap == 3)
                {
                    currentCountOfStonesInThirdHeap = Times * currentCountOfStonesInThirdHeap;
                    labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                }
            }
            if (choise == 3)
            {
                if (choiseOfHeap == 1)
                {
                    if (currentCountOfStonesInFirstHeap / Divide > 2)
                    {
                        currentCountOfStonesInFirstHeap = currentCountOfStonesInFirstHeap / Divide;
                        labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                    }
                    else
                    {
                        choise = random.Next(1, 2);
                        ChoiseOfHeap(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap, ref currentCountOfStonesInThirdHeap);
                    }
                }
                else
              if (choiseOfHeap == 2)
                {
                    if (currentCountOfStonesInSecondHeap / Divide > 2)
                    {
                        currentCountOfStonesInSecondHeap = currentCountOfStonesInSecondHeap / Divide;
                        labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                    }
                    else
                    {
                        choise = random.Next(1, 2);
                        ChoiseOfHeap(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap, ref currentCountOfStonesInThirdHeap);
                    }
                }
                else
                  if (choiseOfHeap == 3)
                {
                    if (currentCountOfStonesInThirdHeap / Divide > 2)
                    {
                        currentCountOfStonesInThirdHeap = currentCountOfStonesInThirdHeap / Divide;
                        labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                    }
                    else
                    {
                        choise = random.Next(1, 2);
                        ChoiseOfHeap(choise, choiseOfHeap, ref currentCountOfStonesInFirstHeap, ref currentCountOfStonesInSecondHeap, ref currentCountOfStonesInThirdHeap);
                    }
                }
            }

        }

        private void ChoiseOfHeap(int choise, int choiseOfHeap, ref int currentCountOfStonesInFirstHeap, ref int currentCountOfStonesInSecondHeap, ref int currentCountOfStonesInThirdHeap)
        {
            if (choise == 1)
            {
                if (choiseOfHeap == 1)
                {
                    currentCountOfStonesInFirstHeap += Plus;
                    labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                }
                else
                    if (choiseOfHeap == 2)
                {
                    currentCountOfStonesInSecondHeap += Plus;
                    labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                }
                else
                    if (choiseOfHeap == 3)
                {
                    currentCountOfStonesInThirdHeap += Plus;
                    labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                }
            }
            if (choise == 2)
            {
                if (choiseOfHeap == 1)
                {
                    currentCountOfStonesInFirstHeap = Times * currentCountOfStonesInFirstHeap;
                    labelCurrentCountOfStonesInFirstHeap.Text = currentCountOfStonesInFirstHeap.ToString();
                }
                else
                   if (choiseOfHeap == 2)
                {
                    currentCountOfStonesInSecondHeap = Times * currentCountOfStonesInSecondHeap;
                    labelCurrentCountOfStonesInSecondHeap.Text = currentCountOfStonesInSecondHeap.ToString();
                }
                else
                   if (choiseOfHeap == 3)
                {
                    currentCountOfStonesInThirdHeap = Times * currentCountOfStonesInThirdHeap;
                    labelCurrentCountOfStonesInThirdHeap.Text = currentCountOfStonesInThirdHeap.ToString();
                }
            }
        }
    }
}
