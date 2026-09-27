namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Bos xana", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!userDatabase.ContainsKey(username))
                {
                    MessageBox.Show("Istifadeci qeydiyyat etmeyib", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (userDatabase.ContainsKey(username) && userDatabase.ContainsKey(password))
                    {
                        MessageBox.Show("Sisteme giris olundu", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Yalnis ad ve sifresi", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private Dictionary<string, string> userDatabase = new Dictionary<string, string>();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox4.Text;

            string password = textBox3.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Bos xana", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {
                if (userDatabase.ContainsKey(username))
                {
                    MessageBox.Show("Qeydiyyat olunub", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    MessageBox.Show("Qeydiyyatdan kecildi", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    userDatabase.Add(username, password);
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
        }
    }
}