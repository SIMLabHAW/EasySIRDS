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

namespace SVRM
{
    public partial class EasySIRDS : Form
    {
        Bitmap map = null;

        Bitmap randomImage = new Bitmap(128, 128); //rndwidth x rndheight
        Bitmap bigrandom = new Bitmap(1024, 1024); //width x height

        public int width = 1024; //width of final sirds
        public int height = 1024; //height of final sirds

        public int rndwidth = 128; //width of small pattern
        public int rndheight = 128; //height of small pattern

        public int xdpi = 75;
        public int ydpi = 75;

        public int distance = 25; //in cm
        public double eyesep= 6.25; //in cm
        public double mu = 0.25; //change for difference in depth, should be smaller than 1
        public double z;
        public int sep;

        public string openpath;
        public string savepath;
        

        public EasySIRDS()
        {
            InitializeComponent();

            Text = "SIRDS";
        }

        public void algo(int width, int height)
        {
            int x2 = 0;
            int y2 = 0;
            Color big = Color.FromArgb(0,0,0);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Color zvalue = map.GetPixel(x,y);

                    z = ((zvalue.R / (double)255.0)) * (mu * distance);

                    sep = (int)(((1 - mu * z) / (2 - mu * z)) * eyesep);

                    if (x < rndwidth)
                    {
                        if (y < height)
                        {
                            x2 = x % (rndwidth + sep);
                            y2 = y % rndwidth;

                            if (x2 < 0)
                            {
                                x2 = (rndwidth) + x2;
                            }

                            big = randomImage.GetPixel(x2, y2);
                        }
                    }

                    else
                    {
                        x2 = x - (rndwidth + sep);
                        y2 = y;

                        if (x2 < 0)
                        {
                            x2 = (rndwidth) + x2;
                        }

                        big = bigrandom.GetPixel(x2, y2);
                        
                    }

                    bigrandom.SetPixel(x, y, big);

                }
            }            
        }

        public void createrandomimage(int rndwidth, int rndheight)
        {
            Random rnd = new Random();

            for (int x = 0; x < rndwidth; x++)
            {
                for (int y = 0; y < rndheight; y++)
                {
                    
                    int rnd2 = rnd.Next(0,255);

                    Color random = Color.FromArgb(rnd2, rnd2, rnd2);
                    randomImage.SetPixel(x, y, random);
                }
            }            
        }

        private void button1_Click(object sender, EventArgs e) // generate
        {        
            using (var image = new Bitmap(openpath))
            {
                map = new Bitmap(image);
            }

            createrandomimage(rndwidth, rndheight);

            algo(width, height);
        }

        private void button2_Click(object sender, EventArgs e) //change source
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            { 
                openpath = openFileDialog1.FileName;
            }
        }
        private void button3_Click(object sender, EventArgs e) //change saving location
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            { 
                savepath = saveFileDialog1.FileName;
            }

            bigrandom.Save(savepath + ".bmp");
            randomImage.Save(savepath + "_pattern.bmp");

        }
    }
}
