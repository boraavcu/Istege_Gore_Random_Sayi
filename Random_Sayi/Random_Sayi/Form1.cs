namespace Random_Sayi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random random = new Random();

            if (Convert.ToInt32(textBox2.Text) < Convert.ToInt32(textBox3.Text) &&
                Convert.ToInt32(textBox4.Text) < Convert.ToInt32(textBox5.Text) &&
                Convert.ToInt32(textBox6.Text) < Convert.ToInt32(textBox7.Text))
            {

                int sayi1 = random.Next(Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text) + 1);
                int sayi2 = random.Next(Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox5.Text) + 1);
                int sayi3 = random.Next(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text) + 1);
                listBox1.Items.Add(textBox1.Text + " " + sayi1 + " , " + sayi2 + " , " + sayi3);
                textBox3.BackColor = Color.White;
                textBox5.BackColor = Color.White;
                textBox7.BackColor = Color.White;
                listBox1.BackColor = Color.White;

            }
            else
            {
                MessageBox.Show("Ýkinci Sayýlar Ýlk Sayýlardan Büyük Olmalýdýr.");
                textBox3.BackColor = Color.Red;
                textBox5.BackColor = Color.Red;
                textBox7.BackColor = Color.Red;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string combinedData = string.Join(Environment.NewLine, listBox1.Items.Cast<string>());
            Clipboard.SetText(combinedData);
            listBox1.BackColor = Color.LightGreen;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}