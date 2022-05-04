namespace Random19PedroKayami
{
    partial class frmSorteio
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCorform = new System.Windows.Forms.Button();
            this.lblValor1 = new System.Windows.Forms.Label();
            this.lblValor2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnCena = new System.Windows.Forms.Button();
            this.lblMega = new System.Windows.Forms.Label();
            this.picFotoJ1 = new System.Windows.Forms.PictureBox();
            this.btnCarregarFoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJ1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCorform
            // 
            this.btnCorform.Location = new System.Drawing.Point(567, 12);
            this.btnCorform.Name = "btnCorform";
            this.btnCorform.Size = new System.Drawing.Size(75, 23);
            this.btnCorform.TabIndex = 0;
            this.btnCorform.Text = "Cor";
            this.btnCorform.UseVisualStyleBackColor = true;
            this.btnCorform.Click += new System.EventHandler(this.btnCorform_Click);
            // 
            // lblValor1
            // 
            this.lblValor1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblValor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor1.Location = new System.Drawing.Point(173, 135);
            this.lblValor1.Name = "lblValor1";
            this.lblValor1.Size = new System.Drawing.Size(104, 68);
            this.lblValor1.TabIndex = 1;
            this.lblValor1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValor2
            // 
            this.lblValor2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblValor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValor2.Location = new System.Drawing.Point(362, 135);
            this.lblValor2.Name = "lblValor2";
            this.lblValor2.Size = new System.Drawing.Size(104, 68);
            this.lblValor2.TabIndex = 3;
            this.lblValor2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(309, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "X";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(277, 266);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(86, 56);
            this.btnJogar.TabIndex = 5;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnCena
            // 
            this.btnCena.Location = new System.Drawing.Point(472, 364);
            this.btnCena.Name = "btnCena";
            this.btnCena.Size = new System.Drawing.Size(75, 23);
            this.btnCena.TabIndex = 6;
            this.btnCena.Text = "Mega Cena";
            this.btnCena.UseVisualStyleBackColor = true;
            this.btnCena.Click += new System.EventHandler(this.btnCena_Click);
            // 
            // lblMega
            // 
            this.lblMega.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblMega.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMega.Location = new System.Drawing.Point(143, 364);
            this.lblMega.Name = "lblMega";
            this.lblMega.Size = new System.Drawing.Size(323, 43);
            this.lblMega.TabIndex = 7;
            this.lblMega.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picFotoJ1
            // 
            this.picFotoJ1.Location = new System.Drawing.Point(12, 12);
            this.picFotoJ1.Name = "picFotoJ1";
            this.picFotoJ1.Size = new System.Drawing.Size(126, 95);
            this.picFotoJ1.TabIndex = 8;
            this.picFotoJ1.TabStop = false;
            // 
            // btnCarregarFoto
            // 
            this.btnCarregarFoto.Location = new System.Drawing.Point(12, 113);
            this.btnCarregarFoto.Name = "btnCarregarFoto";
            this.btnCarregarFoto.Size = new System.Drawing.Size(126, 23);
            this.btnCarregarFoto.TabIndex = 9;
            this.btnCarregarFoto.Text = "Carregar Foto";
            this.btnCarregarFoto.UseVisualStyleBackColor = true;
            this.btnCarregarFoto.Click += new System.EventHandler(this.btnCarregarFoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmSorteio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(645, 434);
            this.Controls.Add(this.btnCarregarFoto);
            this.Controls.Add(this.picFotoJ1);
            this.Controls.Add(this.lblMega);
            this.Controls.Add(this.btnCena);
            this.Controls.Add(this.btnJogar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblValor2);
            this.Controls.Add(this.lblValor1);
            this.Controls.Add(this.btnCorform);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSorteio";
            this.Text = "Sorteio de Números";
            ((System.ComponentModel.ISupportInitialize)(this.picFotoJ1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCorform;
        private System.Windows.Forms.Label lblValor1;
        private System.Windows.Forms.Label lblValor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnCena;
        private System.Windows.Forms.Label lblMega;
        private System.Windows.Forms.PictureBox picFotoJ1;
        private System.Windows.Forms.Button btnCarregarFoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

