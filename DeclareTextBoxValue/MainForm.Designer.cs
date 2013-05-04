/*
 * Created by SharpDevelop.
 * User: Abe
 * Date: 04.05.2013
 * Time: 13:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace DeclareTextBoxValue
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.btnApagar_Click = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Location = new System.Drawing.Point(44, 24);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(540, 429);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(619, 413);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(104, 40);
			this.button1.TabIndex = 1;
			this.button1.Text = "add Textbox";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnApagar_Click
			// 
			this.btnApagar_Click.Location = new System.Drawing.Point(619, 477);
			this.btnApagar_Click.Name = "btnApagar_Click";
			this.btnApagar_Click.Size = new System.Drawing.Size(104, 40);
			this.btnApagar_Click.TabIndex = 2;
			this.btnApagar_Click.Text = "btnApagar_Click";
			this.btnApagar_Click.UseVisualStyleBackColor = true;
			this.btnApagar_Click.Click += new System.EventHandler(this.BtnApagar_ClickClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1022, 739);
			this.Controls.Add(this.btnApagar_Click);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "DeclareTextBoxValue";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnApagar_Click;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
