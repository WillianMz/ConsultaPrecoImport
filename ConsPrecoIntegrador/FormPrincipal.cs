using ClosedXML.Excel;
using Newtonsoft.Json;
using System.Globalization;

namespace ConsPrecoIntegrador
{
    public partial class FormPrincipal : Form
    {
        private List<Produto>? produtos;
        private string arquivo = string.Empty;
        private string arqJson = string.Empty;

        public FormPrincipal()
        {
            InitializeComponent();
            lblMensagem.Text = "WN";
        }

        private void ImportarProdutos()
        {
            try
            {
                var workbook = new XLWorkbook(arquivo);
                var planilha = workbook.Worksheet(1);
                int linhaInicio = 2;//inicia leitura da linha 2 da planilha. linha 1 e cabecalho
                produtos = new();

                try
                {
                    while (true)
                    {
                        var id        = planilha.Cell("A" + linhaInicio.ToString()).Value.ToString();
                        var codbarras = planilha.Cell("B" + linhaInicio.ToString()).Value.ToString();
                        var nome      = planilha.Cell("C" + linhaInicio.ToString()).Value.ToString();
                        var preco     = planilha.Cell("D" + linhaInicio.ToString()).Value.ToString();

                        //quando a linha id for nula/em branco sai do laco de repeticao
                        if (string.IsNullOrEmpty(id))
                            break;

                        int cod = Convert.ToInt32(id);
                        decimal valor = Convert.ToDecimal(preco);
                        valor = decimal.Round(valor, 2);
                        Produto p = new(cod, codbarras, nome, preco);
                        produtos.Add(p);

                        linhaInicio++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro.\nDetalhes: {ex.Message}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro.\nDetalhes: {ex.Message}");
            }
        }

        private void ExportarProdutos()
        {
            try
            {
                Tables tables = new() { produto = "([id] INTEGER PRIMARY KEY, [codbarras], [nome], [preco_venda])" };
                Inserts inserts = new() { produto = produtos };
                Structure structure = new() { tables = tables };
                Data data = new() { inserts = inserts };
                Retorno json = new() { structure = structure, data = data };

                using StreamWriter sw = new(arqJson);
                using JsonWriter jw = new JsonTextWriter(sw);
                JsonSerializer serializer = new();
                serializer.Serialize(jw, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao exportar produtos.\nDetalhes: {ex.Message}");
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            openFileDlg.FileName = string.Empty;
            openFileDlg.InitialDirectory = "c:\\";
            openFileDlg.Filter = "Planilha do Excel (*.xlsx) | *.xlsx;";
            openFileDlg.FilterIndex = 2;
            openFileDlg.RestoreDirectory = true;

            if(openFileDlg.ShowDialog() == DialogResult.OK)
            {
                arquivo = openFileDlg.FileName;
            }

            btnImportarProd.Enabled = false;
            btnExportar.Enabled = false;
            barraProgresso.Style = ProgressBarStyle.Marquee;
            barraProgresso.MarqueeAnimationSpeed = 5;
            lblMensagem.Text = "aguarde, processando...";

            bgWorker.RunWorkerAsync();
        }

        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ImportarProdutos();
            if (bgWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                barraProgresso.MarqueeAnimationSpeed = 0;
                barraProgresso.Style = ProgressBarStyle.Blocks;
                barraProgresso.Value = 0;
            }
            else if(e.Error != null)
            {                
                barraProgresso.MarqueeAnimationSpeed = 0;
                barraProgresso.Style = ProgressBarStyle.Blocks;
                barraProgresso.Value = 0;
                MessageBox.Show("Ocorreu um erro");
            }
            else
            {                
                barraProgresso.MarqueeAnimationSpeed = 0;
                barraProgresso.Style = ProgressBarStyle.Blocks;
                barraProgresso.Value = 100;
                lblMensagem.Text = "Dados importados com sucesso!";
                MessageBox.Show("Importação de dados finalizada!");
            }

            btnExportar.Enabled = true;
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Planilha de dados de produtos deve possui a seguinte estrutura:\n" +
                            "COLUNAS:\n" +
                            "A = Código de Cadastro\n" +
                            "B = Código de Barras\n" +
                            "C = Nome do produto\n" +
                            "D = Preço do produto.\n\n\n" +
                            "LINHAS:\n" +
                            "1ª linha é o cabeçalho(Nomes das colunas acima)");
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            saveFileDlg.FileName = "produtos.json";
            saveFileDlg.InitialDirectory = "c:\\";
            saveFileDlg.Filter = "Arquivo (*.json) | *.json";
            saveFileDlg.FilterIndex = 2;
            saveFileDlg.RestoreDirectory = true;

            if(saveFileDlg.ShowDialog() == DialogResult.OK)
            {
                arqJson = saveFileDlg.FileName;
            }

            btnImportarProd.Enabled = false;
            btnExportar.Enabled = false;
            barraProgresso.Style = ProgressBarStyle.Marquee;
            barraProgresso.MarqueeAnimationSpeed = 5;
            lblMensagem.Text = "aguarde, processando...";

            bgWorkExp.RunWorkerAsync();
        }

        private void bgWorkExp_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            ExportarProdutos();
            if (bgWorker.CancellationPending)
            {
                e.Cancel = true;
                return;
            }
        }

        private void bgWorkExp_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                barraProgresso.MarqueeAnimationSpeed = 0;
                barraProgresso.Style = ProgressBarStyle.Blocks;
                barraProgresso.Value = 0;
            }
            else if (e.Error != null)
            {                
                barraProgresso.MarqueeAnimationSpeed = 0;
                barraProgresso.Style = ProgressBarStyle.Blocks;
                barraProgresso.Value = 0;
                MessageBox.Show("Ocorreu um erro");
            }
            else
            {                
                barraProgresso.MarqueeAnimationSpeed = 0;
                barraProgresso.Style = ProgressBarStyle.Blocks;
                barraProgresso.Value = 100;
                lblMensagem.Text = "Dados exportados com sucesso!";
                MessageBox.Show("Exportação de dados finalizada!");
            }

            btnImportarProd.Enabled = true;
        }
    }
}