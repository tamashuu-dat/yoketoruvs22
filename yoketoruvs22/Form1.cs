using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace yoketoruvs22
{
    public partial class Form1 : Form
    {
        const bool isDebug = true;

        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerMax + PlayerIndex;
        const int ItemIndex = EnemyMax + EnemyIndex;

        const string PlayerText = "（・ω・）";
        const string EnemyText = "◆";
        const string ItemText = "★";

        static Random rand = new Random();

        enum State
        {
            None=-1,   //無効
            Title,     //タイトル
            Game,      //ゲーム
            Gameover,  //ゲームオーバー
            Clear      //クリア
        }
        State currentState = State.None;
        State nextState = State.Title;

        [DllImport("user32.dll")]

        public static extern short GetAsyncKeyState(int vKey);

        public Form1()
        {
            InitializeComponent();

            for(int i=0;i<ChrMax;i++)
            {
                chrs[i] = new Label();
                chrs[i].AutoSize = true;
                if(i==PlayerIndex)
                {
                    chrs[i].Text = PlayerText;
                }
                else if(i<ItemIndex)
                {
                    chrs[i].Text = EnemyText;
                }
                else
                {
                    chrs[i].Text = ItemText;
                }
                chrs[i].Font = tempLabel.Font;
                Controls.Add(chrs[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nextState = State.Game;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(nextState!=State.None)
            {
                initProc();
            }

            if(isDebug)
            {
                if (GetAsyncKeyState((int)Keys.O) < 0)
                {
                    nextState = State.Gameover;
                }
                else
                {
                    if (GetAsyncKeyState((int)Keys.C) < 0)
                    {
                        nextState = State.Clear;
                    }
                }
            }

            if(currentState==State.Game)
            {
                UpdateGame();
            }
        }

        void UpdateGame()
        {
            Point spos = MousePosition;
            Point fpos = PointToClient(spos);
            chrs[0].Left = fpos.X - chrs[0].Width / 2;
            chrs[0].Top = fpos.Y - chrs[0].Height / 2;
        }

        void initProc()
        {
            currentState = nextState;
            nextState = State.None;

            switch(currentState)
            {
                case State.Title:
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    copyrightLabel.Visible = true;
                    highLabel.Visible = true;
                    gameOverLabel.Visible = false;
                    titlebutton.Visible = false;
                    clearLabel.Visible = false;
                    break;

                case State.Game:
                    titleLabel.Visible = false;
                    startButton.Visible = false;
                    copyrightLabel.Visible = false;
                    highLabel.Visible = false;

                    for(int i=EnemyIndex;i<ChrMax;i++)
                    {
                        chrs[i].Left = rand.Next(ClientSize.Width - chrs[i].Width);
                        chrs[i].Top = rand.Next(ClientSize.Height - chrs[i].Height);
                    }

                    break;

                case State.Gameover:
                    gameOverLabel.Visible = true;
                    titlebutton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titlebutton.Visible = true;
                    highLabel.Visible = true;
                    break;
            }
        }

        private void titlebutton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }
    }
}
