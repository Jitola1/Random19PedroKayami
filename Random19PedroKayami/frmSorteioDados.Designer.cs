namespace Random19PedroKayami
{
    partial class frmSorteioDados
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
            this.picDadojog1 = new System.Windows.Forms.PictureBox();
            this.picDadojog2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDadojog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadojog2)).BeginInit();
            this.SuspendLayout();
            // 
            // picDadojog1
            // 
            this.picDadojog1.Location = new System.Drawing.Point(74, 87);
            this.picDadojog1.Name = "picDadojog1";
            this.picDadojog1.Size = new System.Drawing.Size(126, 95);
            this.picDadojog1.TabIndex = 9;
            this.picDadojog1.TabStop = false;
            // 
            // picDadojog2
            // 
            this.picDadojog2.Location = new System.Drawing.Point(310, 87);
            this.picDadojog2.Name = "picDadojog2";
            this.picDadojog2.Size = new System.Drawing.Size(126, 95);
            this.picDadojog2.TabIndex = 10;
            this.picDadojog2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(242, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "X";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(206, 231);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(86, 56);
            this.btnJogar.TabIndex = 12;
            this.btnJogar.Text = "&Jogar Dados";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // frmSorteioDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picDadojog2);
            this.Controls.Add(this.picDadojog1);
            this.Name = "frmSorteioDados";
            this.Text = "frmSorteioDados";
            ((System.ComponentModel.ISupportInitialize)(this.picDadojog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDadojog2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDadojog1;
        private System.Windows.Forms.PictureBox picDadojog2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogar;
    }
}