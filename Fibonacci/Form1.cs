namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> lista = new List<Sor>();

            for (int i = 0; i < 10; i++)
            {
                Button aha = new Button();
                aha.Text = Fibonacci(i).ToString();
                

                aha.Top = i * 25;

                Controls.Add(aha);
                //---

                Sor újSor = new Sor();
                újSor.Érték = Fibonacci(i);
                újSor.Sorszám = i;
                lista.Add(újSor);
            }

            dataGridView1.DataSource = lista;


        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
