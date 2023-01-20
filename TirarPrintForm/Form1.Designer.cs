namespace TirarPrintForm
{
    partial class Form1
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
            this.btPrintForm = new System.Windows.Forms.Button();
            this.btPDF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btPrintForm
            // 
            this.btPrintForm.Location = new System.Drawing.Point(212, 356);
            this.btPrintForm.Name = "btPrintForm";
            this.btPrintForm.Size = new System.Drawing.Size(151, 49);
            this.btPrintForm.TabIndex = 0;
            this.btPrintForm.Text = "Print Form";
            this.btPrintForm.UseVisualStyleBackColor = true;
            this.btPrintForm.Click += new System.EventHandler(this.btPrintForm_Click);
            // 
            // btPDF
            // 
            this.btPDF.Location = new System.Drawing.Point(402, 356);
            this.btPDF.Name = "btPDF";
            this.btPDF.Size = new System.Drawing.Size(151, 49);
            this.btPDF.TabIndex = 1;
            this.btPDF.Text = "PDFprint";
            this.btPDF.UseVisualStyleBackColor = true;
            this.btPDF.Click += new System.EventHandler(this.btPDF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btPDF);
            this.Controls.Add(this.btPrintForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btPrintForm;
        private System.Windows.Forms.Button btPDF;
    }
}

