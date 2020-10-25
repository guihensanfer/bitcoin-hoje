using System;
using System.Drawing;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using Bitcoin_Hoje.Properties;
using System.Windows.Forms.DataVisualization.Charting;

namespace Bitcoin_Hoje
{
    public partial class Form1 : Form
    {        
        public Form1()
        {
            InitializeComponent();
        }

        // Variável global para disponilizar para todas as funções o valor do eixo x. O valor de x é individualmente manipulado somente pela função InterfaceAtualizarParaV_Atual
        int t = 0;
        // Variável para contar o tempo de instabilidade de rede
        int instabilidadeRedeTimer = 0;

        private void ENCERRAR_APLICACAO()
        {
            // Encerra a aplicação juntos de todas as threads em executação (força o encerramento)
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void SEM_INTERNET()
        {
            // Alterações de interface
            this.Enabled = false;            
            toolStripStatusCONEXAO.Text = "Instabilidade de rede";
            timerInstabilidadeRede.Start();
        }                

        private double ColetarValor()
        {
            // Variável criada para coleta do JSON
            string json = "";
            // Variável criada para receber o valor do Bitcoin conforme preferências do usuário que seram tratadas em seguida
            double bitconValor = -1;

#if DEBUG

            return new Random().NextDouble() * (100000 - 1) + 100000;

#endif

            try
            {
                // Tenta baixar o JSON
                json = new System.Net.WebClient().DownloadString("https://blockchain.info/de/ticker");
            }
            catch
            {                
                // Caso não consiga baixar, retornar -1
                return -1;
            }

            // Verifica qual a moeda selecionada pelo usuário e adiciona os dados a variável
            switch (Settings.Default.moeda)
            {
                case "BRL":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).BRL.sell;

                    break;
                case "AUD":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).AUD.sell;

                    break;
                case "USD":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).USD.sell;

                    break;
                case "CAD":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).CAD.sell;

                    break;
                case "CHF":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).CHF.sell;

                    break;
                case "CLP":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).CLP.sell;

                    break;
                case "CNY":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).CNY.sell;

                    break;
                case "DKK":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).DKK.sell;

                    break;
                case "EUR":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).EUR.sell;

                    break;
                case "GBP":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).GBP.sell;

                    break;
                case "HKD":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).HKD.sell;

                    break;
                case "INR":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).INR.sell;

                    break;
                case "ISK":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).ISK.sell;

                    break;
                case "JPY":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).JPY.sell;

                    break;
                case "KRW":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).KRW.sell;

                    break;
                case "NZD":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).NZD.sell;

                    break;
                case "PLN":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).PLN.sell;

                    break;
                case "RUB":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).RUB.sell;

                    break;
                case "SEK":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).SEK.sell;

                    break;
                case "SGD":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).SGD.sell;

                    break;
                case "THB":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).THB.sell;

                    break;
                case "TWD":
                    bitconValor = JsonConvert.DeserializeObject<Atributos_Por_Moeda>(json).TWD.sell;

                    break;
            }

            return bitconValor;
        }

        private double CalcularSomaValoresEixoY()
        {
            double somaElementosEixoY = 0;

            // Soma dos elementos no eixo Y (valor do Bitcoin)
            for (int x = 0; x < chart1.Series[0].Points.Count; x++)
            {
                somaElementosEixoY += chart1.Series[0].Points[x].YValues[0];
            }
            return somaElementosEixoY;
        }

        private void NotificarCrescimento(double x)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Oportunidade de investimento (crescimento)";
            notifyIcon1.BalloonTipText = "Neste momento o Bitcoin está " + x.ToString() + " vez (es) acima da média. Aproveite para investir!";
            notifyIcon1.ShowBalloonTip(5000);
        }

        private void NotificarQueda(double y)
        {
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipTitle = "Oportunidade de investimento (queda)";
            notifyIcon1.BalloonTipText = "Neste momento o Bitcoin está " + y.ToString() + " vez (es) abaixo da média. Aproveite para investir!";
            notifyIcon1.ShowBalloonTip(5000);
        }

        // Coleta, calcula os valores e joga no gráfico
        public async void timerColetarECalcularValor_Tick(object sender, EventArgs e)
        {
            // Recebe o valor atualizado do Bitcoin convertido do JSON
            double v_atual = 0;
            // Variáveis para calculo exibidos na tela                        
            double somaElementosEixoY = 0;
            double media = 0;
            double mediaVezesX = 0;
            double mediaVezesY = 0;
            // Variaveis para gerar relatório final
            int x, l, cresceu, caiu, manteve;
            // Intervalo conta quantos intervalos de k segundos existem no tempo total decorrido
            double intervalo = 0;
            // Regra de negócio: Subtrai 2 do valor espeficado pelo usuário devido dois fatores, primeiro, o t começa em zero e o delay entre os dois timer acarreta no subtração de mais um valor
            int k = Settings.Default.intervalo_timer_relatorio;

            // Próximo (s) intervalo definido pelo intervalo
            x = 0;
            // Anterior (s) baseado intervalo pelo intervalo
            l = 0;

            cresceu = 0;
            caiu = 0;
            manteve = 0;            

            // COLETA OS DADOS

            // Joga os dados coletados em espaço de memória com uso de uma sub tarefa
            if ((v_atual = await Task.Run(() => ColetarValor())).Equals(-1))
            {                
                // Sem acesso à internet
                SEM_INTERNET();

                return;
            }

            timerInstabilidadeRede.Stop();

            if (string.IsNullOrEmpty(dataEHoraInicioAnaliseToolStripMenuItem.Text))
            {
                dataEHoraInicioAnaliseToolStripMenuItem.Text = "Análise iniciada: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            }

            // Interações de interface que não dependem da situação de análise do bitcoin
            toolStripStatusCONEXAO.Text = "Conectado";
            this.Enabled = true;

            // Após terminar a coleta dos dados pelo sub processo, realiza a interação com outros componentes com uso de um subprocesso            
            // Alterações na interface
            // STATUSTRIP, TOOLSTRIPS
            toolStripStatusLabelVALOR_ATUAL.Text = Settings.Default.moeda + " " + v_atual.ToString();

            // CHART
            BeginInvoke((Action)(() => {
                chart1.Series[0].Points.AddXY(t, v_atual);

                // Acrescenta mais um ao x, que por sua vez representa o eixo x do gráfico
                t++;


                // CALCULA E MOSTRA NA TELA OS DADOS COLETADOS, SE, O USUÁRIO DESEJAR
                if (Settings.Default.analisar)
                {
                    // Se o gráfico estiver vazio não existe cálculo para fazer
                    if (chart1.Series[0].Points.Count > 0)
                    {
                        // Soma dos elementos no eixo Y (valor do Bitcoin)
                        somaElementosEixoY = CalcularSomaValoresEixoY();

                        // Cálcula a média: Soma dos elementos no eixo y pelo tempo decorrido (variável global x)
                        media = (somaElementosEixoY / t);
                        // Cálcula o valor que representará o limite entre o produto da média tendendo a crescente do Bitcoin
                        mediaVezesX = (Settings.Default.x * media);
                        // Cálcula o valor que representará o limite entre o produto da média tendendo a queda do Bitcoin
                        mediaVezesY = media - ((Settings.Default.y * media) - media);

                        // Verifica oportunidade de notificação
                        if (v_atual >= mediaVezesX)
                        {
                            ListViewItem item = new ListViewItem();
                            item.UseItemStyleForSubItems = false;
                            item.Text = v_atual.ToString();
                            item.SubItems.Add(media.ToString());
                            item.SubItems.Add(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                            item.SubItems.Add(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                            item.SubItems.Add((v_atual - media).ToString());
                            item.SubItems.Add((((v_atual - media) / media) * 100).ToString() + "%");
                            item.SubItems.Add("Crescimento").BackColor = Color.YellowGreen;
                            item.SubItems[6].ForeColor = Color.White;
                            listView1.Items.Add(item);

                            label2.Visible = false;

                            // Oportunidade de investimento, Bitcoin crescendo
                            chart1.Series[0].Points[t - 1].MarkerStyle = MarkerStyle.Circle;
                            chart1.Series[0].Points[t - 1].MarkerColor = Color.YellowGreen;

                            // Notifica
                            NotificarCrescimento(Settings.Default.x);
                            // Verifica se o usuário optou por incrementar valores em caso de notificação
                            if (Settings.Default.agregar_valores)
                            {
                                if (Settings.Default.x.Equals(1))
                                {
                                    Settings.Default.x = 1.0001;
                                }
                                else
                                {
                                    Settings.Default.x = Settings.Default.x * Settings.Default.x;
                                }

                                Settings.Default.Save();
                            }
                        }
                        else if (Settings.Default.y <= (media / v_atual))
                        {
                            ListViewItem item = new ListViewItem();
                            item.UseItemStyleForSubItems = false;
                            item.Text = v_atual.ToString();
                            item.SubItems.Add(media.ToString());
                            item.SubItems.Add(DateTime.Now.Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                            item.SubItems.Add(DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second);
                            item.SubItems.Add((v_atual - media).ToString());
                            item.SubItems.Add((((v_atual - media) / media) * 100).ToString() + "%");
                            item.SubItems.Add("Queda").BackColor = Color.IndianRed;
                            item.SubItems[6].ForeColor = Color.White;
                            listView1.Items.Add(item);

                            label2.Visible = false;

                            // Oportunidade de investimento, Bitcoin queda                        
                            chart1.Series[0].Points[t - 1].MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
                            chart1.Series[0].Points[t - 1].MarkerColor = Color.IndianRed;

                            // Notifica
                            NotificarQueda(Settings.Default.y);

                            // Verifica se o usuário optou por incrementar valores em caso de notificação
                            if (Settings.Default.agregar_valores)
                            {
                                if (Settings.Default.y.Equals(1))
                                {
                                    Settings.Default.y = 1.0001;
                                }
                                else
                                {
                                    Settings.Default.y = Settings.Default.y * Settings.Default.y;
                                }

                                Settings.Default.Save();
                            }
                        }

                        // Após terminar os cálculos, realiza a interação com outros componentes            
                        // STATUSTRIP, TOOLSTRIPS
                        toolStripStatusLabelMEDIA.Text = "Média: " + media.ToString();

                        // CHART
                        chart1.Series[3].Points.AddXY(t - 1, media);
                        chart1.Series[1].Points.AddXY(t - 1, mediaVezesX);
                        // No gráfico, define a linha que representa o limite entre o produto da média tendendo a queda do Bitcoin. Verifica se o valor de Y é menor que zero, então define o valor como zero para interação de interface
                        if (mediaVezesY <= 0) { mediaVezesY = 0; }
                        chart1.Series[2].Points.AddXY(t - 1, mediaVezesY);

                        // Finaliza a análise com relatorio de percentual de variações

                        // Variável intervalo conta quantos intervalos de k segundos existem no tempo total decorrido
                        intervalo = t / k;
                        if ((Math.Floor(intervalo) > 0) && (t == Math.Floor((k * intervalo))))
                        {
                            while ((x = (x + k)) <= t)
                            {
                                if (chart1.Series[0].Points[x - 1].YValues[0] > chart1.Series[0].Points[l].YValues[0])
                                {
                                    cresceu++;
                                }
                                else if (chart1.Series[0].Points[x - 1].YValues[0] < chart1.Series[0].Points[l].YValues[0])
                                {
                                    caiu++;
                                }
                                else
                                {
                                    manteve++;
                                }

                                // Atualiza o valor de l deixando igual ao x "antigo". O x será agregado na sequencia ao termino deste loop
                                l = x;
                            }

                            // Interação com a interface
                            labelCresceu.Text = ((cresceu / Math.Floor(intervalo)) * 100).ToString("0.00") + "% (" + cresceu.ToString() + "/" + Math.Floor(intervalo).ToString() + ") cresceu";
                            labelCaiu.Text = ((caiu / Math.Floor(intervalo)) * 100).ToString("0.00") + "% (" + caiu.ToString() + "/" + Math.Floor(intervalo).ToString() + ") caiu";
                            labelManteve.Text = ((manteve / Math.Floor(intervalo)) * 100).ToString("0.00") + "% (" + manteve.ToString() + "/" + Math.Floor(intervalo).ToString() + ") manteve";
                            labelCresceu.Refresh();
                            labelCaiu.Refresh();
                            labelManteve.Refresh();
                        }
                    }
                }
            }));
            

#if DEBUG
            if (chart1.Series[0].Points.Count < 30)
            {
                new System.Threading.Thread(() => {
                    timerColetarECalcularValor_Tick(null, EventArgs.Empty);
                }).Start();                
            }

            timerColetarECalcularValor.Stop();
            timerColetarECalcularValor.Enabled = false;
#endif
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Atualiza toda a interface conforme as configurações pré-definidas pelo usuário
            // Inicialização da analise
            if(Settings.Default.analisar)
            {
                notifyIcon1.Text = "Bitcoin Hoje - Análise ativada";
                label1.Text = "Status: Analise ativada";
                //dataEHoraInicioAnaliseToolStripMenuItem.Text = date
                dataEHoraInicioAnaliseToolStripMenuItem.Visible = true;
                if(!Settings.Default.analisar)
                {
                    timerColetarECalcularValor.Stop();
                }                
                button1.Text = "DESATIVAR ANÁLISE";
                button1.BackColor = this.BackColor;
                button1.ForeColor = Color.Black;
                if ((Settings.Default.intervalo_timer_relatorio - 1) > 1) { groupBox1.Text = "Contagem de variações baseadas no intervalo de " + (Settings.Default.intervalo_timer_relatorio - 1).ToString() + " segundos [Em andamento]"; } else { groupBox1.Text = "Contagem de variações baseadas no intervalo de 1 segundo [Em andamento]"; }
                if(string.IsNullOrEmpty(dataEHoraInicioAnaliseToolStripMenuItem.Text))
                {
                    dataEHoraInicioAnaliseToolStripMenuItem.Text = "Análise iniciada: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                }
            }
            else
            {
                notifyIcon1.Text = "Bitcoin Hoje - Análise desativada";
                dataEHoraInicioAnaliseToolStripMenuItem.Text = "";
                label1.Text = "Status: Analise desativada";                
                dataEHoraInicioAnaliseToolStripMenuItem.Visible = false;                           
                button1.Text = "ATIVAR ANÁLISE";
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                groupBox1.Text = "Contagem de variações [análise desativada]";
            }            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ENCERRAR_APLICACAO();
        }

        private void exibirListaDeNotificaçõesToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            listView1.Visible = exibirListaDeNotificaçõesToolStripMenuItem.Checked;
            label2.Visible = exibirListaDeNotificaçõesToolStripMenuItem.Checked;
        }

        private void telaCheiaToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = !(telaCheiaToolStripMenuItem.Checked);
            listView1.Visible = !(telaCheiaToolStripMenuItem.Checked);
            label2.Visible = !(telaCheiaToolStripMenuItem.Checked);
            statusStrip1.Visible = !(telaCheiaToolStripMenuItem.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {                        
            if(button1.Text.Equals("DESATIVAR ANÁLISE"))
            {                
                Settings.Default.analisar = false;
            }
            else
            {                
                Settings.Default.analisar = true;
            }
            Settings.Default.Save();
            Form1_Shown(null, null);
            chart1.Focus();
        }

        private void preferênciasDeNotificaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(new Preferencias().ShowDialog().Equals(DialogResult.Retry))
            {                
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
                chart1.Series[3].Points.Clear();
                labelCresceu.Text = "";
                labelCaiu.Text = "";
                labelManteve.Text = "";
                listView1.Items.Clear();
                t = 0;                                                
            }
            // Atualiza novamente a interação com usuário
            Form1_Shown(null, null);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            preferênciasDeNotificaçõesToolStripMenuItem_Click(null, null);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ENCERRAR_APLICACAO();
        }

        private void graficoEm3DToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].Area3DStyle.Enable3D = graficoEm3DToolStripMenuItem.Checked;
        }

        private void verValoresDoBitcoinNoGráficoToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            chart1.Series[0].IsValueShownAsLabel = verValoresDoBitcoinNoGráficoToolStripMenuItem.Checked;
        }

        private void sobreOBitcoinHojeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(new Sobre().ShowDialog().Equals(DialogResult.OK))
            {
                this.Focus();
            }
        }

        private void timerInstabilidadeRede_Tick(object sender, EventArgs e)
        {
            instabilidadeRedeTimer += 1;
            if(instabilidadeRedeTimer > 1)
            {
                tempoDeInstabilidadeDeRedeToolStripMenuItem.Text = "Tempo de instabilidade de rede: " + instabilidadeRedeTimer.ToString() + " segundos";
            }
            else
            {
                tempoDeInstabilidadeDeRedeToolStripMenuItem.Text = "Tempo de instabilidade de rede: 1 segundo";
            }
            tempoDeInstabilidadeDeRedeToolStripMenuItem.Visible = true;
        }               

        private void chart1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!ModoFibonacci)
                // Modo Fibo desativado
                return;
            if (fiboP1 != 0 && fiboP2 != 0)
                // Valores já definidos
                return;
            
            HitTestResult result = chart1.HitTest(e.X, e.Y);

            if (result != null && result.ChartElementType == ChartElementType.DataPoint && 
                result.Series.Name.Equals(chart1.Series[0].Name))
            {
                var prop = result.Object as DataPoint;                

                if (fiboP1.Equals(0))
                {
                    fiboP1 = prop.YValues[0];
                }                    
                else if(!fiboP1.Equals(prop.YValues[0]))
                {
                    fiboP2 = prop.YValues[0];

                    GerarPercentuaisFibonacci();
                }     
                else
                {
                    return;
                }

                prop.MarkerStyle = MarkerStyle.Star4;
                prop.MarkerSize = 15;
                prop.MarkerColor = Color.Black;
                prop.MarkerBorderColor = Color.Black;
            }
        }

        private bool ModoFibonacci = false;
        private double fiboP1 = 0;
        private double fiboP2 = 0;

        private void GerarPercentuaisFibonacci()
        {
            // Resolver o calculo para listar estes itens
            double delta = fiboP1 - fiboP2; // 100%
            double p618 = fiboP2 + (delta * 0.618);
            double p50 = fiboP2 + (delta * 0.5F);
            double p382 = fiboP2 + (delta * 0.382F);
            double p236 = fiboP2 + (delta * 0.236F);                   
            Color stripColor = Color.LightCoral;
            const short stripBorderWidth = 1;
            const short stripBorderWidthExtremos = 2;
            Font fonte = new Font("Segoe UI Semibold", 5F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

            chart1.ChartAreas[0].AxisY.StripLines.Add(new StripLine()
            {
                IntervalOffset = fiboP1,
                BackColor = stripColor,
                BorderColor = stripColor,
                Text = "100%",
                BorderWidth = stripBorderWidthExtremos,
                BorderDashStyle = ChartDashStyle.DashDot,
                ToolTip = fiboP1.ToString("0.00"),
                Font = fonte,
                ForeColor = stripColor
            });           

            chart1.ChartAreas[0].AxisY.StripLines.Add(new StripLine()
            {                
                IntervalOffset = p618,
                BorderWidth = stripBorderWidth,
                BorderDashStyle = ChartDashStyle.DashDot,
                BackColor = stripColor,
                BorderColor = stripColor,
                Text = "61,8",
                ToolTip = p618.ToString("0.00"),
                Font = fonte,
                ForeColor = stripColor
            });

            chart1.ChartAreas[0].AxisY.StripLines.Add(new StripLine()
            {
                IntervalOffset = p50,
                BorderWidth = stripBorderWidth,
                BorderDashStyle = ChartDashStyle.DashDot,
                BackColor = stripColor,
                BorderColor = stripColor,
                Text = "50%",
                ToolTip = p50.ToString("0.00"),
                Font = fonte,
                ForeColor = stripColor
            });

            chart1.ChartAreas[0].AxisY.StripLines.Add(new StripLine()
            {
                IntervalOffset = p382,
                BorderWidth = stripBorderWidth,
                BorderDashStyle = ChartDashStyle.DashDot,
                BackColor = stripColor,
                BorderColor = stripColor,
                Text = "38,2%",                
                ToolTip = p382.ToString("0.00"),
                Font = fonte,
                ForeColor = stripColor
            });

            chart1.ChartAreas[0].AxisY.StripLines.Add(new StripLine()
            {
                IntervalOffset = p236,
                BorderWidth = stripBorderWidth,
                BorderDashStyle = ChartDashStyle.DashDot,
                BackColor = stripColor,
                BorderColor = stripColor,
                Text = "23,6%",
                ToolTip = p236.ToString("0.00"),
                Font = fonte,
                ForeColor = stripColor
            });

            chart1.ChartAreas[0].AxisY.StripLines.Add(new StripLine()
            {                                
                IntervalOffset = fiboP2,
                BorderWidth = stripBorderWidthExtremos,
                BorderDashStyle = ChartDashStyle.DashDot,
                BackColor = stripColor,
                BorderColor = stripColor,
                Text = "0%",
                ToolTip = fiboP2.ToString("0.00"),
                Font = fonte,
                ForeColor = stripColor
            });            
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if(ModoFibonacci)
            {
                chart1.Cursor = Cursors.Arrow;

                fiboP1 = 0;
                fiboP2 = 0;

                chart1.ChartAreas[0].AxisY.StripLines.Clear();
            }                
            else
            {
                chart1.Cursor = Cursors.Cross;                
            }                

            ModoFibonacci = !ModoFibonacci;

            foreach (var p in chart1.Series[0].Points)
                p.MarkerStyle = MarkerStyle.None;
        }       
    }
}
