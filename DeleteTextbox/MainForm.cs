/*
 * Created by SharpDevelop.
 * User: Abe
 * Date: 04.05.2013
 * Time: 12:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DeleteTextbox
{
	/// <summary>
	/// Automatically delete textbox if textbox.text = empty on focus leave
	/// http://stackoverflow.com/questions/16345549
	/// </summary>
	public partial class MainForm : Form
	{
		
		List<TextBox> textboxList = new List<TextBox>();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		void TextBox_LeaveEvent(object sender, EventArgs e)
		{
			var tb = sender as TextBox;		
			// add another textbox if this tb has text			
			if(textboxList.Count<5 && tb.Text.Length>0){
				var newTextBox = getNewTextBox(textboxList.Count);			
				textboxList.Add(newTextBox);
			} // remove textbox if it has no text
			else if(tb.Text.Length == 0){
				RemoveTextBox(tb);
			}						
		}
		
		
		TextBox getNewTextBox(int i)
		{
			var tb = new TextBox();
			tb.Location = new System.Drawing.Point(220, 90 + i * 24);
			tb.Name = "tb_" + i.ToString();
			tb.Size = new System.Drawing.Size(80,20);
			tb.TabIndex = i + 2;
			btnSave.TabIndex = i + 3;
			tb.Text = i.ToString(); //String.Empty;						
			tb.Leave += new System.EventHandler(this.TextBox_LeaveEvent);
			this.Controls.Add(tb);
			this.Refresh();
			return tb;
		}
		
		void RemoveTextBox(TextBox tb){								
				// this.Controls.RemoveByKey(tb.Name);				
				int tbIndex = this.Controls.IndexOf(tb);
				this.Controls[tbIndex].Dispose();
				textboxList.Remove(tb);			
		}
		
		
		void Button_Enter(object sender, EventArgs e)
		{
			// RemoveEmptyTextBox
			// get last Textbox in List
			var tb = textboxList[textboxList.Count-1];
			label1.Text = "Last Textbox in List: " + tb.Name + " (" + tb.Text.Length +")";
			if(tb.Text.Length==0){
				// this.Controls.RemoveByKey(tb.Name);				
				int tbIndex = this.Controls.IndexOf(tb);
				this.Controls[tbIndex].Dispose();
				textboxList.Remove(tb);
			}
		}		
	}
}
