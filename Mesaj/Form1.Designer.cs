namespace Mesaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.msk_NUMARA = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_GİRİS_YAP = new System.Windows.Forms.Button();
            this.txt_SİFRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // msk_NUMARA
            // 
            this.msk_NUMARA.Location = new System.Drawing.Point(136, 32);
            this.msk_NUMARA.Mask = "0000";
            this.msk_NUMARA.Name = "msk_NUMARA";
            this.msk_NUMARA.Size = new System.Drawing.Size(332, 34);
            this.msk_NUMARA.TabIndex = 0;
            this.msk_NUMARA.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numara:";
            // 
            // btn_GİRİS_YAP
            // 
            this.btn_GİRİS_YAP.Location = new System.Drawing.Point(136, 143);
            this.btn_GİRİS_YAP.Name = "btn_GİRİS_YAP";
            this.btn_GİRİS_YAP.Size = new System.Drawing.Size(211, 41);
            this.btn_GİRİS_YAP.TabIndex = 2;
            this.btn_GİRİS_YAP.Text = "Giriş Yap";
            this.btn_GİRİS_YAP.UseVisualStyleBackColor = true;
            this.btn_GİRİS_YAP.Click += new System.EventHandler(this.btn_GİRİS_YAP_Click);
            // 
            // txt_SİFRE
            // 
            this.txt_SİFRE.Location = new System.Drawing.Point(136, 91);
            this.txt_SİFRE.Name = "txt_SİFRE";
            this.txt_SİFRE.Size = new System.Drawing.Size(332, 34);
            this.txt_SİFRE.TabIndex = 3;
            this.txt_SİFRE.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(61, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(602, 224);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_SİFRE);
            this.Controls.Add(this.btn_GİRİS_YAP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msk_NUMARA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "frm_GİRİŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox msk_NUMARA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GİRİS_YAP;
        private System.Windows.Forms.TextBox txt_SİFRE;
        private System.Windows.Forms.Label label2;
    }
}

