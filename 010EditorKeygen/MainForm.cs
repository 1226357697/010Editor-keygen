using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _010EditorKeygen
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			this.InitializeComponent();
		}

		private void GenKey()
		{
			new Task(delegate()
			{
				base.BeginInvoke(new MainForm.VoidMethodDelegate(delegate()
				{
					this.textBox2.Text = Keygen.MakeKey(this.textBox1.Text, Convert.ToUInt32(this.numericUpDown1.Value));
				}));
			}).Start();
		}

		private static void Copy2Clipboard(string str)
		{
			Clipboard.Clear();
			Clipboard.SetDataObject(str, true);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				MainForm.Copy2Clipboard(this.textBox2.Text);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			try
			{
				this.GenKey();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				byte[] bytes = Encoding.UTF8.GetBytes(this.textBox1.Text);
				if (bytes.Length >= 15)
				{
					this.textBox1.Text = Encoding.UTF8.GetString(bytes, 0, 14);
					this.textBox1.SelectionStart = this.textBox1.Text.Length;
				}
				this.GenKey();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			try
			{
				this.GenKey();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private delegate void VoidMethodDelegate();
	}
}
