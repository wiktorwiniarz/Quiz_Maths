namespace Quiz_Matematyczny
{
    partial class Dzielenie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dzielenie));
            this.StartDzielenie = new System.Windows.Forms.Button();
            this.iloraz = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.dividedRightLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dividedLeftLabel = new System.Windows.Forms.Label();
            this.iloraz1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dividedRightLabel1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dividedLeftLabel1 = new System.Windows.Forms.Label();
            this.iloraz2 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.dividedRightLabel2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dividedLeftLabel2 = new System.Windows.Forms.Label();
            this.iloraz3 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.dividedRightLabel3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dividedLeftLabel3 = new System.Windows.Forms.Label();
            this.iloraz4 = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.dividedRightLabel4 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dividedLeftLabel4 = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iloraz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz4)).BeginInit();
            this.SuspendLayout();
            // 
            // StartDzielenie
            // 
            this.StartDzielenie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartDzielenie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartDzielenie.Location = new System.Drawing.Point(180, 12);
            this.StartDzielenie.Name = "StartDzielenie";
            this.StartDzielenie.Size = new System.Drawing.Size(107, 36);
            this.StartDzielenie.TabIndex = 1;
            this.StartDzielenie.Text = "Start";
            this.StartDzielenie.UseVisualStyleBackColor = true;
            this.StartDzielenie.Click += new System.EventHandler(this.StartDzielenie_Click);
            // 
            // iloraz
            // 
            this.iloraz.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloraz.Location = new System.Drawing.Point(307, 77);
            this.iloraz.Name = "iloraz";
            this.iloraz.Size = new System.Drawing.Size(100, 35);
            this.iloraz.TabIndex = 2;
            this.iloraz.ValueChanged += new System.EventHandler(this.valueChanged);
            this.iloraz.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(241, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 15;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel
            // 
            this.dividedRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedRightLabel.Location = new System.Drawing.Point(175, 68);
            this.dividedRightLabel.Name = "dividedRightLabel";
            this.dividedRightLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel.TabIndex = 14;
            this.dividedRightLabel.Text = "?";
            this.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(109, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 13;
            this.label2.Text = "÷";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel
            // 
            this.dividedLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedLeftLabel.Location = new System.Drawing.Point(43, 68);
            this.dividedLeftLabel.Name = "dividedLeftLabel";
            this.dividedLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel.TabIndex = 12;
            this.dividedLeftLabel.Text = "?";
            this.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iloraz1
            // 
            this.iloraz1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloraz1.Location = new System.Drawing.Point(307, 127);
            this.iloraz1.Name = "iloraz1";
            this.iloraz1.Size = new System.Drawing.Size(100, 35);
            this.iloraz1.TabIndex = 3;
            this.iloraz1.ValueChanged += new System.EventHandler(this.valueChanged1);
            this.iloraz1.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(241, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 50);
            this.label1.TabIndex = 20;
            this.label1.Text = "=";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel1
            // 
            this.dividedRightLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedRightLabel1.Location = new System.Drawing.Point(175, 118);
            this.dividedRightLabel1.Name = "dividedRightLabel1";
            this.dividedRightLabel1.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel1.TabIndex = 19;
            this.dividedRightLabel1.Text = "?";
            this.dividedRightLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(109, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 18;
            this.label5.Text = "÷";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel1
            // 
            this.dividedLeftLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedLeftLabel1.Location = new System.Drawing.Point(43, 118);
            this.dividedLeftLabel1.Name = "dividedLeftLabel1";
            this.dividedLeftLabel1.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel1.TabIndex = 17;
            this.dividedLeftLabel1.Text = "?";
            this.dividedLeftLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iloraz2
            // 
            this.iloraz2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloraz2.Location = new System.Drawing.Point(307, 177);
            this.iloraz2.Name = "iloraz2";
            this.iloraz2.Size = new System.Drawing.Size(100, 35);
            this.iloraz2.TabIndex = 4;
            this.iloraz2.ValueChanged += new System.EventHandler(this.valueChanged2);
            this.iloraz2.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(241, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 25;
            this.label7.Text = "=";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel2
            // 
            this.dividedRightLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedRightLabel2.Location = new System.Drawing.Point(175, 168);
            this.dividedRightLabel2.Name = "dividedRightLabel2";
            this.dividedRightLabel2.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel2.TabIndex = 24;
            this.dividedRightLabel2.Text = "?";
            this.dividedRightLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(109, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 50);
            this.label9.TabIndex = 23;
            this.label9.Text = "÷";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel2
            // 
            this.dividedLeftLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedLeftLabel2.Location = new System.Drawing.Point(43, 168);
            this.dividedLeftLabel2.Name = "dividedLeftLabel2";
            this.dividedLeftLabel2.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel2.TabIndex = 22;
            this.dividedLeftLabel2.Text = "?";
            this.dividedLeftLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iloraz3
            // 
            this.iloraz3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloraz3.Location = new System.Drawing.Point(307, 227);
            this.iloraz3.Name = "iloraz3";
            this.iloraz3.Size = new System.Drawing.Size(100, 35);
            this.iloraz3.TabIndex = 5;
            this.iloraz3.ValueChanged += new System.EventHandler(this.valueChanged3);
            this.iloraz3.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(241, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 30;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel3
            // 
            this.dividedRightLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedRightLabel3.Location = new System.Drawing.Point(175, 218);
            this.dividedRightLabel3.Name = "dividedRightLabel3";
            this.dividedRightLabel3.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel3.TabIndex = 29;
            this.dividedRightLabel3.Text = "?";
            this.dividedRightLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(109, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 50);
            this.label13.TabIndex = 28;
            this.label13.Text = "÷";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel3
            // 
            this.dividedLeftLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedLeftLabel3.Location = new System.Drawing.Point(43, 218);
            this.dividedLeftLabel3.Name = "dividedLeftLabel3";
            this.dividedLeftLabel3.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel3.TabIndex = 27;
            this.dividedLeftLabel3.Text = "?";
            this.dividedLeftLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iloraz4
            // 
            this.iloraz4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.iloraz4.Location = new System.Drawing.Point(307, 277);
            this.iloraz4.Name = "iloraz4";
            this.iloraz4.Size = new System.Drawing.Size(100, 35);
            this.iloraz4.TabIndex = 6;
            this.iloraz4.ValueChanged += new System.EventHandler(this.valueChanged4);
            this.iloraz4.Enter += new System.EventHandler(this.answer_Enter);
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(241, 268);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 50);
            this.label15.TabIndex = 35;
            this.label15.Text = "=";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedRightLabel4
            // 
            this.dividedRightLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedRightLabel4.Location = new System.Drawing.Point(175, 268);
            this.dividedRightLabel4.Name = "dividedRightLabel4";
            this.dividedRightLabel4.Size = new System.Drawing.Size(60, 50);
            this.dividedRightLabel4.TabIndex = 34;
            this.dividedRightLabel4.Text = "?";
            this.dividedRightLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(109, 268);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 50);
            this.label17.TabIndex = 33;
            this.label17.Text = "÷";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dividedLeftLabel4
            // 
            this.dividedLeftLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dividedLeftLabel4.Location = new System.Drawing.Point(43, 268);
            this.dividedLeftLabel4.Name = "dividedLeftLabel4";
            this.dividedLeftLabel4.Size = new System.Drawing.Size(60, 50);
            this.dividedLeftLabel4.TabIndex = 32;
            this.dividedLeftLabel4.Text = "?";
            this.dividedLeftLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // time
            // 
            this.time.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.time.Location = new System.Drawing.Point(180, 325);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(141, 27);
            this.time.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(123, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 40;
            this.label3.Text = "Czas";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Dzielenie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.iloraz4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dividedRightLabel4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dividedLeftLabel4);
            this.Controls.Add(this.iloraz3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dividedRightLabel3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dividedLeftLabel3);
            this.Controls.Add(this.iloraz2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dividedRightLabel2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dividedLeftLabel2);
            this.Controls.Add(this.iloraz1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dividedRightLabel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dividedLeftLabel1);
            this.Controls.Add(this.iloraz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dividedRightLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dividedLeftLabel);
            this.Controls.Add(this.StartDzielenie);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dzielenie";
            this.Text = "Dzielenie";
            ((System.ComponentModel.ISupportInitialize)(this.iloraz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iloraz4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartDzielenie;
        private System.Windows.Forms.NumericUpDown iloraz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dividedRightLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dividedLeftLabel;
        private System.Windows.Forms.NumericUpDown iloraz1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dividedRightLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label dividedLeftLabel1;
        private System.Windows.Forms.NumericUpDown iloraz2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dividedRightLabel2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label dividedLeftLabel2;
        private System.Windows.Forms.NumericUpDown iloraz3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label dividedRightLabel3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label dividedLeftLabel3;
        private System.Windows.Forms.NumericUpDown iloraz4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label dividedRightLabel4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label dividedLeftLabel4;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}