namespace FlappyBird.Properties
{
    partial class Form4
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
            this.gameovertimer = new System.Windows.Forms.Timer(this.components);
            this.playtimer = new System.Windows.Forms.Timer(this.components);
            this.countdown = new System.Windows.Forms.Label();
            this.endbox = new System.Windows.Forms.Label();
            this.scoreBox = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.pause = new System.Windows.Forms.PictureBox();
            this.PipeTop2 = new System.Windows.Forms.PictureBox();
            this.PipeBottom2 = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            this.Bird = new System.Windows.Forms.PictureBox();
            this.PipeBottom = new System.Windows.Forms.PictureBox();
            this.PipeTop = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.endgamepic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endgamepic)).BeginInit();
            this.SuspendLayout();
            // 
            // gameovertimer
            // 
            this.gameovertimer.Enabled = true;
            this.gameovertimer.Interval = 500;
            this.gameovertimer.Tick += new System.EventHandler(this.gameovertimer_Tick);
            // 
            // playtimer
            // 
            this.playtimer.Enabled = true;
            this.playtimer.Interval = 1000;
            this.playtimer.Tick += new System.EventHandler(this.playtimer_Tick);
            // 
            // countdown
            // 
            this.countdown.AutoSize = true;
            this.countdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(217)))), ((int)(((byte)(150)))));
            this.countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown.ForeColor = System.Drawing.Color.MediumBlue;
            this.countdown.Location = new System.Drawing.Point(959, 926);
            this.countdown.Name = "countdown";
            this.countdown.Size = new System.Drawing.Size(0, 54);
            this.countdown.TabIndex = 39;
            // 
            // endbox
            // 
            this.endbox.AutoSize = true;
            this.endbox.BackColor = System.Drawing.Color.Black;
            this.endbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endbox.Font = new System.Drawing.Font("Consolas", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endbox.ForeColor = System.Drawing.Color.DarkOrchid;
            this.endbox.Location = new System.Drawing.Point(-42, 167);
            this.endbox.Name = "endbox";
            this.endbox.Size = new System.Drawing.Size(2, 127);
            this.endbox.TabIndex = 36;
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.BackColor = System.Drawing.Color.MediumOrchid;
            this.scoreBox.Font = new System.Drawing.Font("Candara", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreBox.ForeColor = System.Drawing.Color.White;
            this.scoreBox.Location = new System.Drawing.Point(33, 926);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(176, 58);
            this.scoreBox.TabIndex = 33;
            this.scoreBox.Text = "Score:0";
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.Transparent;
            this.pause.Image = global::FlappyBird.Properties.Resources.pause;
            this.pause.Location = new System.Drawing.Point(9, 12);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(129, 120);
            this.pause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pause.TabIndex = 38;
            this.pause.TabStop = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // PipeTop2
            // 
            this.PipeTop2.Image = global::FlappyBird.Properties.Resources.purpledonw;
            this.PipeTop2.Location = new System.Drawing.Point(731, -16);
            this.PipeTop2.Name = "PipeTop2";
            this.PipeTop2.Size = new System.Drawing.Size(150, 275);
            this.PipeTop2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop2.TabIndex = 35;
            this.PipeTop2.TabStop = false;
            // 
            // PipeBottom2
            // 
            this.PipeBottom2.Image = global::FlappyBird.Properties.Resources.purple;
            this.PipeBottom2.Location = new System.Drawing.Point(1691, 590);
            this.PipeBottom2.Name = "PipeBottom2";
            this.PipeBottom2.Size = new System.Drawing.Size(150, 275);
            this.PipeBottom2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom2.TabIndex = 34;
            this.PipeBottom2.TabStop = false;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Location = new System.Drawing.Point(9, 12);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(129, 120);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.play.TabIndex = 40;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // Bird
            // 
            this.Bird.Image = global::FlappyBird.Properties.Resources.birdgif;
            this.Bird.Location = new System.Drawing.Point(130, 274);
            this.Bird.Name = "Bird";
            this.Bird.Size = new System.Drawing.Size(165, 130);
            this.Bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bird.TabIndex = 32;
            this.Bird.TabStop = false;
            // 
            // PipeBottom
            // 
            this.PipeBottom.Image = global::FlappyBird.Properties.Resources.purple;
            this.PipeBottom.Location = new System.Drawing.Point(731, 590);
            this.PipeBottom.Name = "PipeBottom";
            this.PipeBottom.Size = new System.Drawing.Size(150, 275);
            this.PipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeBottom.TabIndex = 31;
            this.PipeBottom.TabStop = false;
            // 
            // PipeTop
            // 
            this.PipeTop.Image = global::FlappyBird.Properties.Resources.purpledonw;
            this.PipeTop.Location = new System.Drawing.Point(1691, -16);
            this.PipeTop.Name = "PipeTop";
            this.PipeTop.Size = new System.Drawing.Size(150, 275);
            this.PipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PipeTop.TabIndex = 30;
            this.PipeTop.TabStop = false;
            // 
            // Ground
            // 
            this.Ground.Image = global::FlappyBird.Properties.Resources.purpleGround;
            this.Ground.Location = new System.Drawing.Point(-4, 862);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(1951, 235);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 29;
            this.Ground.TabStop = false;
            // 
            // endgamepic
            // 
            this.endgamepic.Location = new System.Drawing.Point(-3, -16);
            this.endgamepic.Name = "endgamepic";
            this.endgamepic.Size = new System.Drawing.Size(1920, 885);
            this.endgamepic.TabIndex = 42;
            this.endgamepic.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.PipeTop2);
            this.Controls.Add(this.PipeBottom2);
            this.Controls.Add(this.play);
            this.Controls.Add(this.Bird);
            this.Controls.Add(this.PipeBottom);
            this.Controls.Add(this.countdown);
            this.Controls.Add(this.endbox);
            this.Controls.Add(this.scoreBox);
            this.Controls.Add(this.PipeTop);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.endgamepic);
            this.Name = "Form4";
            this.Text = "Form4";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form4_PressKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endgamepic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameovertimer;
        private System.Windows.Forms.PictureBox pause;
        private System.Windows.Forms.PictureBox PipeTop2;
        private System.Windows.Forms.PictureBox PipeBottom2;
        private System.Windows.Forms.PictureBox play;
        private System.Windows.Forms.PictureBox Bird;
        private System.Windows.Forms.PictureBox PipeBottom;
        private System.Windows.Forms.Timer playtimer;
        private System.Windows.Forms.Label countdown;
        private System.Windows.Forms.Label endbox;
        private System.Windows.Forms.Label scoreBox;
        private System.Windows.Forms.PictureBox PipeTop;
        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox endgamepic;
        private System.Windows.Forms.Timer GameTimer;
    }
}