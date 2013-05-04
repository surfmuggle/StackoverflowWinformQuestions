/*
 * Created by SharpDevelop.
 * User: Abe
 * Date: 04.05.2013
 * Time: 13:45
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DeclareTextBoxValue
{
	/// <summary>
	/// How to declare Textbox value (using Controls.Find) in public partial class without error?
	/// http://stackoverflow.com/questions/16348428
	/// </summary>
	public partial class MainForm : Form
	{
		
		private List<TextBox> textBoxList = new List<TextBox>();
		
		public MainForm()
		{
			// The InitializeComponent() call is required for Windows Forms designer support.
			InitializeComponent();

		}
		
		void Button1Click(object sender, EventArgs e)
		{			
			var tb = AddTextBox(textBoxList.Count+1);
			textBoxList.Add(tb);
		}
		
		TextBox AddTextBox(int i)
		{
			var tb = new TextBox();
			tb.Location = new System.Drawing.Point(200, 90 + i * 24);
			tb.Name = "txtAcessorio_" + i.ToString();
			tb.Size = new System.Drawing.Size(60,20);
			tb.TabIndex = i + 2;			
			tb.Text = i.ToString(); //String.Empty;						
			
			groupBox1.Controls.Add(tb);			
			groupBox1.Refresh();			
			return tb;
		}
		
		void BtnApagar_ClickClick(object sender, EventArgs e)
		{
			// test if textbox 4 exist by counting the number of added textboxes
			if(textBoxList.Count ==4 || textBoxList.Count > 4){
				
				// access the control during runtime by using the container and the apropriate index 
				// remeber lists and arrays are 0 based --> index 3 is the 4th textbox
				textBoxList[3].Text = DateTime.Now.ToShortTimeString();
				MessageBox.Show("Perfect we have at least 4 boxes and the name is: " + textBoxList[3].Name);
				
				// instead of using (TextBox)gpbCategoria.Controls.Find("txtAcessorio4", false).FirstOrDefault();
				// we can access the list by index to get a certain "future" instance for textbox_4
				
			}else {
				MessageBox.Show("Number of textboxes is not enough - add more");
			}
		}
	}
}
