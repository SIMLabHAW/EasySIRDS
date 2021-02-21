/*
 This file is part of EasySIRDS.

    EasySIRDS is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    EasySIRDS is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with EasySIRDS.  If not, see<http://www.gnu.org/licenses/>.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace svrmtest
{
    public partial class EasySIRDSTester : Form
    {

        private static System.Timers.Timer aTimer;
        public int time0 = 0; 
        public int time1 = 0;
        public int time2 = 0; 
        public int time3 = 0;
        public int totaltime = 0;
        public int score = 0;
        public int score0 = 0;
        public int score1 = 0;
        public int score2 = 0;
        public int score3 = 0;
        public int totalscore = 0;

        public int rnd2 = 0;

        public int lastgame = 0;
        public int lasttime0 = 0;
        public int lasttime1 = 0;
        public int lasttime2 = 0;
        public int lasttime3 = 0;

        public int pos = 0;
        public int shape = 0;

        public int game_length = 10;
        public int game_instance = 0;
        public int gamestate = 0;
        // 0 = plain, 1 = easy, 2 = normal, 3 = hard;

        public string savepath = "";
        public string openpath = "";
        public string datapath = "";

        string[,,] outputdata = new string[4,10,3];

        public Random rnd = new Random();

        int[,] solution = { { 1, 3, 2, 4, 3, 2, 3, 1, 4, 2, 4, 3, 1, 2, 3, 4, 1, 4, 2, 3}, 
                            { 1, 1, 1, 2, 2, 2, 4, 4, 4, 6, 6, 6, 3, 3, 3, 3, 5, 5, 5, 5} };
        //                    1, 2, 3, 4, 5, 6, 7, 8, 9,  , 1, 2, 3, 4, 5, 6, 7, 8, 9
        //top left = 1, top right = 2, bottom left = 3, bottom right = 4, nothing = 5
        //rectangle = 1, star = 2, triangle = 3, circle = 4, pentagon = 5, rombus = 6, egg = 7, nothing = 8


        public EasySIRDSTester()
        {
            InitializeComponent();

        }

        private void button5_Click(object sender, EventArgs e) //start button
        {
            SetTimer();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            loadpicture();

            lbl_gamestate.Text = "Plain";

            bt_start.Enabled = false;
            bt_submit.Enabled = true;

        }

        private void SetTimer()
        {
            aTimer = new System.Timers.Timer(100); 
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (gamestate == 0)
            {
                time0++;
            }
            if (gamestate == 1)
            {
                time1++;
            }
            if (gamestate == 2)
            {
                time2++;
            }
            if (gamestate == 3)
            {
                time3++;
            }
        }

        private void loadpicture()
        {
            datapath = System.IO.Directory.GetCurrentDirectory();

            while (rnd2 == lastgame)
            {
                rnd2 = rnd.Next(1, 20);
            }
            
            if (rnd2 < 10)
            {
                pictureBox1.Image = Image.FromFile(datapath + "//Images//" + gamestate + "000" + rnd2 + ".bmp");
            }
            else
            {
                pictureBox1.Image = Image.FromFile(datapath + "//Images//" + gamestate + "00" + rnd2 + ".bmp");
            }
            
            lastgame = rnd2;
        }

        private bool checkanswer()
        {
            if (pos == solution[0, (rnd2 - 1)])
            {
                if (shape == solution[1, (rnd2 - 1)])
                {
                    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        private void createoutput()
        {
            if (game_instance < game_length)
            {
                if (rnd2 < 10)
                {
                    outputdata[gamestate,game_instance, 0] = Convert.ToString(gamestate) + "000" + Convert.ToString(rnd2) + ".bmp";
                }
                if (rnd2 > 9)
                {
                    outputdata[gamestate, game_instance, 0] = Convert.ToString(gamestate) + "00" + Convert.ToString(rnd2) + ".bmp";
                }
                if (game_instance == 0)
                {
                    if (gamestate == 0)
                    {
                        outputdata[gamestate, game_instance, 1] = Convert.ToString((double)time0 / 10.0) + "s";
                    }
                    if (gamestate == 1)
                    {
                        outputdata[gamestate, game_instance, 1] = Convert.ToString((double)time1 / 10.0) + "s";
                    }
                    if (gamestate == 2)
                    {
                        outputdata[gamestate, game_instance, 1] = Convert.ToString((double)time2 / 10.0) + "s";
                    }
                    if (gamestate == 3)
                    {
                        outputdata[gamestate, game_instance, 1] = Convert.ToString((double)time3 / 10.0) + "s";
                    }
                    
                }
                else
                {
                    if (gamestate == 0)
                    {
                        outputdata[gamestate, game_instance, 1] = Convert.ToString(((double)time0 - lasttime0) / 10.0) + "s";
                    }
                    if (gamestate == 1)
                    {
                        outputdata[gamestate, game_instance, 1] = Convert.ToString(((double)time1 - lasttime1) / 10.0) + "s";
                    }
                    if (gamestate == 2)
                    {
                        outputdata[gamestate, game_instance, 1] = Convert.ToString(((double)time2 - lasttime2) / 10.0) + "s";
                    }
                    if (gamestate == 3)
                    {
                        outputdata[gamestate, game_instance, 1] = Convert.ToString(((double)time3 - lasttime3) / 10.0) + "s";
                    }
                    
                }
                
                outputdata[gamestate, game_instance, 2] = Convert.ToString(checkanswer());
            }
        }

        private void button6_Click(object sender, EventArgs e) // submit button
        {
            createoutput();

            if (gamestate == 0)
            {
                if (checkanswer() == true)
                {
                    score0++;
                }
            }
            if (gamestate == 1)
            {
                if (checkanswer() == true)
                {
                    score1++;
                }
            }
            if (gamestate == 2)
            {
                if (checkanswer() == true)
                {
                    score2++;
                }
            }
            if (gamestate == 3)
            {
                if (checkanswer() == true)
                {
                    score3++;
                }
            }
            

            game_instance++;

            if (gamestate == 0)
            {
                lasttime0 = time0;
            }
            if (gamestate == 1)
            {
                lasttime1 = time1;
            }
            if (gamestate == 2)
            {
                lasttime2 = time2;
            }
            if (gamestate == 3)
            {
                lasttime3 = time3;
            }
            

            reset_bt_pos();
            reset_bt_shape();

            if (game_instance < game_length)
            {
                loadpicture();
            }

            if (game_instance == game_length & gamestate != 3)
            {
                game_instance = 0;
                gamestate++;

                if (gamestate == 1)
                {
                    lbl_gamestate.Text = "Easy";
                }
                if (gamestate == 2)
                {
                    lbl_gamestate.Text = "Normal";
                }
                if (gamestate == 3)
                {
                    lbl_gamestate.Text = "Hard";
                }

                loadpicture();
            }

            if (game_instance == game_length & gamestate == 3)
            {
                bt_submit.Enabled = false;

                totaltime = time0 + time1 + time2 + time3;
                totalscore = score0 + score1 + score2 + score3;
                label_time.Text = Convert.ToString(totaltime / (double)10.0) + "s";
                label_score.Text = Convert.ToString(totalscore) + "/" + Convert.ToString(game_length*4);
                label7.Visible = true;

                    
                using (StreamWriter sw = File.CreateText(savepath))
                {
                    for (int ii = 0; ii < 4; ii++)
                    {
                        if (ii == 0)
                        {
                            sw.WriteLine("Plain;;;");
                        }
                        if (ii == 1)
                        {
                            sw.WriteLine("Easy;;;");
                        }
                        if (ii == 2)
                        {
                            sw.WriteLine("Normal;;;");
                        }
                        if (ii == 3)
                        {
                            sw.WriteLine("Hard;;;");
                        }
                        for (int i = 0; i < game_length; i++)
                        {
                            sw.WriteLine(outputdata[ii, i, 0] + ";" + outputdata[ii, i, 1] + ";" + outputdata[ii, i, 2] + ";;;");    
                        }
                    }
                    sw.WriteLine("Plain Time:;" + Convert.ToString(time0 / (double)10.0) + "s");
                    sw.WriteLine("Plain Time Avg.:;" + Convert.ToString((time0 / (double)10.0)/game_length) + "s");
                    sw.WriteLine("Plain Score:;" + Convert.ToString(score0));
                    sw.WriteLine("Easy Time:;" + Convert.ToString(time1 / (double)10.0) + "s");
                    sw.WriteLine("Easy Time Avg.:;" + Convert.ToString((time1 / (double)10.0) / game_length) + "s");
                    sw.WriteLine("Easy Score:;" + Convert.ToString(score1));
                    sw.WriteLine("Normal Time:;" + Convert.ToString(time2 / (double)10.0) + "s");
                    sw.WriteLine("Normal Time Avg.:;" + Convert.ToString((time2 / (double)10.0) / game_length) + "s");
                    sw.WriteLine("Normal Score:;" + Convert.ToString(score2));
                    sw.WriteLine("Hard Time:;" + Convert.ToString(time3 / (double)10.0) + "s");
                    sw.WriteLine("Hard Time Avg.:;" + Convert.ToString((time3 / (double)10.0) / game_length) + "s");
                    sw.WriteLine("Hard Score:;" + Convert.ToString(score3));
                    sw.WriteLine("Total Time:;" + Convert.ToString(totaltime / (double)10.0) + "s");                    
                    sw.WriteLine("Total Score:;" + Convert.ToString(totalscore));
                    sw.WriteLine("Total Images:;" + Convert.ToString(4*game_length));
                    sw.WriteLine("Total Time - Plain:;" + Convert.ToString(((totaltime - time0) / (double)10.0))  + "s");
                    sw.WriteLine("Total Score - Plain:;" + Convert.ToString(totalscore-score0));
                    sw.WriteLine("Total Images - Plain:;" + Convert.ToString(3 * game_length));

                    sw.Close();  
                    
                }
                    
            }

        }

        private void reset_bt_pos()
        {
            cb_pos_tl.Checked = false;
            cb_pos_tr.Checked = false;
            cb_pos_bl.Checked = false;
            cb_pos_br.Checked = false;
        }

        private void reset_bt_shape()
        {
            cb_sh_square.Checked = false;
            cb_sh_star.Checked = false;
            cb_sh_triangle.Checked = false;
            cb_sh_circle.Checked = false;
            cb_sh_penta.Checked = false;
            cb_sh_rombus.Checked = false;
            cb_sh_egg.Checked = false;
            cb_sh_nothing.Checked = false;
        }


        private void bt_pos_tl_Click(object sender, EventArgs e)
        {
            if (cb_sh_nothing.Checked == false)
            {
                reset_bt_pos();

                cb_pos_tl.Checked = true;
                
                pos = 1;
            }
        }

        private void bt_pos_tr_Click(object sender, EventArgs e)
        {
            if (cb_sh_nothing.Checked == false)
            {
                reset_bt_pos();

                cb_pos_tr.Checked = true;
                
                pos = 2;
            }
        }

        private void bt_pos_bl_Click(object sender, EventArgs e)
        {
            if (cb_sh_nothing.Checked == false)
            {
                reset_bt_pos();

                cb_pos_bl.Checked = true;
               
                pos = 3;
            }
        }

        private void bt_pos_br_Click(object sender, EventArgs e)
        {
            if (cb_sh_nothing.Checked == false)
            {
                reset_bt_pos();

                cb_pos_br.Checked = true;

                pos = 4;
            }
        }

        private void bt_square_Click(object sender, EventArgs e)
        {
            reset_bt_shape();

            cb_sh_square.Checked = true;
            
            shape = 1;
        }

        private void bt_star_Click(object sender, EventArgs e)
        {
            reset_bt_shape();

            cb_sh_star.Checked = true;
           
            shape = 2;
        }

        private void bt_triangle_Click(object sender, EventArgs e)
        {
            reset_bt_shape();

            cb_sh_triangle.Checked = true;
            
            shape = 3;
        }

        private void bt_circle_Click(object sender, EventArgs e)
        {
            reset_bt_shape();

            cb_sh_circle.Checked = true;
            
            shape = 4;
        }

        private void bt_penta_Click(object sender, EventArgs e)
        {
            reset_bt_shape();

            cb_sh_penta.Checked = true;
            
            shape = 5;
        }

        private void bt_rombus_Click(object sender, EventArgs e)
        {
            reset_bt_shape();

            cb_sh_rombus.Checked = true;
           
            shape = 6;
        }

        private void bt_egg_Click(object sender, EventArgs e)
        {
            reset_bt_shape();

            cb_sh_egg.Checked = true;
           
            shape = 7;
        }

        private void bt_nothing_Click(object sender, EventArgs e)
        {
            reset_bt_pos();
            reset_bt_shape();

            cb_sh_nothing.Checked = true;

            pos = 5;
            shape = 8;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //set output path
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = "Output.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                savepath = saveFileDialog1.FileName;

            }

            bt_start.Enabled = true;
            bt_setpathout.Enabled = false;
        }

    }

}
