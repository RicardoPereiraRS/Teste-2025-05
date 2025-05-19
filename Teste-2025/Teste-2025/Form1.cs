using System.Windows.Forms;
using System.Xml;
using System;
using System.Data.SqlTypes;
using System.Web;
namespace Teste_2025
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Questão 1
        private void Somar()
        {
            listBox1.Items.Clear();
            int indice = 13;
            int soma = 0;
            int k = 0;

            while (k < indice)
            {
                k = k + 1;
                soma = soma + k;
                listBox1.Items.Add("SOMA = " + soma.ToString());

            }
            MessageBox.Show("Valor total da variável soma: " + soma.ToString());
        }

        // Questão 2:

        void VerificarSeNumEFibonacci()
        {
            if (!int.TryParse(txtNumero.Text, out int numeroParaVerificar))
            {
                MessageBox.Show("Verifique o número digitado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int n1 = 0;
            int n2 = 1;
            int proximo;

            while (true)
            {
                proximo = n1 + n2;

                if (numeroParaVerificar == proximo)
                {
                    MessageBox.Show("O número digitado pertence a sequencia Fibonacci.");
                    break;
                }
                if (proximo > numeroParaVerificar)
                {
                    MessageBox.Show("O número digitado não pertence a sequencia Fibonacci.");
                    break;
                }
                n1 = n2;
                n2 = proximo;
            }
        }

        // Questão 3:

        private void ExercicioXmlJson()
        {


            listBox1.Items.Clear();

            string stringDados = File.ReadAllText("dados.xml");
            stringDados = ("<root>" + stringDados + "</root>").Replace(".", ",");
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(stringDados);
            XmlNodeList rowNodes = xmlDoc.SelectNodes("//row");
            List<Row> rows = new List<Row>();

            foreach (XmlNode rowNode in rowNodes)
            {
                Row row = new Row
                {
                    Dia = int.Parse(rowNode["dia"].InnerText),
                    Valor = double.Parse(rowNode["valor"].InnerText)
                };
                rows.Add(row);
            }

            double valorMaximo = rows.Max(item => item.Valor);

            double valorMinimo = rows.Where(item => item.Valor > 0).Min(item => item.Valor);

            double mediaValor = rows.Where(item => item.Valor > 0).Average(item => item.Valor);

            int diasValorMaiorQueMedia = rows.Count(item => item.Valor > mediaValor);

            listBox1.Items.Add("Valor máximo: " + valorMaximo.ToString());
            listBox1.Items.Add("Valor mímimo: " + valorMinimo.ToString());
            listBox1.Items.Add("Dias com valor maior que media: " + diasValorMaiorQueMedia.ToString());
        }

        // Questão 4:
        private void CalcularPercentualRepresentacao()
        {
            listBox1.Items.Clear();

            List<decimal> listaDeValores = new List<decimal> { 67836.43m, 36678.66m, 29229.88m, 27165.48m, 19849.53m };
            List<string> listaDeEstados = new List<string> { "SP", "RJ", "MG", "ES", "Outros" };

            decimal valorTotal = listaDeValores.Sum();

            int contador = 0;

            foreach (decimal valor in listaDeValores)
            {
                decimal percentual = CalcularPercentual(valorTotal, valor);
                listBox1.Items.Add(listaDeEstados[contador] + " - " + percentual.ToString("n4") + " %");
                contador++;
            }



        }

        private decimal CalcularPercentual(decimal valorTotal, decimal valorParcial)
        {
            return (100m * valorParcial) / valorTotal;
        }

        // Questão 5:
        private static void InverterCaracteresDeString()
        {
            string info = "Esta string será exibida de forma invertida.";
            int tamanhoString = info.Length;
            string resultado = String.Empty;

            for (int i = tamanhoString - 1; i >= 0; i--)
            {
                resultado += info[i];
            }

            MessageBox.Show(resultado);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerificarSeNumEFibonacci();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalcularPercentualRepresentacao();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InverterCaracteresDeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Somar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExercicioXmlJson();
        }
    }
}
