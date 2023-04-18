using System;
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
			IPv6_lbl.Text = ipv6.ToString();
            IPv4_lbl.Text = ipv4.ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Копирует значение
			Clipboard.SetText("IPv4: " + IPv4_lbl.Text + "\n" + "IPv6: " + IPv6_lbl.Text);
		}
	}
}
