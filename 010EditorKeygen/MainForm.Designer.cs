namespace _010EditorKeygen
{
	public partial class MainForm : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.textBox2 = new global::System.Windows.Forms.TextBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.numericUpDown1 = new global::System.Windows.Forms.NumericUpDown();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).BeginInit();
			base.SuspendLayout();
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.textBox1.Location = new global::System.Drawing.Point(85, 12);
			this.textBox1.MaxLength = 14;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new global::System.Drawing.Size(144, 23);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "UserName";
			this.textBox1.TextChanged += new global::System.EventHandler(this.textBox1_TextChanged);
			this.textBox2.Font = new global::System.Drawing.Font("Microsoft YaHei UI", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.textBox2.Location = new global::System.Drawing.Point(12, 68);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new global::System.Drawing.Size(209, 23);
			this.textBox2.TabIndex = 1;
			this.button1.Location = new global::System.Drawing.Point(12, 97);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Copy";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.numericUpDown1.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.numericUpDown1.Location = new global::System.Drawing.Point(12, 41);
			global::System.Windows.Forms.NumericUpDown numericUpDown = this.numericUpDown1;
			int[] array = new int[4];
			array[0] = 1000;
			numericUpDown.Maximum = new decimal(array);
			global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.numericUpDown1;
			int[] array2 = new int[4];
			array2[0] = 1;
			numericUpDown2.Minimum = new decimal(array2);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new global::System.Drawing.Size(49, 23);
			this.numericUpDown1.TabIndex = 3;
			this.numericUpDown1.Tag = "";
			global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.numericUpDown1;
			int[] array3 = new int[4];
			array3[0] = 1000;
			numericUpDown3.Value = new decimal(array3);
			this.numericUpDown1.ValueChanged += new global::System.EventHandler(this.numericUpDown1_ValueChanged);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.label1.Location = new global::System.Drawing.Point(67, 43);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(39, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "users";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("微软雅黑", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 134);
			this.label2.Location = new global::System.Drawing.Point(9, 15);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(70, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Username:";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 12f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(247, 128);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox2);
			base.Controls.Add(this.textBox1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.MaximizeBox = false;
			base.Name = "MainForm";
			this.Text = "010EditorKeygen";
			base.TopMost = true;
			base.Load += new global::System.EventHandler(this.MainForm_Load);
			((global::System.ComponentModel.ISupportInitialize)this.numericUpDown1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.TextBox textBox1;

		private global::System.Windows.Forms.TextBox textBox2;

		private global::System.Windows.Forms.Button button1;

		private global::System.Windows.Forms.NumericUpDown numericUpDown1;

		private global::System.Windows.Forms.Label label1;

		private global::System.Windows.Forms.Label label2;
	}
}
