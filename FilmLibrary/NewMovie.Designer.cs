namespace FilmLibrary
{
    partial class NewMovie
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulli = new System.Windows.Forms.TextBox();
            this.rtbPershkrimi = new System.Windows.Forms.RichTextBox();
            this.cboZhanri = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listAktoret = new System.Windows.Forms.ListBox();
            this.btnRuaje = new System.Windows.Forms.Button();
            this.cboAktoret = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pershkrimi";
            // 
            // txtTitulli
            // 
            this.txtTitulli.Location = new System.Drawing.Point(160, 69);
            this.txtTitulli.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulli.Name = "txtTitulli";
            this.txtTitulli.Size = new System.Drawing.Size(340, 22);
            this.txtTitulli.TabIndex = 2;
            // 
            // rtbPershkrimi
            // 
            this.rtbPershkrimi.Location = new System.Drawing.Point(157, 112);
            this.rtbPershkrimi.Margin = new System.Windows.Forms.Padding(4);
            this.rtbPershkrimi.Name = "rtbPershkrimi";
            this.rtbPershkrimi.Size = new System.Drawing.Size(341, 194);
            this.rtbPershkrimi.TabIndex = 3;
            this.rtbPershkrimi.Text = "";
            // 
            // cboZhanri
            // 
            this.cboZhanri.FormattingEnabled = true;
            this.cboZhanri.Location = new System.Drawing.Point(159, 326);
            this.cboZhanri.Margin = new System.Windows.Forms.Padding(4);
            this.cboZhanri.Name = "cboZhanri";
            this.cboZhanri.Size = new System.Drawing.Size(340, 24);
            this.cboZhanri.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 336);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Zhanri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 380);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Aktori";
            // 
            // listAktoret
            // 
            this.listAktoret.FormattingEnabled = true;
            this.listAktoret.ItemHeight = 16;
            this.listAktoret.Location = new System.Drawing.Point(157, 425);
            this.listAktoret.Margin = new System.Windows.Forms.Padding(4);
            this.listAktoret.Name = "listAktoret";
            this.listAktoret.Size = new System.Drawing.Size(343, 100);
            this.listAktoret.TabIndex = 7;
            // 
            // btnRuaje
            // 
            this.btnRuaje.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRuaje.Location = new System.Drawing.Point(157, 539);
            this.btnRuaje.Margin = new System.Windows.Forms.Padding(4);
            this.btnRuaje.Name = "btnRuaje";
            this.btnRuaje.Size = new System.Drawing.Size(91, 30);
            this.btnRuaje.TabIndex = 8;
            this.btnRuaje.Text = "Ruaje";
            this.btnRuaje.UseVisualStyleBackColor = true;
            this.btnRuaje.Click += new System.EventHandler(this.btnRuaje_Click);
            // 
            // cboAktoret
            // 
            this.cboAktoret.FormattingEnabled = true;
            this.cboAktoret.Location = new System.Drawing.Point(157, 375);
            this.cboAktoret.Margin = new System.Windows.Forms.Padding(4);
            this.cboAktoret.Name = "cboAktoret";
            this.cboAktoret.Size = new System.Drawing.Size(341, 24);
            this.cboAktoret.TabIndex = 9;
            this.cboAktoret.SelectedIndexChanged += new System.EventHandler(this.cboAktoret_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(384, 542);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Anulo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // NewMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 583);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboAktoret);
            this.Controls.Add(this.btnRuaje);
            this.Controls.Add(this.listAktoret);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboZhanri);
            this.Controls.Add(this.rtbPershkrimi);
            this.Controls.Add(this.txtTitulli);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewMovie";
            this.Text = "NewMovie";
            this.Load += new System.EventHandler(this.NewMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulli;
        private System.Windows.Forms.RichTextBox rtbPershkrimi;
        private System.Windows.Forms.ComboBox cboZhanri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listAktoret;
        private System.Windows.Forms.Button btnRuaje;
        private System.Windows.Forms.ComboBox cboAktoret;
        private System.Windows.Forms.Button button1;
    }
}