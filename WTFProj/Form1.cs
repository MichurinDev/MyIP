using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace WTFProj
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Получение имени компьютера
            String host = System.Net.Dns.GetHostName();

            // Получение IPv4 и IPv6
            System.Net.IPAddress ipv6 = System.Net.Dns.GetHostEntry(host).AddressList[0];
            System.Net.IPAddress ipv4 = System.Net.Dns.GetHostEntry(host).AddressList[1];

            // Отображаем в label'ах
            Username_lbl.Text = host;
            IPv6_lbl.Text = ipv6.ToString();
            IPv4_lbl.Text = ipv4.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Копируем значение
            Clipboard.SetText(
                "Username: " + Username_lbl.Text + "\n" + 
                "IPv4: " + IPv4_lbl.Text + "\n" +
                "IPv6: " + IPv6_lbl.Text);

            // Выводим уведомление об успешном копировании
            MessageBox.Show(
                "Values is Copy!", "Complited",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Открывает ссылку на GitHub разработчика
            ProcessStartInfo GH_link = new ProcessStartInfo("https://github.com/MichurinDev");
            Process.Start(GH_link);
        }
    }
}
