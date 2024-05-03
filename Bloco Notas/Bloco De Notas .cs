using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bloco_Notas
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument1;

        public Form1()
        {
            InitializeComponent();

        }




        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Novo();
        }
        private void Novo()
        {
            // Verifica se o conteúdo do RichTextBox foi modificado
            if (richTextBox1.Modified)
            {
                // Pergunta ao usuário se deseja salvar as alterações
                DialogResult result = MessageBox.Show("Deseja salvar as alterações?", "Salvar", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    // Se o usuário clicar em "Sim", salva o documento
                    Guardar();
                }
                else if (result == DialogResult.Cancel)
                {
                    // Se o usuário clicar em "Cancelar", sai do método sem criar um novo documento
                    return;
                }
                // Se o usuário clicar em "Não", continua criando um novo documento sem salvar as alterações
            }

            // Limpa o conteúdo do RichTextBox
            richTextBox1.Clear();

            // Define o foco no RichTextBox
            richTextBox1.Focus();
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir();
        }
        private void Abrir()
        {
            // Cria uma instância do OpenFileDialog
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Define os filtros de arquivo
            openFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            // Exibe a caixa de diálogo
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Lê o conteúdo do arquivo selecionado e o exibe no richTextBox
                    richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    // Exibe uma mensagem de erro se houver algum problema ao abrir o arquivo
                    MessageBox.Show("Erro ao abrir o arquivo: " + ex.Message);
                }
            }
        }

        private void BtnAbrir_Click(object sender, EventArgs e)
        {
            Abrir();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }
        private void Guardar()
        {
            // Cria uma instância do SaveFileDialog
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Define os filtros de arquivo
            saveFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            // Exibe a caixa de diálogo
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Salva o conteúdo do richTextBox no arquivo selecionado
                    richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    // Exibe uma mensagem de erro se houver algum problema ao salvar o arquivo
                    MessageBox.Show("Erro ao salvar o arquivo: " + ex.Message);
                }
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria uma instância do PrintDialog
            PrintDialog printDialog1 = new PrintDialog();

            // Define o documento a ser impresso
            printDialog1.Document = printDocument2;

            // Exibe a caixa de diálogo para o usuário selecionar a impressora e configurar a impressão
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                // Se o usuário clicou em "OK", imprime o documento
                printDocument2.Print();
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sair();
        }
        private void Sair()
        {
            if (MessageBox.Show("Deseja Sair do Programa", "Sair",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            this.Close();
        }

        private void fomatarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria uma instância do FontDialog
            FontDialog fontDialog1 = new FontDialog();

            // Exibe a caixa de diálogo para o usuário selecionar a fonte
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                // Define a fonte selecionada para o texto no RichTextBox
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            copiar();
        }
        private void copiar()
        {
            // Verifica se há texto selecionado no RichTextBox
            if (richTextBox1.SelectedText != "")
            {
                // Copia o texto selecionado para a área de transferência
                Clipboard.SetText(richTextBox1.SelectedText);
            }
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            copiar();
        }

        private void BtnColar_Click(object sender, EventArgs e)
        {
            Colar();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colar();
        }
        private void Colar()
        {
            // Verifica se há texto na área de transferência
            if (Clipboard.ContainsText())
            {
                // Obtém o texto da área de transferência e cola no RichTextBox
                richTextBox1.Paste();
            }
        }

        private void desfazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica se é possível desfazer a última ação
            if (richTextBox1.CanUndo)
            {
                // Desfaz a última ação
                richTextBox1.Undo();
            }
        }

        private void refazerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Verifica se é possível refazer a última ação desfeita
            if (richTextBox1.CanRedo)
            {
                // Refaz a última ação desfeita
                richTextBox1.Redo();
            }
        }

        private void BtnEsquerda_Click(object sender, EventArgs e)
        {
            // Define o alinhamento do texto à esquerda
            richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void BtnCentro_Click(object sender, EventArgs e)
        {
            // Define o alinhamento do texto como centralizado
            richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void BtnDireita_Click(object sender, EventArgs e)
        {
            // Define o alinhamento do texto à Direita
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void BtnJustificado_Click(object sender, EventArgs e)
        {
            // Define o alinhamento do texto como justificado
            richTextBox1.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void BtnFonte_Click(object sender, EventArgs e)
        {
            // Verifica se há texto selecionado
            if (richTextBox1.SelectionLength > 0)
            {
                // Obtém a fonte atual e aumenta o tamanho
                Font currentFont = richTextBox1.SelectionFont;
                float newSize = currentFont.Size + 2; // Aumenta o tamanho em 2 pontos
                Font newFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);

                // Aplica a nova fonte ao texto selecionado
                richTextBox1.SelectionFont = newFont;
            }
        }

        private void BtnNegrito_Click(object sender, EventArgs e)
        {
            // Verifica se há texto selecionado
            if (richTextBox1.SelectionLength > 0)
            {
                // Obtém a fonte atual e aplica o estilo negrito
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Bold; // Alternar entre negrito ativado e desativado
                Font newFont = new Font(currentFont, newStyle);

                // Aplica a nova fonte ao texto selecionado
                richTextBox1.SelectionFont = newFont;
            }
        }

        private void Btnitalico_Click(object sender, EventArgs e)
        {
            // Verifica se há texto selecionado
            if (richTextBox1.SelectionLength > 0)
            {
                // Obtém a fonte atual e aplica o estilo itálico
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Italic; // Alternar entre itálico ativado e desativado
                Font newFont = new Font(currentFont, newStyle);

                // Aplica a nova fonte ao texto selecionado
                richTextBox1.SelectionFont = newFont;
            }
        }

        private void BtnSublinhado_Click(object sender, EventArgs e)
        {
            // Verifica se há texto selecionado
            if (richTextBox1.SelectionLength > 0)
            {
                // Obtém a fonte atual e aplica o estilo sublinhado
                Font currentFont = richTextBox1.SelectionFont;
                FontStyle newStyle = currentFont.Style ^ FontStyle.Underline; // Alternar entre sublinhado ativado e desativado
                Font newFont = new Font(currentFont, newStyle);

                // Aplica a nova fonte ao texto selecionado
                richTextBox1.SelectionFont = newFont;
            }
        }

        private void BtnDiminuir_Click(object sender, EventArgs e)
        {
            // Verifica se há texto selecionado
            if (richTextBox1.SelectionLength > 0)
            {
                // Obtém a fonte atual e diminui o tamanho
                Font currentFont = richTextBox1.SelectionFont;
                float newSize = Math.Max(currentFont.Size - 2, 1); // Diminui o tamanho em 2 pontos, mas garante que o tamanho mínimo seja 1 ponto
                Font newFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);

                // Aplica a nova fonte ao texto selecionado
                richTextBox1.SelectionFont = newFont;
            }
        }

        private void mudarCorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cria uma instância do ColorDialog
            ColorDialog colorDialog1 = new ColorDialog();

            // Define a cor inicial para o diálogo de acordo com a cor atual do texto selecionado
            colorDialog1.Color = richTextBox1.SelectionColor;

            // Exibe a caixa de diálogo para o usuário selecionar a cor
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                // Define a cor selecionada para o texto selecionado no RichTextBox
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void aumentarZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Aumenta o zoom em 20%
            richTextBox1.ZoomFactor *= 1.2f;
        }

        private void deminuirZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Diminui o zoom em 20%
            richTextBox1.ZoomFactor /= 1.2f;
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor:DevJoel 2024 Portugal ©\n" + "Idade:32 Anos" + "Pais:portugal\n"
                + "Destrito : Aveiro\n" + "Agradecimentos: Engº Bruno Santos , Pedro Pinto, Joao Ribeiro", "Mesagem",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void limparFormataçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LimparFormatacao();
        }
        private void LimparFormatacao()
        {
            // Verifica se richTextBox1 não é nulo
            if (richTextBox1 != null)
            {
                // Verifica se há texto selecionado
                if (richTextBox1.SelectionLength > 0)
                {
                    try
                    {
                        // Cria uma nova fonte com as configurações padrão
                        Font defaultFont = new Font(richTextBox1.Font.FontFamily, richTextBox1.Font.Size, FontStyle.Regular);

                        // Remove todos os efeitos de formatação definindo as propriedades para os valores padrão
                        richTextBox1.SelectionFont = defaultFont;
                        richTextBox1.SelectionColor = richTextBox1.ForeColor;
                        richTextBox1.SelectionBackColor = richTextBox1.BackColor;
                        richTextBox1.SelectionAlignment = HorizontalAlignment.Left;
                        richTextBox1.SelectionBullet = false;
                        richTextBox1.SelectionIndent = 0;
                        richTextBox1.SelectionHangingIndent = 0;
                        richTextBox1.SelectionRightIndent = 0;
                        richTextBox1.SelectionTabs = null;
                        richTextBox1.SelectionCharOffset = 0;
                        richTextBox1.SelectionLength = 0;

                        // Remove hiperlinks desativando a proteção de seleção
                        richTextBox1.SelectionProtected = false;

                        // Limpa o histórico de undo para garantir que a formatação não possa ser desfeita
                        richTextBox1.ClearUndo();
                    }
                    catch (Exception ex)
                    {
                        // Se ocorrer uma exceção, trata-a aqui
                        MessageBox.Show("Erro ao limpar a formatação do texto selecionado: " + ex.Message);
                    }
                    MessageBox.Show("Formatação Limpa Com sucesso!..","Formatação",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }
    }
}


