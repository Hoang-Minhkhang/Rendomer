namespace Rendomer
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			label4 = new Label();
			label5 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.Location = new Point(13, 6);
			label1.Name = "label1";
			label1.Size = new Size(313, 37);
			label1.TabIndex = 0;
			label1.Text = "Trình tạo số ngẫu nhiên ";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 13F);
			label2.Location = new Point(22, 56);
			label2.Name = "label2";
			label2.Size = new Size(61, 25);
			label2.TabIndex = 1;
			label2.Text = "Từ số ";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 13F);
			label3.Location = new Point(22, 94);
			label3.Name = "label3";
			label3.Size = new Size(49, 25);
			label3.TabIndex = 2;
			label3.Text = "Đến ";
			// 
			// textBox1
			// 
			textBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBox1.Location = new Point(89, 59);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(386, 35);
			textBox1.TabIndex = 3;
			textBox1.Text = "1";
			// 
			// textBox2
			// 
			textBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBox2.Location = new Point(89, 100);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(386, 35);
			textBox2.TabIndex = 4;
			textBox2.Text = "39";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 13F);
			label4.Location = new Point(22, 160);
			label4.Name = "label4";
			label4.Size = new Size(182, 25);
			label4.TabIndex = 5;
			label4.Text = "Số may mắn chính là ";
			label4.Click += label4_Click;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI Semibold", 58F, FontStyle.Bold);
			label5.Location = new Point(292, 184);
			label5.Name = "label5";
			label5.Size = new Size(106, 104);
			label5.TabIndex = 6;
			label5.Text = "--";
			// 
			// button1
			// 
			button1.BackColor = Color.Lime;
			button1.FlatStyle = FlatStyle.Popup;
			button1.Font = new Font("Segoe UI", 11F);
			button1.Location = new Point(307, 141);
			button1.Name = "button1";
			button1.Size = new Size(168, 44);
			button1.TabIndex = 7;
			button1.Text = "START ";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(597, 368);
			Controls.Add(button1);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Rendomer VERISON 1.0 by Hoang-MinhKhang";
			Load += Form1_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private TextBox textBox1;
		private TextBox textBox2;
		private Label label4;
		private Label label5;
		private Button button1;
	}
}
