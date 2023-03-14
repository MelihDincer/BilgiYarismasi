
namespace BilgiYarismasi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            richTextBox1 = new System.Windows.Forms.RichTextBox();
            BtnA = new System.Windows.Forms.Button();
            BtnB = new System.Windows.Forms.Button();
            BtnC = new System.Windows.Forms.Button();
            BtnD = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            LblSoruNo = new System.Windows.Forms.Label();
            LblDogru = new System.Windows.Forms.Label();
            LblYanlis = new System.Windows.Forms.Label();
            BtnSonraki = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            richTextBox1.Location = new System.Drawing.Point(69, 48);
            richTextBox1.Margin = new System.Windows.Forms.Padding(5);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(577, 233);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // BtnA
            // 
            BtnA.Location = new System.Drawing.Point(69, 300);
            BtnA.Name = "BtnA";
            BtnA.Size = new System.Drawing.Size(282, 56);
            BtnA.TabIndex = 1;
            BtnA.Text = "A";
            BtnA.UseVisualStyleBackColor = true;
            BtnA.Click += BtnA_Click;
            // 
            // BtnB
            // 
            BtnB.Location = new System.Drawing.Point(357, 300);
            BtnB.Name = "BtnB";
            BtnB.Size = new System.Drawing.Size(289, 55);
            BtnB.TabIndex = 2;
            BtnB.Text = "B";
            BtnB.UseVisualStyleBackColor = true;
            BtnB.Click += BtnB_Click;
            // 
            // BtnC
            // 
            BtnC.Location = new System.Drawing.Point(69, 385);
            BtnC.Name = "BtnC";
            BtnC.Size = new System.Drawing.Size(282, 56);
            BtnC.TabIndex = 3;
            BtnC.Text = "C";
            BtnC.UseVisualStyleBackColor = true;
            BtnC.Click += BtnC_Click;
            // 
            // BtnD
            // 
            BtnD.Location = new System.Drawing.Point(357, 385);
            BtnD.Name = "BtnD";
            BtnD.Size = new System.Drawing.Size(289, 56);
            BtnD.TabIndex = 4;
            BtnD.Text = "D";
            BtnD.UseVisualStyleBackColor = true;
            BtnD.Click += BtnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(730, 51);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 25);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(746, 110);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(69, 25);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(751, 175);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 25);
            label3.TabIndex = 7;
            label3.Text = "Yanlış:";
            // 
            // LblSoruNo
            // 
            LblSoruNo.AutoSize = true;
            LblSoruNo.Location = new System.Drawing.Point(870, 51);
            LblSoruNo.Name = "LblSoruNo";
            LblSoruNo.Size = new System.Drawing.Size(22, 25);
            LblSoruNo.TabIndex = 8;
            LblSoruNo.Text = "0";
            // 
            // LblDogru
            // 
            LblDogru.AutoSize = true;
            LblDogru.Location = new System.Drawing.Point(870, 110);
            LblDogru.Name = "LblDogru";
            LblDogru.Size = new System.Drawing.Size(22, 25);
            LblDogru.TabIndex = 9;
            LblDogru.Text = "0";
            // 
            // LblYanlis
            // 
            LblYanlis.AutoSize = true;
            LblYanlis.Location = new System.Drawing.Point(870, 175);
            LblYanlis.Name = "LblYanlis";
            LblYanlis.Size = new System.Drawing.Size(22, 25);
            LblYanlis.TabIndex = 10;
            LblYanlis.Text = "0";
            // 
            // BtnSonraki
            // 
            BtnSonraki.Location = new System.Drawing.Point(710, 218);
            BtnSonraki.Name = "BtnSonraki";
            BtnSonraki.Size = new System.Drawing.Size(267, 55);
            BtnSonraki.TabIndex = 11;
            BtnSonraki.Text = "Sonraki";
            BtnSonraki.UseVisualStyleBackColor = true;
            BtnSonraki.Click += BtnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(705, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(136, 140);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(847, 300);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(139, 140);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(730, 501);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 25);
            label4.TabIndex = 14;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(860, 501);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(63, 25);
            label5.TabIndex = 15;
            label5.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaption;
            ClientSize = new System.Drawing.Size(993, 451);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSonraki);
            Controls.Add(LblYanlis);
            Controls.Add(LblDogru);
            Controls.Add(LblSoruNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnD);
            Controls.Add(BtnC);
            Controls.Add(BtnB);
            Controls.Add(BtnA);
            Controls.Add(richTextBox1);
            Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "Form1";
            Text = "BilgiYarismasi";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnC;
        private System.Windows.Forms.Button BtnD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSoruNo;
        private System.Windows.Forms.Label LblDogru;
        private System.Windows.Forms.Label LblYanlis;
        private System.Windows.Forms.Button BtnSonraki;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

