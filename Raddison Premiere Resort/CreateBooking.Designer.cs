namespace Raddison_Premiere_Resort
{
    partial class CreateBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateBooking));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpCheckin = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optExecutive = new System.Windows.Forms.RadioButton();
            this.optPremium = new System.Windows.Forms.RadioButton();
            this.optStandard = new System.Windows.Forms.RadioButton();
            this.cmdProceed = new System.Windows.Forms.Button();
            this.cmdBack = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtduration = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PHONE NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADDRESS";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(163, 20);
            this.txtName.TabIndex = 4;
            // 
            // txtnumber
            // 
            this.txtnumber.Location = new System.Drawing.Point(115, 61);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.Size = new System.Drawing.Size(163, 20);
            this.txtnumber.TabIndex = 6;
            this.txtnumber.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(115, 85);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(163, 20);
            this.txtaddress.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(338, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Check in date ";
            // 
            // dtpCheckin
            // 
            this.dtpCheckin.Location = new System.Drawing.Point(341, 40);
            this.dtpCheckin.Name = "dtpCheckin";
            this.dtpCheckin.Size = new System.Drawing.Size(200, 20);
            this.dtpCheckin.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optExecutive);
            this.groupBox1.Controls.Add(this.optPremium);
            this.groupBox1.Controls.Add(this.optStandard);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 172);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rooms";
            // 
            // optExecutive
            // 
            this.optExecutive.AutoSize = true;
            this.optExecutive.Location = new System.Drawing.Point(25, 112);
            this.optExecutive.Name = "optExecutive";
            this.optExecutive.Size = new System.Drawing.Size(579, 34);
            this.optExecutive.TabIndex = 2;
            this.optExecutive.TabStop = true;
            this.optExecutive.Text = "Executive room - 2 King size beds, all meals included, fully furnished, free acce" +
    "ss to conference rooms\r\n£100 per night \r\n";
            this.optExecutive.UseVisualStyleBackColor = true;
            // 
            // optPremium
            // 
            this.optPremium.AutoSize = true;
            this.optPremium.Location = new System.Drawing.Point(25, 72);
            this.optPremium.Name = "optPremium";
            this.optPremium.Size = new System.Drawing.Size(523, 49);
            this.optPremium.TabIndex = 1;
            this.optPremium.TabStop = true;
            this.optPremium.Text = "Premium Suite - 5 King size beds, fully furnished, all meals included, private sw" +
    "imming pool\r\n£200 per night \r\n\r\n";
            this.optPremium.UseVisualStyleBackColor = true;
            // 
            // optStandard
            // 
            this.optStandard.AutoSize = true;
            this.optStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optStandard.Location = new System.Drawing.Point(25, 32);
            this.optStandard.Name = "optStandard";
            this.optStandard.Size = new System.Drawing.Size(319, 49);
            this.optStandard.TabIndex = 0;
            this.optStandard.TabStop = true;
            this.optStandard.Text = "Standard Room - 2 King size beds, Breakfast included\r\n£85 per night\r\n\r\n";
            this.optStandard.UseVisualStyleBackColor = true;
            // 
            // cmdProceed
            // 
            this.cmdProceed.Location = new System.Drawing.Point(546, 373);
            this.cmdProceed.Name = "cmdProceed";
            this.cmdProceed.Size = new System.Drawing.Size(75, 23);
            this.cmdProceed.TabIndex = 13;
            this.cmdProceed.Text = "Proceed";
            this.cmdProceed.UseVisualStyleBackColor = true;
            this.cmdProceed.Click += new System.EventHandler(this.cmdProceed_Click);
            // 
            // cmdBack
            // 
            this.cmdBack.Location = new System.Drawing.Point(18, 373);
            this.cmdBack.Name = "cmdBack";
            this.cmdBack.Size = new System.Drawing.Size(75, 23);
            this.cmdBack.TabIndex = 14;
            this.cmdBack.Text = "Back";
            this.cmdBack.UseVisualStyleBackColor = true;
            this.cmdBack.Click += new System.EventHandler(this.cmdBack_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtduration);
            this.groupBox2.Controls.Add(this.cmdBack);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmdProceed);
            this.groupBox2.Controls.Add(this.txtaddress);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.txtnumber);
            this.groupBox2.Controls.Add(this.dtpCheckin);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(138, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 415);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(338, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Duration";
            // 
            // txtduration
            // 
            this.txtduration.Location = new System.Drawing.Point(340, 85);
            this.txtduration.Name = "txtduration";
            this.txtduration.Size = new System.Drawing.Size(100, 20);
            this.txtduration.TabIndex = 15;
            this.txtduration.TextChanged += new System.EventHandler(this.txtduration_TextChanged);
            // 
            // CreateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(916, 508);
            this.Controls.Add(this.groupBox2);
            this.Name = "CreateBooking";
            this.Text = "CreateBooking";
            this.Load += new System.EventHandler(this.CreateBooking_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpCheckin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optExecutive;
        private System.Windows.Forms.RadioButton optPremium;
        private System.Windows.Forms.RadioButton optStandard;
        private System.Windows.Forms.Button cmdProceed;
        private System.Windows.Forms.Button cmdBack;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtduration;
    }
}