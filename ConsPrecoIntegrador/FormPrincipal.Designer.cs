namespace ConsPrecoIntegrador
{
    partial class FormPrincipal
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
            this.btnImportarProd = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.barraProgresso = new System.Windows.Forms.ProgressBar();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAjuda = new System.Windows.Forms.Button();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDlg = new System.Windows.Forms.SaveFileDialog();
            this.bgWorkExp = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnImportarProd
            // 
            this.btnImportarProd.Location = new System.Drawing.Point(6, 22);
            this.btnImportarProd.Name = "btnImportarProd";
            this.btnImportarProd.Size = new System.Drawing.Size(228, 47);
            this.btnImportarProd.TabIndex = 4;
            this.btnImportarProd.Text = "Importar Produtos";
            this.btnImportarProd.UseVisualStyleBackColor = true;
            this.btnImportarProd.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(6, 22);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(229, 47);
            this.btnExportar.TabIndex = 5;
            this.btnExportar.Text = "Exportar Produtos";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // barraProgresso
            // 
            this.barraProgresso.Location = new System.Drawing.Point(12, 99);
            this.barraProgresso.Name = "barraProgresso";
            this.barraProgresso.Size = new System.Drawing.Size(487, 23);
            this.barraProgresso.TabIndex = 7;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(12, 132);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(51, 15);
            this.lblMensagem.TabIndex = 8;
            this.lblMensagem.Text = "WN2022";
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNome.ForeColor = System.Drawing.Color.Blue;
            this.lblNome.Location = new System.Drawing.Point(12, 174);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(163, 32);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "consultapreco";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImportarProd);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 81);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1º Passo: Importar planilha de produtos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnExportar);
            this.groupBox2.Location = new System.Drawing.Point(258, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 81);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2º Passo: Gerar arquivo para o aplicativo";
            // 
            // btnAjuda
            // 
            this.btnAjuda.Location = new System.Drawing.Point(424, 128);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Size = new System.Drawing.Size(75, 23);
            this.btnAjuda.TabIndex = 12;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.UseVisualStyleBackColor = true;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // bgWorkExp
            // 
            this.bgWorkExp.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkExp_DoWork);
            this.bgWorkExp.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkExp_RunWorkerCompleted);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 215);
            this.Controls.Add(this.btnAjuda);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.barraProgresso);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Preco Integrador";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnImportarProd;
        private Button btnExportar;
        private ProgressBar barraProgresso;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private Label lblMensagem;
        private Label lblNome;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAjuda;
        private OpenFileDialog openFileDlg;
        private SaveFileDialog saveFileDlg;
        private System.ComponentModel.BackgroundWorker bgWorkExp;
    }
}