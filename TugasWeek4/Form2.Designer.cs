namespace TugasWeek4
{
    partial class formTampilanData
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
            this.txtTelp = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblTelp = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtTelp
            // 
            this.txtTelp.Enabled = false;
            this.txtTelp.Location = new System.Drawing.Point(100, 94);
            this.txtTelp.Name = "txtTelp";
            this.txtTelp.PlaceholderText = "<data kosong>";
            this.txtTelp.Size = new System.Drawing.Size(200, 23);
            this.txtTelp.TabIndex = 11;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Enabled = false;
            this.txtAlamat.Location = new System.Drawing.Point(100, 64);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.PlaceholderText = "<data kosong>";
            this.txtAlamat.Size = new System.Drawing.Size(500, 23);
            this.txtAlamat.TabIndex = 10;
            // 
            // txtNama
            // 
            this.txtNama.Enabled = false;
            this.txtNama.Location = new System.Drawing.Point(100, 34);
            this.txtNama.Name = "txtNama";
            this.txtNama.PlaceholderText = "<data kosong>";
            this.txtNama.Size = new System.Drawing.Size(350, 23);
            this.txtNama.TabIndex = 9;
            // 
            // lblTelp
            // 
            this.lblTelp.AutoSize = true;
            this.lblTelp.Location = new System.Drawing.Point(20, 102);
            this.lblTelp.Name = "lblTelp";
            this.lblTelp.Size = new System.Drawing.Size(31, 15);
            this.lblTelp.TabIndex = 8;
            this.lblTelp.Text = "Telp:";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(20, 72);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(48, 15);
            this.lblAlamat.TabIndex = 7;
            this.lblAlamat.Text = "Alamat:";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Location = new System.Drawing.Point(20, 42);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(42, 15);
            this.lblNama.TabIndex = 6;
            this.lblNama.Text = "Nama:";
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(101, 132);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "Prev Data";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(20, 132);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 12;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(182, 132);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next Data";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formTampilanData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 181);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.lblTelp);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNama);
            this.Name = "formTampilanData";
            this.Text = "Form Tampilan Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtTelp;
        private TextBox txtAlamat;
        private TextBox txtNama;
        private Label lblTelp;
        private Label lblAlamat;
        private Label lblNama;
        private Button btnPrev;
        private Button btnKembali;
        private Button btnNext;
        private System.Windows.Forms.Timer timer1;
    }
}