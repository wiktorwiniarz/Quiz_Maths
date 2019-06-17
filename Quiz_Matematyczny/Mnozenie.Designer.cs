namespace Quiz_Matematyczny
{
    partial class Mnozenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mnozenie));
            this.StartMnozenie = new System.Windows.Forms.Button();
            this.iloczyn = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.timesRightLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timesLeftLabel = new System.Windows.Forms.Label();
            this.iloczyn1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timesRightLabel1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timesLeftLabel1 = new System.Windows.Forms.Label();
            this.iloczyn2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.timesRightLabel2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timesLeftLabel2 = new System.Windows.Forms.Label();
            this.iloczyn3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.timesRightLabel3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timesLeftLabel3 = new System.Windows.Forms.Label();
            this.iloczyn4 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.timesRightLabel4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.timesLeftLabel4 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartMnozenie
            // 
            this.StartMnozenie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartMnozenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartMnozenie.Location = new System.Drawing.Point(180, 12);
            this.StartMnozenie.Name = "StartMnozenie";
            this.StartMnozenie.Size = new System.Drawing.Size(107, 36);
            this.StartMnozenie.TabIndex = 1;
            this.StartMnozenie.Text = "Start";
            this.StartMnozenie.UseVisualStyleBackColor = true;
            this.StartMnozenie.Click += new System.EventHandler(this.StartMnozenie_Click);
            // 
            // iloczyn
            // 
            this.iloczyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloczyn.Location = new System.Drawing.Point(307, 80);
            this.iloczyn.Name = "iloczyn";
            this.iloczyn.Size = new System.Drawing.Size(100, 35);
            this.iloczyn.TabIndex = 2;
            this.iloczyn.ValueChanged += new System.EventHandler(this.valueChanged);
            this.iloczyn.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(241, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 15;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel
            // 
            this.timesRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesRightLabel.Location = new System.Drawing.Point(175, 71);
            this.timesRightLabel.Name = "timesRightLabel";
            this.timesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel.TabIndex = 14;
            this.timesRightLabel.Text = "?";
            this.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(109, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 13;
            this.label2.Text = "x";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel
            // 
            this.timesLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesLeftLabel.Location = new System.Drawing.Point(43, 71);
            this.timesLeftLabel.Name = "timesLeftLabel";
            this.timesLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel.TabIndex = 12;
            this.timesLeftLabel.Text = "?";
            this.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iloczyn1
            // 
            this.iloczyn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloczyn1.Location = new System.Drawing.Point(307, 130);
            this.iloczyn1.Name = "iloczyn1";
            this.iloczyn1.Size = new System.Drawing.Size(100, 35);
            this.iloczyn1.TabIndex = 3;
            this.iloczyn1.ValueChanged += new System.EventHandler(this.valueChanged1);
            this.iloczyn1.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(241, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 50);
            this.label1.TabIndex = 20;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel1
            // 
            this.timesRightLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesRightLabel1.Location = new System.Drawing.Point(175, 121);
            this.timesRightLabel1.Name = "timesRightLabel1";
            this.timesRightLabel1.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel1.TabIndex = 19;
            this.timesRightLabel1.Text = "?";
            this.timesRightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(109, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 18;
            this.label5.Text = "x";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel1
            // 
            this.timesLeftLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesLeftLabel1.Location = new System.Drawing.Point(43, 121);
            this.timesLeftLabel1.Name = "timesLeftLabel1";
            this.timesLeftLabel1.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel1.TabIndex = 17;
            this.timesLeftLabel1.Text = "?";
            this.timesLeftLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iloczyn2
            // 
            this.iloczyn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloczyn2.Location = new System.Drawing.Point(307, 180);
            this.iloczyn2.Name = "iloczyn2";
            this.iloczyn2.Size = new System.Drawing.Size(100, 35);
            this.iloczyn2.TabIndex = 4;
            this.iloczyn2.ValueChanged += new System.EventHandler(this.valueChanged2);
            this.iloczyn2.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(241, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 25;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel2
            // 
            this.timesRightLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesRightLabel2.Location = new System.Drawing.Point(175, 171);
            this.timesRightLabel2.Name = "timesRightLabel2";
            this.timesRightLabel2.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel2.TabIndex = 24;
            this.timesRightLabel2.Text = "?";
            this.timesRightLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(109, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 23;
            this.label9.Text = "x";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel2
            // 
            this.timesLeftLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesLeftLabel2.Location = new System.Drawing.Point(43, 171);
            this.timesLeftLabel2.Name = "timesLeftLabel2";
            this.timesLeftLabel2.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel2.TabIndex = 22;
            this.timesLeftLabel2.Text = "?";
            this.timesLeftLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iloczyn3
            // 
            this.iloczyn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloczyn3.Location = new System.Drawing.Point(307, 230);
            this.iloczyn3.Name = "iloczyn3";
            this.iloczyn3.Size = new System.Drawing.Size(100, 35);
            this.iloczyn3.TabIndex = 5;
            this.iloczyn3.ValueChanged += new System.EventHandler(this.valueChanged3);
            this.iloczyn3.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(241, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 30;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel3
            // 
            this.timesRightLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesRightLabel3.Location = new System.Drawing.Point(175, 221);
            this.timesRightLabel3.Name = "timesRightLabel3";
            this.timesRightLabel3.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel3.TabIndex = 29;
            this.timesRightLabel3.Text = "?";
            this.timesRightLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(109, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 28;
            this.label13.Text = "x";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel3
            // 
            this.timesLeftLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesLeftLabel3.Location = new System.Drawing.Point(43, 221);
            this.timesLeftLabel3.Name = "timesLeftLabel3";
            this.timesLeftLabel3.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel3.TabIndex = 27;
            this.timesLeftLabel3.Text = "?";
            this.timesLeftLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iloczyn4
            // 
            this.iloczyn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloczyn4.Location = new System.Drawing.Point(307, 280);
            this.iloczyn4.Name = "iloczyn4";
            this.iloczyn4.Size = new System.Drawing.Size(100, 35);
            this.iloczyn4.TabIndex = 6;
            this.iloczyn4.ValueChanged += new System.EventHandler(this.valueChanged4);
            this.iloczyn4.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(241, 271);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 35;
            this.label15.Text = "=";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesRightLabel4
            // 
            this.timesRightLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesRightLabel4.Location = new System.Drawing.Point(175, 271);
            this.timesRightLabel4.Name = "timesRightLabel4";
            this.timesRightLabel4.Size = new System.Drawing.Size(60, 50);
            this.timesRightLabel4.TabIndex = 34;
            this.timesRightLabel4.Text = "?";
            this.timesRightLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(109, 271);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 50);
            this.label17.TabIndex = 33;
            this.label17.Text = "x";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timesLeftLabel4
            // 
            this.timesLeftLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.timesLeftLabel4.Location = new System.Drawing.Point(43, 271);
            this.timesLeftLabel4.Name = "timesLeftLabel4";
            this.timesLeftLabel4.Size = new System.Drawing.Size(60, 50);
            this.timesLeftLabel4.TabIndex = 32;
            this.timesLeftLabel4.Text = "?";
            this.timesLeftLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time.Location = new System.Drawing.Point(180, 325);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(141, 27);
            this.time.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(123, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Czas";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(424, 280);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.TabIndex = 51;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Location = new System.Drawing.Point(424, 230);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.TabIndex = 50;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(424, 180);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.TabIndex = 49;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(424, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(424, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // Mnozenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iloczyn4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.timesRightLabel4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.timesLeftLabel4);
            this.Controls.Add(this.iloczyn3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.timesRightLabel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.timesLeftLabel3);
            this.Controls.Add(this.iloczyn2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.timesRightLabel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.timesLeftLabel2);
            this.Controls.Add(this.iloczyn1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timesRightLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timesLeftLabel1);
            this.Controls.Add(this.iloczyn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.timesRightLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timesLeftLabel);
            this.Controls.Add(this.StartMnozenie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mnozenie";
            this.Text = "Mnozenie";
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloczyn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartMnozenie;
        private System.Windows.Forms.NumericUpDown iloczyn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timesRightLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label timesLeftLabel;
        private System.Windows.Forms.NumericUpDown iloczyn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timesRightLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label timesLeftLabel1;
        private System.Windows.Forms.NumericUpDown iloczyn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label timesRightLabel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label timesLeftLabel2;
        private System.Windows.Forms.NumericUpDown iloczyn3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label timesRightLabel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label timesLeftLabel3;
        private System.Windows.Forms.NumericUpDown iloczyn4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label timesRightLabel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label timesLeftLabel4;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}