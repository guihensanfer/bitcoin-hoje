namespace Bitcoin_Hoje
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerColetarECalcularValor = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRQUIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXIBIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.telaCheiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exibirListaDeNotificaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.graficoEm3DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verValoresDoBitcoinNoGráficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pREFERÊNCIASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferênciasDeNotificaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aJUDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOBitcoinHojeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEHoraInicioAnaliseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tempoDeInstabilidadeDeRedeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusCONEXAO = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelVALOR_ATUAL = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMEDIA = new System.Windows.Forms.ToolStripStatusLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelManteve = new System.Windows.Forms.Label();
            this.labelCaiu = new System.Windows.Forms.Label();
            this.labelCresceu = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerInstabilidadeRede = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerColetarECalcularValor
            // 
            this.timerColetarECalcularValor.Enabled = true;
            this.timerColetarECalcularValor.Interval = 1000;
            this.timerColetarECalcularValor.Tick += new System.EventHandler(this.timerColetarECalcularValor_Tick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(773, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "DESATIVAR ANÁLISE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRQUIVOToolStripMenuItem,
            this.eXIBIRToolStripMenuItem,
            this.pREFERÊNCIASToolStripMenuItem,
            this.aJUDAToolStripMenuItem,
            this.dataEHoraInicioAnaliseToolStripMenuItem,
            this.tempoDeInstabilidadeDeRedeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1065, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRQUIVOToolStripMenuItem
            // 
            this.aRQUIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.aRQUIVOToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aRQUIVOToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aRQUIVOToolStripMenuItem.Name = "aRQUIVOToolStripMenuItem";
            this.aRQUIVOToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.aRQUIVOToolStripMenuItem.Text = "ARQUIVO";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // eXIBIRToolStripMenuItem
            // 
            this.eXIBIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.telaCheiaToolStripMenuItem,
            this.exibirListaDeNotificaçõesToolStripMenuItem,
            this.toolStripSeparator1,
            this.graficoEm3DToolStripMenuItem,
            this.verValoresDoBitcoinNoGráficoToolStripMenuItem});
            this.eXIBIRToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eXIBIRToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.eXIBIRToolStripMenuItem.Name = "eXIBIRToolStripMenuItem";
            this.eXIBIRToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.eXIBIRToolStripMenuItem.Text = "EXIBIR";
            // 
            // telaCheiaToolStripMenuItem
            // 
            this.telaCheiaToolStripMenuItem.CheckOnClick = true;
            this.telaCheiaToolStripMenuItem.Name = "telaCheiaToolStripMenuItem";
            this.telaCheiaToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.telaCheiaToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.telaCheiaToolStripMenuItem.Text = "Tela cheia";
            this.telaCheiaToolStripMenuItem.CheckedChanged += new System.EventHandler(this.telaCheiaToolStripMenuItem_CheckedChanged);
            // 
            // exibirListaDeNotificaçõesToolStripMenuItem
            // 
            this.exibirListaDeNotificaçõesToolStripMenuItem.Checked = true;
            this.exibirListaDeNotificaçõesToolStripMenuItem.CheckOnClick = true;
            this.exibirListaDeNotificaçõesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exibirListaDeNotificaçõesToolStripMenuItem.Name = "exibirListaDeNotificaçõesToolStripMenuItem";
            this.exibirListaDeNotificaçõesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.exibirListaDeNotificaçõesToolStripMenuItem.Text = "Exibir lista de notificações";
            this.exibirListaDeNotificaçõesToolStripMenuItem.CheckedChanged += new System.EventHandler(this.exibirListaDeNotificaçõesToolStripMenuItem_CheckedChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(242, 6);
            // 
            // graficoEm3DToolStripMenuItem
            // 
            this.graficoEm3DToolStripMenuItem.CheckOnClick = true;
            this.graficoEm3DToolStripMenuItem.Name = "graficoEm3DToolStripMenuItem";
            this.graficoEm3DToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.graficoEm3DToolStripMenuItem.Text = "Ver gráfico em 3D";
            this.graficoEm3DToolStripMenuItem.CheckedChanged += new System.EventHandler(this.graficoEm3DToolStripMenuItem_CheckedChanged);
            // 
            // verValoresDoBitcoinNoGráficoToolStripMenuItem
            // 
            this.verValoresDoBitcoinNoGráficoToolStripMenuItem.CheckOnClick = true;
            this.verValoresDoBitcoinNoGráficoToolStripMenuItem.Name = "verValoresDoBitcoinNoGráficoToolStripMenuItem";
            this.verValoresDoBitcoinNoGráficoToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.verValoresDoBitcoinNoGráficoToolStripMenuItem.Text = "Ver valores do Bitcoin no gráfico";
            this.verValoresDoBitcoinNoGráficoToolStripMenuItem.CheckedChanged += new System.EventHandler(this.verValoresDoBitcoinNoGráficoToolStripMenuItem_CheckedChanged);
            // 
            // pREFERÊNCIASToolStripMenuItem
            // 
            this.pREFERÊNCIASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferênciasDeNotificaçõesToolStripMenuItem});
            this.pREFERÊNCIASToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pREFERÊNCIASToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.pREFERÊNCIASToolStripMenuItem.Name = "pREFERÊNCIASToolStripMenuItem";
            this.pREFERÊNCIASToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.pREFERÊNCIASToolStripMenuItem.Text = "PREFERÊNCIAS";
            // 
            // preferênciasDeNotificaçõesToolStripMenuItem
            // 
            this.preferênciasDeNotificaçõesToolStripMenuItem.Name = "preferênciasDeNotificaçõesToolStripMenuItem";
            this.preferênciasDeNotificaçõesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.preferênciasDeNotificaçõesToolStripMenuItem.Size = new System.Drawing.Size(284, 22);
            this.preferênciasDeNotificaçõesToolStripMenuItem.Text = "Preferências de notificações";
            this.preferênciasDeNotificaçõesToolStripMenuItem.Click += new System.EventHandler(this.preferênciasDeNotificaçõesToolStripMenuItem_Click);
            // 
            // aJUDAToolStripMenuItem
            // 
            this.aJUDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOBitcoinHojeToolStripMenuItem});
            this.aJUDAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aJUDAToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.aJUDAToolStripMenuItem.Name = "aJUDAToolStripMenuItem";
            this.aJUDAToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.aJUDAToolStripMenuItem.Text = "AJUDA";
            // 
            // sobreOBitcoinHojeToolStripMenuItem
            // 
            this.sobreOBitcoinHojeToolStripMenuItem.Name = "sobreOBitcoinHojeToolStripMenuItem";
            this.sobreOBitcoinHojeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.sobreOBitcoinHojeToolStripMenuItem.Text = "Sobre o Bitcoin Hoje...";
            this.sobreOBitcoinHojeToolStripMenuItem.Click += new System.EventHandler(this.sobreOBitcoinHojeToolStripMenuItem_Click);
            // 
            // dataEHoraInicioAnaliseToolStripMenuItem
            // 
            this.dataEHoraInicioAnaliseToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.dataEHoraInicioAnaliseToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.dataEHoraInicioAnaliseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataEHoraInicioAnaliseToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.dataEHoraInicioAnaliseToolStripMenuItem.Name = "dataEHoraInicioAnaliseToolStripMenuItem";
            this.dataEHoraInicioAnaliseToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            this.dataEHoraInicioAnaliseToolStripMenuItem.Visible = false;
            // 
            // tempoDeInstabilidadeDeRedeToolStripMenuItem
            // 
            this.tempoDeInstabilidadeDeRedeToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tempoDeInstabilidadeDeRedeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoDeInstabilidadeDeRedeToolStripMenuItem.ForeColor = System.Drawing.Color.DimGray;
            this.tempoDeInstabilidadeDeRedeToolStripMenuItem.Name = "tempoDeInstabilidadeDeRedeToolStripMenuItem";
            this.tempoDeInstabilidadeDeRedeToolStripMenuItem.Size = new System.Drawing.Size(251, 20);
            this.tempoDeInstabilidadeDeRedeToolStripMenuItem.Text = "Tempo de instabilidade de rede: 0 segundos";
            this.tempoDeInstabilidadeDeRedeToolStripMenuItem.Visible = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusCONEXAO,
            this.toolStripStatusLabelVALOR_ATUAL,
            this.toolStripStatusLabelMEDIA});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1065, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusCONEXAO
            // 
            this.toolStripStatusCONEXAO.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusCONEXAO.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusCONEXAO.Name = "toolStripStatusCONEXAO";
            this.toolStripStatusCONEXAO.Size = new System.Drawing.Size(198, 17);
            this.toolStripStatusCONEXAO.Text = "Conexão estável, análise desativada";
            // 
            // toolStripStatusLabelVALOR_ATUAL
            // 
            this.toolStripStatusLabelVALOR_ATUAL.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelVALOR_ATUAL.Name = "toolStripStatusLabelVALOR_ATUAL";
            this.toolStripStatusLabelVALOR_ATUAL.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabelMEDIA
            // 
            this.toolStripStatusLabelMEDIA.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabelMEDIA.Name = "toolStripStatusLabelMEDIA";
            this.toolStripStatusLabelMEDIA.Size = new System.Drawing.Size(0, 17);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.DimGray;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.Color.Gainsboro;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 443);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1065, 110);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Valor Bitcoin";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Média";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Data notificação";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Hora notificação";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Variação absoluta em relação a Média";
            this.columnHeader5.Width = 228;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Taxa da Variação Absoluta";
            this.columnHeader6.Width = 160;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ocorrência";
            this.columnHeader7.Width = 111;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 40);
            this.panel1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(629, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "FIBONACCI";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(917, 19);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(138, 13);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ALTERAR PREFERÊNCIAS...";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY2.IsStartedFromZero = false;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowOffset = 2;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 64);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Valor Bitcoin";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series1.YValuesPerPoint = 5;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderColor = System.Drawing.Color.Red;
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "Limite crescente";
            series2.YValuesPerPoint = 5;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Limite decrescente";
            series3.YValuesPerPoint = 5;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Black;
            series4.Legend = "Legend1";
            series4.LegendText = "Média dos valores coletados";
            series4.Name = "Media";
            series4.YValuesPerPoint = 5;
            series4.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1065, 379);
            this.chart1.TabIndex = 8;
            this.chart1.Text = "Gráfico Bitcoin, valor em relação ao tempo";
            this.chart1.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            title1.Name = "Title1";
            title1.Text = "Bitcoin: Valor x Tempo";
            this.chart1.Titles.Add(title1);
            this.chart1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DimGray;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(453, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sem notificações";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.labelManteve);
            this.groupBox1.Controls.Add(this.labelCaiu);
            this.groupBox1.Controls.Add(this.labelCresceu);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(818, 268);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 163);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Variações baseadas no intervalo de 30 segundos";
            // 
            // labelManteve
            // 
            this.labelManteve.AutoSize = true;
            this.labelManteve.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelManteve.ForeColor = System.Drawing.Color.DimGray;
            this.labelManteve.Location = new System.Drawing.Point(5, 106);
            this.labelManteve.Name = "labelManteve";
            this.labelManteve.Size = new System.Drawing.Size(0, 25);
            this.labelManteve.TabIndex = 2;
            // 
            // labelCaiu
            // 
            this.labelCaiu.AutoSize = true;
            this.labelCaiu.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCaiu.ForeColor = System.Drawing.Color.IndianRed;
            this.labelCaiu.Location = new System.Drawing.Point(5, 71);
            this.labelCaiu.Name = "labelCaiu";
            this.labelCaiu.Size = new System.Drawing.Size(0, 25);
            this.labelCaiu.TabIndex = 1;
            // 
            // labelCresceu
            // 
            this.labelCresceu.AutoSize = true;
            this.labelCresceu.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCresceu.ForeColor = System.Drawing.Color.ForestGreen;
            this.labelCresceu.Location = new System.Drawing.Point(5, 36);
            this.labelCresceu.Name = "labelCresceu";
            this.labelCresceu.Size = new System.Drawing.Size(0, 25);
            this.labelCresceu.TabIndex = 0;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Bitcoin Hoje";
            this.notifyIcon1.Visible = true;
            // 
            // timerInstabilidadeRede
            // 
            this.timerInstabilidadeRede.Interval = 1000;
            this.timerInstabilidadeRede.Tick += new System.EventHandler(this.timerInstabilidadeRede_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1065, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bitcoin Hoje";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerColetarECalcularValor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMEDIA;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVALOR_ATUAL;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusCONEXAO;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem aRQUIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXIBIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exibirListaDeNotificaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pREFERÊNCIASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferênciasDeNotificaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aJUDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOBitcoinHojeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem dataEHoraInicioAnaliseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem telaCheiaToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelCaiu;
        private System.Windows.Forms.Label labelCresceu;
        private System.Windows.Forms.Label labelManteve;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem graficoEm3DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verValoresDoBitcoinNoGráficoToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timerInstabilidadeRede;
        private System.Windows.Forms.ToolStripMenuItem tempoDeInstabilidadeDeRedeToolStripMenuItem;
        private System.Windows.Forms.Button button2;
    }
}

