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

        const int SpeedMax = 10;
        const int PlayerMax = 1;
        const int EnemyMax = 10;
        const int ItemMax = 10;
        const int ChrMax = PlayerMax + EnemyMax + ItemMax;
        Label[] chrs = new Label[ChrMax];
        int[] vx = new int[ChrMax];
        int[] vy = new int[ChrMax];
        const int PlayerIndex = 0;
        const int EnemyIndex = PlayerMax + PlayerIndex;
        const int ItemIndex = EnemyMax + EnemyIndex;
        const int StartTime = 100;

        const string PlayerText = "(・ω・)";
        const string EnemyText = "◆";
        const string ItemText = "★";

        static Random rand = new Random();

        int itemCount;
        int time;
        int hiscore = 0;

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
                leftLabel.Text = "★" + itemCount;
            }
        }

        void UpdateGame()
        {
            time--;
            timeLabel.Text = $"Time{time:00}" ;

            Point fpos = PointToClient(MousePosition);
            chrs[PlayerIndex].Left = fpos.X - chrs[0].Width / 2;
            chrs[PlayerIndex].Top = fpos.Y - chrs[0].Height / 2;

            for(int i=EnemyIndex;i<ChrMax;i++)
            {
                if (!chrs[i].Visible) continue;

                chrs[i].Left += vx[i];
                chrs[i].Top += vy[i];
                
                if(chrs[i].Left<0)
                {
                    vx[i] = Math.Abs(vx[i]);
                }
                if(chrs[i].Top<0)
                {
                    vy[i] = Math.Abs(vy[i]);
                }
                if (ClientSize.Width < chrs[i].Right)
                {
                    vx[i] = -Math.Abs(vx[i]);
                }
                if (ClientSize.Height < chrs[i].Bottom)
                {
                    vy[i] = -Math.Abs(vy[i]);
                }

                //当たり判定
                if(   (fpos.X>=chrs[i].Left)
                    &&(fpos.X<chrs[i].Right)
                    &&(fpos.Y>=chrs[i].Top)
                    &&(fpos.Y<chrs[i].Bottom))
                {
                    if(i<ItemIndex)//敵の当たり判定
                    {
                        nextState = State.Gameover;
                    }
                    else//アイテムの当たり判定
                    {
                        chrs[i].Visible = false;
                        itemCount--;
                        if(itemCount<=0)
                        {
                            nextState=State.Clear;
                        }
                        leftLabel.Text = "★" + itemCount;

                        /*vx[i] = 0;
                        vy[i] = 0;
                        chrs[i].Left = 10000;*/
                    }
                }
            }

            if (  (time <= 0)
                &&(nextState==State.None))
            {
                nextState = State.Gameover;
            }
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
                    restartButton.Visible = false;
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
                        vx[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        vy[i] = rand.Next(-SpeedMax, SpeedMax + 1);
                        chrs[i].Visible = true;
                    }

                    itemCount = ItemMax;
                    time = StartTime + 1;
                    leftLabel.Text = "★" + itemCount;

                    break;

                case State.Gameover:
                    gameOverLabel.Visible = true;
                    titlebutton.Visible = true;
                    restartButton.Visible = true;
                    break;

                case State.Clear:
                    clearLabel.Visible = true;
                    titlebutton.Visible = true;
                    if(time>hiscore)
                    {
                        hiscore = time;
                        highLabel.Text = "HighScore" + hiscore;
                    }
                    highLabel.Visible = true;
                    break;
            }
        }

        private void titlebutton_Click(object sender, EventArgs e)
        {
            nextState = State.Title;
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            gameOverLabel.Visible = false;
            titlebutton.Visible = false;
            restartButton.Visible = false;
            nextState = State.Game;
            itemCount = ItemMax;
            leftLabel.Text = "★" + itemCount;//timeLabelの書き方でもよい
            time = StartTime;
            timeLabel.Text = $"Time{time:00}";//leftLabelの書き方でもよい
        }
    }
}
