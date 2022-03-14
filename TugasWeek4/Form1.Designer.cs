namespace TugasWeek4
{
    partial class FormPenambahanData
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
            this.lblNama = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblTelp = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.btnSImpan = new System.Windows.Forms.Button();
            this.btnLihat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(35, 40);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(42, 15);
            this.lblNama.TabIndex = 0;
            this.lblNama.Text = "Nama:";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(35, 70);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(48, 15);
            this.lblAlamat.TabIndex = 1;
            this.lblAlamat.Text = "Alamat:";
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(35, 100);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(31, 15);
            this.lblTelp.TabIndex = 2;
            this.lblTelp.Text = "Telp:";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(115, 32);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderText = "<data kosong>";
            this.txtNama.Size = new System.Drawing.Size(350, 23);
            this.txtNama.TabIndex = 3;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(115, 62);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.PlaceholderText = "<data kosong>";
            this.txtAlamat.Size = new System.Drawing.Size(500, 23);
            this.txtAlamat.TabIndex = 4;
            // 
            // txtTelp
            // 
            this.txtTelp.Location = new System.Drawing.Point(115, 92);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.PlaceholderText = "<data kosong>";
            this.txtTelp.Size = new System.Drawing.Size(200, 23);
            this.txtTelp.TabIndex = 5;
            this.txtTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelp_KeyPress);
            // 
            // btnSImpan
            // 
            this.btnSImpan.Location = new System.Drawing.Point(35, 143);
            this.btnSImpan.Name = "btnSImpan";
            this.btnSImpan.Size = new System.Drawing.Size(75, 23);
            this.btnSImpan.TabIndex = 6;
            this.btnSImpan.Text = "Simpan";
            this.btnSImpan.UseVisualStyleBackColor = true;
            this.btnSImpan.Click += new System.EventHandler(this.btnSImpan_Click);
            // 
            // btnLihat
            // 
            this.btnLihat.Location = new System.Drawing.Point(116, 143);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Size = new System.Drawing.Size(75, 23);
            this.btnLihat.TabIndex = 7;
            this.btnLihat.Text = "Lihat Data";
            this.btnLihat.UseVisualStyleBackColor = true;
            this.btnLihat.Click += new System.EventHandler(this.btnLihat_Click);
            // 
            // FormPenambahanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 181);
            this.Controls.Add(this.btnLihat);
            this.Controls.Add(this.btnSImpan);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNama);
            this.Name = "FormPenambahanData";
            this.Text = "Form Penambahan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNama;
        private Label lblAlamat;
        private Label lblTelp;
        private TextBox txtNama;
        private TextBox txtAlamat;
        private TextBox txtTelp;
        private Button btnSImpan;
        private Button btnLihat;
    }
}