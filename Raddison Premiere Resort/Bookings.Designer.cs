namespace Raddison_Premiere_Resort
{
    partial class Bookings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bookings));
            this.label3 = new System.Windows.Forms.Label();
            this.cmdNew = new System.Windows.Forms.Button();
            this.cmdCurrent = new System.Windows.Forms.Button();
            this.cmdChange = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdlogout = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(90, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome to Raddison Premiere Resort\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdNew
            // 
            this.cmdNew.Location = new System.Drawing.Point(22, 19);
            this.cmdNew.Name = "cmdNew";
            this.cmdNew.Size = new System.Drawing.Size(154, 30);
            this.cmdNew.TabIndex = 3;
            this.cmdNew.Text = "NEW BOOKING";
            this.cmdNew.UseVisualStyleBackColor = true;
            this.cmdNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdCurrent
            // 
            this.cmdCurrent.Location = new System.Drawing.Point(182, 19);
            this.cmdCurrent.Name = "cmdCurrent";
            this.cmdCurrent.Size = new System.Drawing.Size(154, 28);
            this.cmdCurrent.TabIndex = 4;
            this.cmdCurrent.Text = "CURRENT BOOKINGS";
            this.cmdCurrent.UseVisualStyleBackColor = true;
            this.cmdCurrent.Click += new System.EventHandler(this.cmdCurrent_Click);
            // 
            // cmdChange
            // 
            this.cmdChange.Location = new System.Drawing.Point(22, 55);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(154, 30);
            this.cmdChange.TabIndex = 5;
            this.cmdChange.Text = "CHANGE BOOKING";
            this.cmdChange.UseVisualStyleBackColor = true;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(182, 55);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(154, 30);
            this.cmdDelete.TabIndex = 6;
            this.cmdDelete.Text = "DELETE BOOKING";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 195);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdDelete);
            this.groupBox2.Controls.Add(this.cmdNew);
            this.groupBox2.Controls.Add(this.cmdChange);
            this.groupBox2.Controls.Add(this.cmdCurrent);
            this.groupBox2.Location = new System.Drawing.Point(289, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(359, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // cmdlogout
            // 
            this.cmdlogout.Location = new System.Drawing.Point(782, 12);
            this.cmdlogout.Name = "cmdlogout";
            this.cmdlogout.Size = new System.Drawing.Size(75, 23);
            this.cmdlogout.TabIndex = 9;
            this.cmdlogout.Text = "LOG OUT";
            this.cmdlogout.UseVisualStyleBackColor = true;
            this.cmdlogout.Click += new System.EventHandler(this.cmdlogout_Click);
            // 
            // Bookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 450);
            this.Controls.Add(this.cmdlogout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bookings";
            this.Text = "Welcome";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdNew;
        private System.Windows.Forms.Button cmdCurrent;
        private System.Windows.Forms.Button cmdChange;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdlogout;
    }
}