using System;
using System.Drawing;
using System.Windows.Forms;
using Bitcoin_Hoje.Properties;

namespace Bitcoin_Hoje
{
    public partial class Preferencias : Form
    {
        public Preferencias()
        {
            InitializeComponent();
        }

        private bool ValidarCampos()
        {
            if(string.IsNullOrEmpty(comboBox1.Text))
            {
                if(MessageBox.Show("Campo Moeda está vázio. Selecione uma moeda clicando em expandir.", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                {
                    comboBox1.Focus();

                    return false;
                }
            }
            else if (string.IsNullOrEmpty(textBox1.Text))
            {
                if (MessageBox.Show("Campo Contagem de variações está vázio.", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                {
                    textBox1.Focus();

                    return false;
                }
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                if (MessageBox.Show("Campo Notificações em crescente está vázio.", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                {
                    textBox2.Focus();

                    return false;
                }
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                if (MessageBox.Show("Campo Notificações em decrescente está vázio.", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                {
                    textBox3.Focus();

                    return false;
                }
            }
            else if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                if (MessageBox.Show("Moeda inserida não disponível.", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                {
                    comboBox1.Focus();

                    return false;
                }
            }
            else
            {
                textBox2.Text = textBox2.Text.Replace(".", ",");
                textBox3.Text = textBox3.Text.Replace(".", ",");
                textBox2.Refresh();
                textBox3.Refresh();
                try
                {
                    if(Convert.ToInt32(textBox1.Text) < 1)
                    {
                        if (MessageBox.Show("Campo Contagem de variações não pode ser menor que 1 (um).", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                        {
                            textBox1.Focus();

                            return false;
                        }
                    }
                }
                catch
                {
                    if (MessageBox.Show("Campo Contagem de variações foi preenchido incorretamente. Exemplo: 20", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                    {
                        textBox1.Focus();

                        return false;
                    }
                }
                try
                {
                    if (Convert.ToDouble(textBox2.Text) < 1)
                    {
                        if (MessageBox.Show("Campo Notificação em crescente não pode ser menor que 1 (um).", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                        {
                            textBox1.Focus();

                            return false;
                        }
                    }                    
                }
                catch
                {
                    if (MessageBox.Show("Campo Notificação em crescente foi preenchido incorretamente. Exemplo: 1,0003", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                    {
                        textBox2.Focus();

                        return false;
                    }
                }
                try
                {
                    if (Convert.ToDouble(textBox3.Text) < 1)
                    {
                        if (MessageBox.Show("Campo Notificação em decrescente não pode ser menor que 1 (um).", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                        {
                            textBox1.Focus();

                            return false;
                        }
                    }
                }
                catch
                {
                    if (MessageBox.Show("Campo Notificação em decrescente foi preenchido incorretamente. Exemplo: 1,0003", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
                    {
                        textBox3.Focus();

                        return false;
                    }
                }
            }

            return true;
        }

        private void Preferencias_Load(object sender, EventArgs e)
        {
            if(Settings.Default.analisar)
            {
                button1.Text = "DESATIVAR ANÁLISE";
                button1.BackColor = panel1.BackColor;
                panel2.Enabled = true;
                panel3.Enabled = true;
                panel4.Enabled = true;
            }
            else
            {
                button1.Text = "ATIVAR ANÁLISE";
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                this.AcceptButton = button1;
            }            
            comboBox1.Text = Settings.Default.moeda;
            textBox1.Text = (Settings.Default.intervalo_timer_relatorio - 1).ToString();
            textBox2.Text = Settings.Default.x.ToString();
            textBox3.Text = Settings.Default.y.ToString();
            checkBox1.Checked = Settings.Default.agregar_valores;
            button2.Enabled = false;
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            if (Settings.Default.analisar)
            {
                button1.Text = "ATIVAR ANÁLISE";
                button1.BackColor = Color.Green;
                button1.ForeColor = Color.White;
                panel2.Enabled = false;
                panel3.Enabled = false;
                panel4.Enabled = false;                
            }
            else
            {
                button1.Text = "DESATIVAR ANÁLISE";
                button1.ForeColor = Color.Black;
                button1.BackColor = panel1.BackColor;
                panel2.Enabled = true;
                panel3.Enabled = true;
                panel4.Enabled = true;                
            }  
            
            if(MessageBox.Show("Clique no botão Salvar para completar a alteração.", "Preferências", MessageBoxButtons.OK, MessageBoxIcon.Information).Equals(DialogResult.OK))
            {
                this.AcceptButton = button2;
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }        

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.OK;

            if(ValidarCampos())
            {
                if(comboBox1.Text != Settings.Default.moeda)
                {
                    if(MessageBox.Show("Tipo de moeda alterada, para continuar será necessário zerar o gráfico. Deseja realmente prosseguir?", "Preferências", MessageBoxButtons.YesNo, MessageBoxIcon.Question).Equals(DialogResult.Yes))
                    {
                        // Tipo de moeda diferente do que a em uso. Zera o gráfico retornando DialogResult.Retry
                        result = DialogResult.Retry;
                    }                    
                    else
                    {
                        this.Focus();
                        return;
                    }
                }
                
                // Salva as alterações
                if(button1.Text.Equals("ATIVAR ANÁLISE"))
                {
                    Settings.Default.analisar = false;
                }
                else
                {
                    Settings.Default.analisar = true;
                }
                Settings.Default.moeda = comboBox1.Text;
                Settings.Default.intervalo_timer_relatorio = Convert.ToInt32(textBox1.Text) + 1;
                Settings.Default.x = Convert.ToDouble(textBox2.Text);
                Settings.Default.y = Convert.ToDouble(textBox3.Text);
                Settings.Default.agregar_valores = checkBox1.Checked;
                Settings.Default.Save();

                this.DialogResult = result;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }
    }
}
