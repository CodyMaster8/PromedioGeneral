namespace PromedioGeneral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double cal1, cal2, cal3, cal4, promedio1;
            cal1 = double.Parse(textBox1.Text);
            cal2 = double.Parse(textBox2.Text);
            cal3 = double.Parse(textBox3.Text);
            cal4 = double.Parse(textBox4.Text);
            promedio1 = (cal1 + cal2 + cal3 + cal4) / 4.0;
            {
                if (cal1 < 6.0) MessageBox.Show("REPROBADO");
                else
                    if (cal1 > 6.0) MessageBox.Show("APROBADO");

                if (cal2 < 6.0) MessageBox.Show("REPROBADO");
                else
                    if (cal2 > 6.0) MessageBox.Show("APROBADO");

                if (cal3 < 6.0) MessageBox.Show("REPROBADO");
                else
                    if (cal3 > 6.0) MessageBox.Show("APROBADO");

                if (cal4 < 6.0) MessageBox.Show("REPROBADO");
                else
                    if (cal4 > 6.0) MessageBox.Show("APROBADO");
            }
            {
                if (promedio1 < 6.0) MessageBox.Show("REPROBADO");
                else
                    if (promedio1 > 6.0) MessageBox.Show("APROBADO");
            }
            textBox5.Text = promedio1.ToString();
        }
    }
}