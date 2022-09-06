namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.endbox = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.countdown = new System.Windows.Forms.Label();
            this.playtimer = new System.Windows.Forms.Timer(this.components);
            this.gameovertimer = new System.Windows.Forms.Timer(this.components);
            this.hard = new System.Windows.Forms.Button();
            this.med = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.Button();
            this.flash = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flappybirdlogo = new System.Windows.Forms.PictureBox();
            this.PipeTop2 = new System.Windows.Forms.PictureBox();
            this.PipeBottom2 = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybirdlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            // 
            // endbox
            // 
            this.endbox.AutoSize = true;
            this.endbox.BackColor = System.Drawing.Color.Black;
            this.endbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endbox.Font = new System.Drawing.Font("Consolas", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endbox.ForeColor = System.Drawing.Color.DarkOrchid;
            this.endbox.Location = new System.Drawing.Point(-39, 183);
            this.endbox.Name = "endbox";
            this.endbox.Size = new System.Drawing.Size(2, 127);
            this.endbox.TabIndex = 7;
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.Blue;
            this.startbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.startbutton.FlatAppearance.BorderSize = 5;
            this.startbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Violet;
            this.startbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbutton.Font = new System.Drawing.Font("Georgia", 99.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startbutton.ForeColor = System.Drawing.Color.Yellow;
            this.startbutton.Location = new System.Drawing.Point(654, 565);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(587, 167);
            this.startbutton.TabIndex = 8;
            this.startbutton.Text = "START";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(217)))), ((int)(((byte)(150)))));
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.MediumBlue;
            this.countdown.Location = new System.Drawing.Point(962, 942);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(0, 54);
            this.countdown.TabIndex = 11;
            // 
            // playtimer
            // 
            this.playtimer.Enabled = true;
            this.playtimer.Interval = 1000;
            // 
            // gameovertimer
            // 
            this.gameovertimer.Enabled = true;
            this.gameovertimer.Interval = 500;
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.Color.Blue;
            this.hard.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.hard.FlatAppearance.BorderSize = 3;
            this.hard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.hard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hard.Font = new System.Drawing.Font("Lucida Console", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hard.ForeColor = System.Drawing.Color.Yellow;
            this.hard.Location = new System.Drawing.Point(843, 773);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(219, 57);
            this.hard.TabIndex = 15;
            this.hard.Text = "HARD";
            this.hard.UseVisualStyleBackColor = false;
            this.hard.Click += new System.EventHandler(this.hard_Click);
            // 
            // med
            // 
            this.med.BackColor = System.Drawing.Color.Blue;
            this.med.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.med.FlatAppearance.BorderSize = 3;
            this.med.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.med.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.med.Font = new System.Drawing.Font("Lucida Console", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med.ForeColor = System.Drawing.Color.Yellow;
            this.med.Location = new System.Drawing.Point(843, 693);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(219, 57);
            this.med.TabIndex = 16;
            this.med.Text = "MEDIUM";
            this.med.UseVisualStyleBackColor = false;
            this.med.Click += new System.EventHandler(this.med_Click);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.Color.Blue;
            this.easy.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.easy.FlatAppearance.BorderSize = 3;
            this.easy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.easy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.easy.Font = new System.Drawing.Font("Lucida Console", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easy.ForeColor = System.Drawing.Color.Yellow;
            this.easy.Location = new System.Drawing.Point(843, 606);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(219, 57);
            this.easy.TabIndex = 17;
            this.easy.Text = "EASY";
            this.easy.UseVisualStyleBackColor = false;
            this.easy.Click += new System.EventHandler(this.easy_Click);
            // 
            // flash
            // 
            this.flash.Enabled = true;
            this.flash.Interval = 500;
            this.flash.Tick += new System.EventHandler(this.flash_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlappyBird.Properties.Resources.clouds1;
            this.pictureBox1.Location = new System.Drawing.Point(230, 565);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // flappybirdlogo
            // 
            this.flappybirdlogo.Image = global::FlappyBird.Properties.Resources.pngfind_com_bird_png_image_2109009__1_;
            this.flappybirdlogo.Location = new System.Drawing.Point(322, 276);
            this.flappybirdlogo.Name = "flappybirdlogo";
            this.flappybirdlogo.Size = new System.Drawing.Size(1210, 283);
            this.flappybirdlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappybirdlogo.TabIndex = 13;
            this.flappybirdlogo.TabStop = false;
            // 
            // PipeTop2
            // 
            this.PipeTop2.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.PipeTop2.Location = new System.Drawing.Point(734, 0);
            this.PipeTop2.Name = "PipeTop2";
            this.PipeTop2.Size = new System.Drawing.Size(150, 275);
            this.PipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop2.TabIndex = 6;
            this.PipeTop2.TabStop = false;
            // 
            // PipeBottom2
            // 
            this.PipeBottom2.Image = global::FlappyBird.Properties.Resources.pipe;
            this.PipeBottom2.Location = new System.Drawing.Point(1694, 606);
            this.PipeBottom2.Name = "PipeBottom2";
            this.PipeBottom2.Size = new System.Drawing.Size(150, 275);
            this.PipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom2.TabIndex = 5;
            this.PipeBottom2.TabStop = false;
            // 
            // Bird
            // 
            this.Bird.Image = global::FlappyBird.Properties.Resources.birdgif;
            this.Bird.Location = new System.Drawing.Point(133, 290);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(165, 130);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 3;
            this.Bird.TabStop = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.Image = global::FlappyBird.Properties.Resources.pipe;
            this.PipeBottom.Location = new System.Drawing.Point(734, 606);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(150, 275);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 2;
            this.PipeBottom.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.PipeTop.Location = new System.Drawing.Point(1694, 0);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(150, 275);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 1;
            this.PipeTop.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.Ground.Location = new System.Drawing.Point(-1, 878);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1951, 195);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FlappyBird.Properties.Resources.clouds1;
            this.pictureBox2.Location = new System.Drawing.Point(1310, 565);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 244);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FlappyBird.Properties.Resources.cloud2;
            this.pictureBox3.Location = new System.Drawing.Point(1332, 44);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(356, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FlappyBird.Properties.Resources.cloud2;
            this.pictureBox4.Location = new System.Drawing.Point(372, 30);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(356, 240);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.flappybirdlogo);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.endbox);
            this.Controls.Add(this.PipeTop2);
            this.Controls.Add(this.PipeBottom2);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.med);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Name = "Form1";
            this.Text = " ";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybirdlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.PictureBox PipeBottom2;
        private System.Windows.Forms.PictureBox PipeTop2;
        private System.Windows.Forms.Label endbox;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Timer playtimer;
        private System.Windows.Forms.PictureBox flappybirdlogo;
        private System.Windows.Forms.Timer gameovertimer;
        private System.Windows.Forms.Button hard;
        private System.Windows.Forms.Button med;
        private System.Windows.Forms.Button easy;
        private System.Windows.Forms.Timer flash;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

