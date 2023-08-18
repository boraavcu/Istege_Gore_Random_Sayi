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

        private void Uret_Click(object sender, EventArgs e)
        {

            int t2, t3, t4, t5, t6, t7;
            listBox1.Items.Clear();
            Random random = new Random();

            /* Metin Kutularýnýn Ýçeriðini Tamsayýya Dönüþtürmeye Çalýþýr Eðer Baþarýsýz Olursa Uyarý Vericektir Ve
               Ýþlem Yapmayacaktýr.*/
            if (!int.TryParse(textBox2.Text, out t2) ||
                !int.TryParse(textBox3.Text, out t3) ||
                !int.TryParse(textBox4.Text, out t4) ||
                !int.TryParse(textBox5.Text, out t5) ||
                !int.TryParse(textBox6.Text, out t6) ||
                !int.TryParse(textBox7.Text, out t7))
            {
                MessageBox.Show("Lütfen Gerekli Bütün Alanlarý Doldurunuz.");
                return;
            }

            /* Random Üretme Kurallarýna Göre Girilecek Ýlk Sayý Ýkinci Sayýdan Büyük Olamayacaðý
               Ýçin Aþaðýdaki ÝF Bloðu Bu Durumu Kontrol Etmektedir.*/
            if (t2 < t3 && t4 < t5 && t6 < t7)
            {
                int sayi1 = random.Next(t2, t3 + 1);
                int sayi2 = random.Next(t4, t5 + 1);
                int sayi3 = random.Next(t6, t7 + 1);
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

        private void Kopyala_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Lütfen Sayý Üretiniz.");
            }
            else
            {
                string combinedData = string.Join(Environment.NewLine, listBox1.Items.Cast<string>());
                Clipboard.SetText(combinedData);
                listBox1.BackColor = Color.LightGreen;
            }
        }


        private void Temizle_Click(object sender, EventArgs e)
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

        private void SadeceSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

