using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace TirarPrintForm
{
    public partial class Form1 : Form
    {
        //string nomeArquivo = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btPrintForm_Click(object sender, EventArgs e)
        {
            //pasta onde vai salvar
            var path = @"C:\\Users\\POSITIVO\\Desktop\\C#\\PrintForm";

            var result = CapturaForm(path,this);

            if (result != "")
            {
                MessageBox.Show("Formulario capturado em " + result);
            }
            else
            {
                MessageBox.Show("Não foi possivel capturar o form");
            }
         
        }

        private string CapturaForm(string path, Form form)
        {
            try
            {
                //definindo nome do arquivo
                var nomeArquivo = path + "\\" + DateTime.Now.ToString().Replace(" ", "_").Replace("/", "").Replace(":", "") + ".png";
                //print
                using (var bmp = new Bitmap(form.Width,form.Height))
                {
                    form.DrawToBitmap(bmp, new System.Drawing.Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save(nomeArquivo);
                }
                return nomeArquivo;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Falha: " + ex.Message);
                return "";
            }
        }

        private void btPDF_Click(object sender, EventArgs e)
        {
            string dataeHoraAtual = DateTime.Now.ToString().Replace(" ", "_").Replace("/", "").Replace(":", "");

            //caminho onde vai criar o arquivo pdf
            var caminho = @"C:\\Users\\POSITIVO\\Desktop\\C#\\PrintForm\\";
            //nome que este pdf terá
            string nomeArquivo = caminho + dataeHoraAtual + "turmas.pdf";
            //criando o arquivo
            FileStream arquivoPDF = new FileStream(nomeArquivo, FileMode.Create);
            //definindo tamanho da pagina
            Document doc = new Document(PageSize.A4);
            PdfWriter escritorPDF = PdfWriter.GetInstance(doc, arquivoPDF);

            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminho + "19012023_221935.png");
            logo.ScaleToFit(700f, 300f);
            logo.Alignment = Element.ALIGN_CENTER;

            doc.Open();
            doc.Add(logo);
            doc.Close();
        }

       
    }


}
