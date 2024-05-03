using System.Windows.Forms;

namespace Bloco_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripArquivoItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.desfazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.refazerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fomatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.mudarCorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.limparFormataçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aumentarZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.deminuirZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnNovo = new System.Windows.Forms.ToolStripButton();
            this.BtnAbrir = new System.Windows.Forms.ToolStripButton();
            this.BtnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnCopiar = new System.Windows.Forms.ToolStripButton();
            this.BtnColar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnEsquerda = new System.Windows.Forms.ToolStripButton();
            this.BtnCentro = new System.Windows.Forms.ToolStripButton();
            this.BtnDireita = new System.Windows.Forms.ToolStripButton();
            this.BtnJustificado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnFonte = new System.Windows.Forms.ToolStripButton();
            this.BtnDiminuir = new System.Windows.Forms.ToolStripButton();
            this.BtnNegrito = new System.Windows.Forms.ToolStripButton();
            this.Btnitalico = new System.Windows.Forms.ToolStripButton();
            this.BtnSublinhado = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripArquivoItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem,
            this.verToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripArquivoItem
            // 
            this.menuToolStripArquivoItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.toolStripSeparator1,
            this.guardarToolStripMenuItem,
            this.toolStripSeparator2,
            this.imprimirToolStripMenuItem,
            this.toolStripSeparator3,
            this.sairToolStripMenuItem,
            this.toolStripSeparator8});
            this.menuToolStripArquivoItem.Name = "menuToolStripArquivoItem";
            this.menuToolStripArquivoItem.Size = new System.Drawing.Size(75, 24);
            this.menuToolStripArquivoItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(221, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.copiarToolStripMenuItem,
            this.toolStripSeparator5,
            this.colarToolStripMenuItem,
            this.toolStripSeparator6,
            this.desfazerToolStripMenuItem,
            this.toolStripSeparator7,
            this.refazerToolStripMenuItem,
            this.toolStripSeparator18});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(197, 6);
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(197, 6);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(197, 6);
            // 
            // desfazerToolStripMenuItem
            // 
            this.desfazerToolStripMenuItem.Name = "desfazerToolStripMenuItem";
            this.desfazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.desfazerToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.desfazerToolStripMenuItem.Text = "Desfazer";
            this.desfazerToolStripMenuItem.Click += new System.EventHandler(this.desfazerToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(197, 6);
            // 
            // refazerToolStripMenuItem
            // 
            this.refazerToolStripMenuItem.Name = "refazerToolStripMenuItem";
            this.refazerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refazerToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.refazerToolStripMenuItem.Text = "Refazer";
            this.refazerToolStripMenuItem.Click += new System.EventHandler(this.refazerToolStripMenuItem_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(197, 6);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fomatarToolStripMenuItem,
            this.toolStripSeparator12,
            this.mudarCorToolStripMenuItem,
            this.toolStripSeparator14,
            this.limparFormataçãoToolStripMenuItem,
            this.toolStripSeparator15});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // fomatarToolStripMenuItem
            // 
            this.fomatarToolStripMenuItem.Name = "fomatarToolStripMenuItem";
            this.fomatarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.fomatarToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.fomatarToolStripMenuItem.Text = "Fomatar";
            this.fomatarToolStripMenuItem.Click += new System.EventHandler(this.fomatarToolStripMenuItem_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(267, 6);
            // 
            // mudarCorToolStripMenuItem
            // 
            this.mudarCorToolStripMenuItem.Name = "mudarCorToolStripMenuItem";
            this.mudarCorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mudarCorToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.mudarCorToolStripMenuItem.Text = "Mudar Cor ";
            this.mudarCorToolStripMenuItem.Click += new System.EventHandler(this.mudarCorToolStripMenuItem_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(267, 6);
            // 
            // limparFormataçãoToolStripMenuItem
            // 
            this.limparFormataçãoToolStripMenuItem.Name = "limparFormataçãoToolStripMenuItem";
            this.limparFormataçãoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.limparFormataçãoToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.limparFormataçãoToolStripMenuItem.Text = "Limpar Formatação";
            this.limparFormataçãoToolStripMenuItem.Click += new System.EventHandler(this.limparFormataçãoToolStripMenuItem_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(267, 6);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aumentarZoomToolStripMenuItem,
            this.toolStripSeparator13,
            this.deminuirZoomToolStripMenuItem,
            this.toolStripSeparator17});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // aumentarZoomToolStripMenuItem
            // 
            this.aumentarZoomToolStripMenuItem.Name = "aumentarZoomToolStripMenuItem";
            this.aumentarZoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.aumentarZoomToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.aumentarZoomToolStripMenuItem.Text = "Aumentar Zoom";
            this.aumentarZoomToolStripMenuItem.Click += new System.EventHandler(this.aumentarZoomToolStripMenuItem_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(250, 6);
            // 
            // deminuirZoomToolStripMenuItem
            // 
            this.deminuirZoomToolStripMenuItem.Name = "deminuirZoomToolStripMenuItem";
            this.deminuirZoomToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.deminuirZoomToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.deminuirZoomToolStripMenuItem.Text = "Deminuir Zoom";
            this.deminuirZoomToolStripMenuItem.Click += new System.EventHandler(this.deminuirZoomToolStripMenuItem_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(250, 6);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem,
            this.toolStripSeparator16});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(178, 26);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnNovo,
            this.BtnAbrir,
            this.BtnGuardar,
            this.toolStripSeparator9,
            this.BtnCopiar,
            this.BtnColar,
            this.toolStripSeparator10,
            this.BtnEsquerda,
            this.BtnCentro,
            this.BtnDireita,
            this.BtnJustificado,
            this.toolStripSeparator11,
            this.BtnFonte,
            this.BtnDiminuir,
            this.BtnNegrito,
            this.Btnitalico,
            this.BtnSublinhado});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1145, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnNovo
            // 
            this.BtnNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNovo.Image = global::Bloco_Notas.Properties.Resources.Novo;
            this.BtnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(29, 24);
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // BtnAbrir
            // 
            this.BtnAbrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnAbrir.Image = global::Bloco_Notas.Properties.Resources.Abrir;
            this.BtnAbrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAbrir.Name = "BtnAbrir";
            this.BtnAbrir.Size = new System.Drawing.Size(29, 24);
            this.BtnAbrir.Text = "Abrir";
            this.BtnAbrir.Click += new System.EventHandler(this.BtnAbrir_Click);
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnGuardar.Image = global::Bloco_Notas.Properties.Resources.Guardar;
            this.BtnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(29, 24);
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnCopiar
            // 
            this.BtnCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCopiar.Image = global::Bloco_Notas.Properties.Resources.Copiar;
            this.BtnCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCopiar.Name = "BtnCopiar";
            this.BtnCopiar.Size = new System.Drawing.Size(29, 24);
            this.BtnCopiar.Text = "Copiar";
            this.BtnCopiar.Click += new System.EventHandler(this.BtnCopiar_Click);
            // 
            // BtnColar
            // 
            this.BtnColar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnColar.Image = global::Bloco_Notas.Properties.Resources.Colar;
            this.BtnColar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnColar.Name = "BtnColar";
            this.BtnColar.Size = new System.Drawing.Size(29, 24);
            this.BtnColar.Text = "Colar";
            this.BtnColar.Click += new System.EventHandler(this.BtnColar_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnEsquerda
            // 
            this.BtnEsquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnEsquerda.Image = global::Bloco_Notas.Properties.Resources.Esquerda;
            this.BtnEsquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnEsquerda.Name = "BtnEsquerda";
            this.BtnEsquerda.Size = new System.Drawing.Size(29, 24);
            this.BtnEsquerda.Text = "Esquerda";
            this.BtnEsquerda.Click += new System.EventHandler(this.BtnEsquerda_Click);
            // 
            // BtnCentro
            // 
            this.BtnCentro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnCentro.Image = global::Bloco_Notas.Properties.Resources.centro;
            this.BtnCentro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnCentro.Name = "BtnCentro";
            this.BtnCentro.Size = new System.Drawing.Size(29, 24);
            this.BtnCentro.Text = "Centro";
            this.BtnCentro.Click += new System.EventHandler(this.BtnCentro_Click);
            // 
            // BtnDireita
            // 
            this.BtnDireita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDireita.Image = global::Bloco_Notas.Properties.Resources.Diereito;
            this.BtnDireita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDireita.Name = "BtnDireita";
            this.BtnDireita.Size = new System.Drawing.Size(29, 24);
            this.BtnDireita.Text = "Direita";
            this.BtnDireita.Click += new System.EventHandler(this.BtnDireita_Click);
            // 
            // BtnJustificado
            // 
            this.BtnJustificado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnJustificado.Image = global::Bloco_Notas.Properties.Resources.Justificado;
            this.BtnJustificado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnJustificado.Name = "BtnJustificado";
            this.BtnJustificado.Size = new System.Drawing.Size(29, 24);
            this.BtnJustificado.Text = "Justificado";
            this.BtnJustificado.Click += new System.EventHandler(this.BtnJustificado_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnFonte
            // 
            this.BtnFonte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnFonte.Image = global::Bloco_Notas.Properties.Resources.Fonte;
            this.BtnFonte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnFonte.Name = "BtnFonte";
            this.BtnFonte.Size = new System.Drawing.Size(29, 24);
            this.BtnFonte.Text = "Aumentar Fonte";
            this.BtnFonte.Click += new System.EventHandler(this.BtnFonte_Click);
            // 
            // BtnDiminuir
            // 
            this.BtnDiminuir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDiminuir.Image = global::Bloco_Notas.Properties.Resources.Diminuir_Letra;
            this.BtnDiminuir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDiminuir.Name = "BtnDiminuir";
            this.BtnDiminuir.Size = new System.Drawing.Size(29, 24);
            this.BtnDiminuir.Text = "Diminuir Fonte";
            this.BtnDiminuir.Click += new System.EventHandler(this.BtnDiminuir_Click);
            // 
            // BtnNegrito
            // 
            this.BtnNegrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnNegrito.Image = global::Bloco_Notas.Properties.Resources.Negrito;
            this.BtnNegrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnNegrito.Name = "BtnNegrito";
            this.BtnNegrito.Size = new System.Drawing.Size(29, 24);
            this.BtnNegrito.Text = "Negrito";
            this.BtnNegrito.Click += new System.EventHandler(this.BtnNegrito_Click);
            // 
            // Btnitalico
            // 
            this.Btnitalico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Btnitalico.Image = global::Bloco_Notas.Properties.Resources.Italico;
            this.Btnitalico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btnitalico.Name = "Btnitalico";
            this.Btnitalico.Size = new System.Drawing.Size(29, 24);
            this.Btnitalico.Text = "Italico";
            this.Btnitalico.Click += new System.EventHandler(this.Btnitalico_Click);
            // 
            // BtnSublinhado
            // 
            this.BtnSublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSublinhado.Image = global::Bloco_Notas.Properties.Resources.Sublinhado;
            this.BtnSublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSublinhado.Name = "BtnSublinhado";
            this.BtnSublinhado.Size = new System.Drawing.Size(29, 24);
            this.BtnSublinhado.Text = "Sublinhado";
            this.BtnSublinhado.Click += new System.EventHandler(this.BtnSublinhado_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.richTextBox1);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 556);
            this.panel1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1145, 556);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Notpad Compeleto DevJoel 2024©";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripArquivoItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem desfazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem refazerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fomatarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnNovo;
        private System.Windows.Forms.ToolStripButton BtnAbrir;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton BtnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton BtnCopiar;
        private System.Windows.Forms.ToolStripButton BtnColar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton BtnCentro;
        private System.Windows.Forms.ToolStripButton BtnEsquerda;
        private System.Windows.Forms.ToolStripButton BtnDireita;
        private System.Windows.Forms.ToolStripButton BtnJustificado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton BtnFonte;
        private System.Windows.Forms.ToolStripButton BtnNegrito;
        private System.Windows.Forms.ToolStripButton Btnitalico;
        private System.Windows.Forms.ToolStripButton BtnSublinhado;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.ToolStripButton BtnDiminuir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem mudarCorToolStripMenuItem;
        private ToolStripMenuItem verToolStripMenuItem;
        private ToolStripMenuItem aumentarZoomToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem deminuirZoomToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem limparFormataçãoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator15;
        private ToolStripSeparator toolStripSeparator18;
        private ToolStripSeparator toolStripSeparator17;
        private ToolStripSeparator toolStripSeparator16;
    }
}

