namespace Rendomer
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

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				int min = int.Parse(textBox1.Text);
				int max = int.Parse(textBox2.Text);

				if (min > max)
				{
					MessageBox.Show("Giá trị bắt đầu phải nhỏ hơn hoặc bằng giá trị kết thúc!");
					return;
				}

				Random rnd = new Random();
				int ketQua = rnd.Next(min, max + 1); // max + 1 để lấy cả giá trị cuối

				label5.Text = ketQua.ToString();
			}
			catch
			{
				MessageBox.Show("Vui lòng nhập số hợp lệ!");
			}

		}
	}
}
