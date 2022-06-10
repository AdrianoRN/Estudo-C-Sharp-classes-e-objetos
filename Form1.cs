namespace Estudo_C_Sharp_classes_e_objetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Adriano";
            c.saldo = 100;
            c.Deposita(100);

            MessageBox.Show("Saldo:"+c.saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Conta c = new Conta();
            c.numero = 1;
            c.titular = "Adriano";
            c.saldo = 150;
            c.Saca(50);

            MessageBox.Show("Saldo:" + c.saldo);
        }
    }
}