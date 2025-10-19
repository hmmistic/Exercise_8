using System.Windows.Forms;

namespace Imtahan_sistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int i = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            bool isValid = true;
            int result = 0;
            int.TryParse(maskedTextBox1.Text, out int sdf1);
            int.TryParse(maskedTextBox5.Text, out int sdf2);
            int.TryParse(maskedTextBox4.Text, out int ff);
            int.TryParse(maskedTextBox3.Text, out int seminar);
            int.TryParse(maskedTextBox2.Text, out int final);

            if (sdf1 > 10 || String.IsNullOrEmpty(maskedTextBox1.Text))
            {
                errorProvider1.SetError(maskedTextBox1, "SDF1 balı boş, yaxud 10-dan yuxarı ola bilməz.");
                isValid = false;
            }

            else errorProvider1.SetError(maskedTextBox1, null);

            if (sdf2 > 10 || String.IsNullOrEmpty(maskedTextBox5.Text))
            {
                errorProvider2.SetError(maskedTextBox5, "SDF2 balı boş, yaxud 10-dan yuxarı ola bilməz.");
                isValid = false;
            }

            else errorProvider2.SetError(maskedTextBox5, null);

            if (ff > 10 || String.IsNullOrEmpty(maskedTextBox4.Text))
            {
                errorProvider3.SetError(maskedTextBox4, "FF balı boş, yaxud 10-dan yuxarı ola bilməz.");
                isValid = false;
            }

            else errorProvider3.SetError(maskedTextBox4, null);

            if (seminar > 20 || String.IsNullOrEmpty(maskedTextBox3.Text))
            {
                errorProvider4.SetError(maskedTextBox3, "Seminar balı boş, yaxud 20-dən yuxarı ola bilməz.");
                isValid = false;
            }

            else errorProvider4.SetError(maskedTextBox3, null);

            if (final > 50 || String.IsNullOrEmpty(maskedTextBox2.Text))
            {
                errorProvider5.SetError(maskedTextBox2, "Final balı boş, yaxud 50-dən yuxarı ola bilməz.");
                isValid = false;
            }

            else errorProvider5.SetError(maskedTextBox2, null);

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                errorProvider6.SetError(textBox1, "Tələbənin adı və soyadı boş saxlanıla bilməz.");
                isValid = false;
            }

            else errorProvider6.SetError(textBox1, null);

            if (String.IsNullOrEmpty(maskedTextBox6.Text))
            {
                errorProvider7.SetError(maskedTextBox6, "Tələbə nömrəsi boş saxlanıla bilməz.");
                isValid = false;
            }

            else errorProvider7.SetError(maskedTextBox6, null);

            if (isValid)
            {
                result = sdf1 + sdf2 + ff + seminar + final;
                listBox1.Items.Add(i);
                listBox2.Items.Add(textBox1.Text);
                listBox3.Items.Add(maskedTextBox6.Text);
                listBox4.Items.Add(result);
                i++;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 1;
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            listBox4.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }
    }
}
