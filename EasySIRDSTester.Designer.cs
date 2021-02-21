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

namespace svrmtest
{
    partial class EasySIRDSTester
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasySIRDSTester));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_pos_tl = new System.Windows.Forms.Button();
            this.bt_pos_tr = new System.Windows.Forms.Button();
            this.bt_pos_bl = new System.Windows.Forms.Button();
            this.bt_pos_br = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.cb_pos_tl = new System.Windows.Forms.CheckBox();
            this.cb_pos_tr = new System.Windows.Forms.CheckBox();
            this.cb_pos_bl = new System.Windows.Forms.CheckBox();
            this.cb_pos_br = new System.Windows.Forms.CheckBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_sh_circle = new System.Windows.Forms.CheckBox();
            this.cb_sh_triangle = new System.Windows.Forms.CheckBox();
            this.cb_sh_star = new System.Windows.Forms.CheckBox();
            this.cb_sh_square = new System.Windows.Forms.CheckBox();
            this.bt_circle = new System.Windows.Forms.Button();
            this.bt_triangle = new System.Windows.Forms.Button();
            this.bt_star = new System.Windows.Forms.Button();
            this.bt_square = new System.Windows.Forms.Button();
            this.cb_sh_nothing = new System.Windows.Forms.CheckBox();
            this.cb_sh_egg = new System.Windows.Forms.CheckBox();
            this.cb_sh_rombus = new System.Windows.Forms.CheckBox();
            this.cb_sh_penta = new System.Windows.Forms.CheckBox();
            this.bt_nothing = new System.Windows.Forms.Button();
            this.bt_egg = new System.Windows.Forms.Button();
            this.bt_rombus = new System.Windows.Forms.Button();
            this.bt_penta = new System.Windows.Forms.Button();
            this.lbl_gamestate = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bt_setpathout = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(850, 850);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_pos_tl
            // 
            this.bt_pos_tl.Location = new System.Drawing.Point(908, 201);
            this.bt_pos_tl.Name = "bt_pos_tl";
            this.bt_pos_tl.Size = new System.Drawing.Size(75, 33);
            this.bt_pos_tl.TabIndex = 4;
            this.bt_pos_tl.Text = "top left";
            this.bt_pos_tl.UseVisualStyleBackColor = true;
            this.bt_pos_tl.Click += new System.EventHandler(this.bt_pos_tl_Click);
            // 
            // bt_pos_tr
            // 
            this.bt_pos_tr.Location = new System.Drawing.Point(1021, 201);
            this.bt_pos_tr.Name = "bt_pos_tr";
            this.bt_pos_tr.Size = new System.Drawing.Size(75, 33);
            this.bt_pos_tr.TabIndex = 5;
            this.bt_pos_tr.Text = "top right";
            this.bt_pos_tr.UseVisualStyleBackColor = true;
            this.bt_pos_tr.Click += new System.EventHandler(this.bt_pos_tr_Click);
            // 
            // bt_pos_bl
            // 
            this.bt_pos_bl.Location = new System.Drawing.Point(908, 240);
            this.bt_pos_bl.Name = "bt_pos_bl";
            this.bt_pos_bl.Size = new System.Drawing.Size(75, 33);
            this.bt_pos_bl.TabIndex = 6;
            this.bt_pos_bl.Text = "bottom left";
            this.bt_pos_bl.UseVisualStyleBackColor = true;
            this.bt_pos_bl.Click += new System.EventHandler(this.bt_pos_bl_Click);
            // 
            // bt_pos_br
            // 
            this.bt_pos_br.Location = new System.Drawing.Point(1021, 240);
            this.bt_pos_br.Name = "bt_pos_br";
            this.bt_pos_br.Size = new System.Drawing.Size(75, 33);
            this.bt_pos_br.TabIndex = 7;
            this.bt_pos_br.Text = "bottom right";
            this.bt_pos_br.UseVisualStyleBackColor = true;
            this.bt_pos_br.Click += new System.EventHandler(this.bt_pos_br_Click);
            // 
            // bt_start
            // 
            this.bt_start.Enabled = false;
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.Location = new System.Drawing.Point(904, 119);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(90, 31);
            this.bt_start.TabIndex = 8;
            this.bt_start.Text = "START";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.button5_Click);
            // 
            // cb_pos_tl
            // 
            this.cb_pos_tl.AutoSize = true;
            this.cb_pos_tl.Enabled = false;
            this.cb_pos_tl.Location = new System.Drawing.Point(887, 211);
            this.cb_pos_tl.Name = "cb_pos_tl";
            this.cb_pos_tl.Size = new System.Drawing.Size(15, 14);
            this.cb_pos_tl.TabIndex = 9;
            this.cb_pos_tl.UseVisualStyleBackColor = true;
            // 
            // cb_pos_tr
            // 
            this.cb_pos_tr.AutoSize = true;
            this.cb_pos_tr.Enabled = false;
            this.cb_pos_tr.Location = new System.Drawing.Point(1000, 211);
            this.cb_pos_tr.Name = "cb_pos_tr";
            this.cb_pos_tr.Size = new System.Drawing.Size(15, 14);
            this.cb_pos_tr.TabIndex = 10;
            this.cb_pos_tr.UseVisualStyleBackColor = true;
            // 
            // cb_pos_bl
            // 
            this.cb_pos_bl.AutoSize = true;
            this.cb_pos_bl.Enabled = false;
            this.cb_pos_bl.Location = new System.Drawing.Point(887, 250);
            this.cb_pos_bl.Name = "cb_pos_bl";
            this.cb_pos_bl.Size = new System.Drawing.Size(15, 14);
            this.cb_pos_bl.TabIndex = 11;
            this.cb_pos_bl.UseVisualStyleBackColor = true;
            // 
            // cb_pos_br
            // 
            this.cb_pos_br.AutoSize = true;
            this.cb_pos_br.Enabled = false;
            this.cb_pos_br.Location = new System.Drawing.Point(1000, 250);
            this.cb_pos_br.Name = "cb_pos_br";
            this.cb_pos_br.Size = new System.Drawing.Size(15, 14);
            this.cb_pos_br.TabIndex = 12;
            this.cb_pos_br.UseVisualStyleBackColor = true;
            // 
            // bt_submit
            // 
            this.bt_submit.Enabled = false;
            this.bt_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_submit.Location = new System.Drawing.Point(904, 602);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(90, 31);
            this.bt_submit.TabIndex = 14;
            this.bt_submit.Text = "SUBMIT";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(908, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Position:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(908, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Shape:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(904, 657);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Time:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(959, 657);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(10, 13);
            this.label_time.TabIndex = 18;
            this.label_time.Text = "-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(899, 688);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Score:";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(959, 688);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(10, 13);
            this.label_score.TabIndex = 20;
            this.label_score.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1014, 611);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Test completed";
            this.label7.Visible = false;
            // 
            // cb_sh_circle
            // 
            this.cb_sh_circle.AutoSize = true;
            this.cb_sh_circle.Enabled = false;
            this.cb_sh_circle.Location = new System.Drawing.Point(1000, 406);
            this.cb_sh_circle.Name = "cb_sh_circle";
            this.cb_sh_circle.Size = new System.Drawing.Size(15, 14);
            this.cb_sh_circle.TabIndex = 29;
            this.cb_sh_circle.UseVisualStyleBackColor = true;
            // 
            // cb_sh_triangle
            // 
            this.cb_sh_triangle.AutoSize = true;
            this.cb_sh_triangle.Enabled = false;
            this.cb_sh_triangle.Location = new System.Drawing.Point(887, 406);
            this.cb_sh_triangle.Name = "cb_sh_triangle";
            this.cb_sh_triangle.Size = new System.Drawing.Size(15, 14);
            this.cb_sh_triangle.TabIndex = 28;
            this.cb_sh_triangle.UseVisualStyleBackColor = true;
            // 
            // cb_sh_star
            // 
            this.cb_sh_star.AutoSize = true;
            this.cb_sh_star.Enabled = false;
            this.cb_sh_star.Location = new System.Drawing.Point(1000, 340);
            this.cb_sh_star.Name = "cb_sh_star";
            this.cb_sh_star.Size = new System.Drawing.Size(15, 14);
            this.cb_sh_star.TabIndex = 27;
            this.cb_sh_star.UseVisualStyleBackColor = true;
            // 
            // cb_sh_square
            // 
            this.cb_sh_square.AutoSize = true;
            this.cb_sh_square.Enabled = false;
            this.cb_sh_square.Location = new System.Drawing.Point(887, 340);
            this.cb_sh_square.Name = "cb_sh_square";
            this.cb_sh_square.Size = new System.Drawing.Size(15, 14);
            this.cb_sh_square.TabIndex = 26;
            this.cb_sh_square.UseVisualStyleBackColor = true;
            // 
            // bt_circle
            // 
            this.bt_circle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_circle.BackgroundImage")));
            this.bt_circle.Location = new System.Drawing.Point(1021, 382);
            this.bt_circle.Name = "bt_circle";
            this.bt_circle.Size = new System.Drawing.Size(64, 60);
            this.bt_circle.TabIndex = 25;
            this.bt_circle.UseVisualStyleBackColor = true;
            this.bt_circle.Click += new System.EventHandler(this.bt_circle_Click);
            // 
            // bt_triangle
            // 
            this.bt_triangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_triangle.BackgroundImage")));
            this.bt_triangle.Location = new System.Drawing.Point(908, 382);
            this.bt_triangle.Name = "bt_triangle";
            this.bt_triangle.Size = new System.Drawing.Size(64, 60);
            this.bt_triangle.TabIndex = 24;
            this.bt_triangle.UseVisualStyleBackColor = true;
            this.bt_triangle.Click += new System.EventHandler(this.bt_triangle_Click);
            // 
            // bt_star
            // 
            this.bt_star.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_star.BackgroundImage")));
            this.bt_star.Location = new System.Drawing.Point(1021, 316);
            this.bt_star.Name = "bt_star";
            this.bt_star.Size = new System.Drawing.Size(64, 60);
            this.bt_star.TabIndex = 23;
            this.bt_star.UseVisualStyleBackColor = true;
            this.bt_star.Click += new System.EventHandler(this.bt_star_Click);
            // 
            // bt_square
            // 
            this.bt_square.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_square.BackgroundImage")));
            this.bt_square.Location = new System.Drawing.Point(908, 316);
            this.bt_square.Name = "bt_square";
            this.bt_square.Size = new System.Drawing.Size(64, 60);
            this.bt_square.TabIndex = 22;
            this.bt_square.UseVisualStyleBackColor = true;
            this.bt_square.Click += new System.EventHandler(this.bt_square_Click);
            // 
            // cb_sh_nothing
            // 
            this.cb_sh_nothing.AutoSize = true;
            this.cb_sh_nothing.Enabled = false;
            this.cb_sh_nothing.Location = new System.Drawing.Point(1000, 542);
            this.cb_sh_nothing.Name = "cb_sh_nothing";
            this.cb_sh_nothing.Size = new System.Drawing.Size(15, 14);
            this.cb_sh_nothing.TabIndex = 37;
            this.cb_sh_nothing.UseVisualStyleBackColor = true;
            // 
            // cb_sh_egg
            // 
            this.cb_sh_egg.AutoSize = true;
            this.cb_sh_egg.Enabled = false;
            this.cb_sh_egg.Location = new System.Drawing.Point(887, 538);
            this.cb_sh_egg.Name = "cb_sh_egg";
            this.cb_sh_egg.Size = new System.Drawing.Size(15, 14);
            this.cb_sh_egg.TabIndex = 36;
            this.cb_sh_egg.UseVisualStyleBackColor = true;
            // 
            // cb_sh_rombus
            // 
            this.cb_sh_rombus.AutoSize = true;
            this.cb_sh_rombus.Enabled = false;
            this.cb_sh_rombus.Location = new System.Drawing.Point(1000, 472);
            this.cb_sh_rombus.Name = "cb_sh_rombus";
            this.cb_sh_rombus.Size = new System.Drawing.Size(15, 14);
            this.cb_sh_rombus.TabIndex = 35;
            this.cb_sh_rombus.UseVisualStyleBackColor = true;
            // 
            // cb_sh_penta
            // 
            this.cb_sh_penta.AutoSize = true;
            this.cb_sh_penta.Enabled = false;
            this.cb_sh_penta.Location = new System.Drawing.Point(887, 472);
            this.cb_sh_penta.Name = "cb_sh_penta";
            this.cb_sh_penta.Size = new System.Drawing.Size(15, 14);
            this.cb_sh_penta.TabIndex = 34;
            this.cb_sh_penta.UseVisualStyleBackColor = true;
            // 
            // bt_nothing
            // 
            this.bt_nothing.Location = new System.Drawing.Point(1021, 518);
            this.bt_nothing.Name = "bt_nothing";
            this.bt_nothing.Size = new System.Drawing.Size(64, 68);
            this.bt_nothing.TabIndex = 33;
            this.bt_nothing.Text = "nothing";
            this.bt_nothing.UseVisualStyleBackColor = true;
            this.bt_nothing.Click += new System.EventHandler(this.bt_nothing_Click);
            // 
            // bt_egg
            // 
            this.bt_egg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_egg.BackgroundImage")));
            this.bt_egg.Location = new System.Drawing.Point(908, 518);
            this.bt_egg.Name = "bt_egg";
            this.bt_egg.Size = new System.Drawing.Size(64, 68);
            this.bt_egg.TabIndex = 32;
            this.bt_egg.UseVisualStyleBackColor = true;
            this.bt_egg.Click += new System.EventHandler(this.bt_egg_Click);
            // 
            // bt_rombus
            // 
            this.bt_rombus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_rombus.BackgroundImage")));
            this.bt_rombus.Location = new System.Drawing.Point(1021, 448);
            this.bt_rombus.Name = "bt_rombus";
            this.bt_rombus.Size = new System.Drawing.Size(64, 64);
            this.bt_rombus.TabIndex = 31;
            this.bt_rombus.UseVisualStyleBackColor = true;
            this.bt_rombus.Click += new System.EventHandler(this.bt_rombus_Click);
            // 
            // bt_penta
            // 
            this.bt_penta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_penta.BackgroundImage")));
            this.bt_penta.Location = new System.Drawing.Point(908, 448);
            this.bt_penta.Name = "bt_penta";
            this.bt_penta.Size = new System.Drawing.Size(64, 64);
            this.bt_penta.TabIndex = 30;
            this.bt_penta.UseVisualStyleBackColor = true;
            this.bt_penta.Click += new System.EventHandler(this.bt_penta_Click);
            // 
            // lbl_gamestate
            // 
            this.lbl_gamestate.AutoSize = true;
            this.lbl_gamestate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamestate.Location = new System.Drawing.Point(1016, 128);
            this.lbl_gamestate.Name = "lbl_gamestate";
            this.lbl_gamestate.Size = new System.Drawing.Size(11, 13);
            this.lbl_gamestate.TabIndex = 38;
            this.lbl_gamestate.Text = "-";
            this.lbl_gamestate.Click += new System.EventHandler(this.label4_Click);
            // 
            // bt_setpathout
            // 
            this.bt_setpathout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_setpathout.Location = new System.Drawing.Point(904, 72);
            this.bt_setpathout.Name = "bt_setpathout";
            this.bt_setpathout.Size = new System.Drawing.Size(90, 41);
            this.bt_setpathout.TabIndex = 39;
            this.bt_setpathout.Text = "Set Output Path";
            this.bt_setpathout.UseVisualStyleBackColor = true;
            this.bt_setpathout.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 889);
            this.Controls.Add(this.bt_setpathout);
            this.Controls.Add(this.lbl_gamestate);
            this.Controls.Add(this.cb_sh_nothing);
            this.Controls.Add(this.cb_sh_egg);
            this.Controls.Add(this.cb_sh_rombus);
            this.Controls.Add(this.cb_sh_penta);
            this.Controls.Add(this.bt_nothing);
            this.Controls.Add(this.bt_egg);
            this.Controls.Add(this.bt_rombus);
            this.Controls.Add(this.bt_penta);
            this.Controls.Add(this.cb_sh_circle);
            this.Controls.Add(this.cb_sh_triangle);
            this.Controls.Add(this.cb_sh_star);
            this.Controls.Add(this.cb_sh_square);
            this.Controls.Add(this.bt_circle);
            this.Controls.Add(this.bt_triangle);
            this.Controls.Add(this.bt_star);
            this.Controls.Add(this.bt_square);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.cb_pos_br);
            this.Controls.Add(this.cb_pos_bl);
            this.Controls.Add(this.cb_pos_tr);
            this.Controls.Add(this.cb_pos_tl);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_pos_br);
            this.Controls.Add(this.bt_pos_bl);
            this.Controls.Add(this.bt_pos_tr);
            this.Controls.Add(this.bt_pos_tl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Stereoacuity Test";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_pos_tl;
        private System.Windows.Forms.Button bt_pos_tr;
        private System.Windows.Forms.Button bt_pos_bl;
        private System.Windows.Forms.Button bt_pos_br;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.CheckBox cb_pos_tl;
        private System.Windows.Forms.CheckBox cb_pos_tr;
        private System.Windows.Forms.CheckBox cb_pos_bl;
        private System.Windows.Forms.CheckBox cb_pos_br;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cb_sh_circle;
        private System.Windows.Forms.CheckBox cb_sh_triangle;
        private System.Windows.Forms.CheckBox cb_sh_star;
        private System.Windows.Forms.CheckBox cb_sh_square;
        private System.Windows.Forms.Button bt_circle;
        private System.Windows.Forms.Button bt_triangle;
        private System.Windows.Forms.Button bt_star;
        private System.Windows.Forms.Button bt_square;
        private System.Windows.Forms.CheckBox cb_sh_nothing;
        private System.Windows.Forms.CheckBox cb_sh_egg;
        private System.Windows.Forms.CheckBox cb_sh_rombus;
        private System.Windows.Forms.CheckBox cb_sh_penta;
        private System.Windows.Forms.Button bt_nothing;
        private System.Windows.Forms.Button bt_egg;
        private System.Windows.Forms.Button bt_rombus;
        private System.Windows.Forms.Button bt_penta;
        private System.Windows.Forms.Label lbl_gamestate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button bt_setpathout;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

