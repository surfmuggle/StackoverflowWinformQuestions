/*
 * Created by SharpDevelop.
 * User: Abe
 * Date: 04.05.2013
 * Time: 14:36
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TextBoxMaskInput
{
	/// <summary>	
	/// Dynamic mask textbox money Input
	/// http://stackoverflow.com/questions/15989717/
	/// </summary>
	public partial class TextBoxMaskedInput : Form
	{
		public TextBoxMaskedInput()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
						
		}
		
		//this only allow numbers and "." and "," on textimbox imput
	    private void Textbox_KeyPressEvent(object sender, KeyPressEventArgs e)
	    {
	    	// TODO: difference in cultures regarding decimal seperator "." vs. ","
	    	// 		us 1,000.20 onethousand and 20 cent 
	    	// 		eu 1.000,20 onethousand and 20 cent
	    	var keyChar = e.KeyChar;
	    	var tbText = (sender as TextBox).Text;
	        if (!char.IsControl(keyChar)
	    		&& !char.IsDigit(keyChar)
	    		&& keyChar != '.' && keyChar != ',')     		
	        {
	            e.Handled = true;
	        }
	
	        // only allow one decimal point
	        if (keyChar == '.' && tbText.IndexOf('.') > -1)
	        {
	            e.Handled = true;
	        }          
	        if(keyChar == ',' && tbText.IndexOf(',') > -1){
	           e.Handled = true;
	        }
	    }// Textbox_KeyPressEvent
	    
	    private void TextBox_LeaveEvent(object sender, EventArgs e)
	    {
	    	var tb = sender as TextBox;
	    	var tbText = tb.Text;
	    	
	    	if(tbText.IndexOf(" ") !=-1){
	    		MessageBox.Show("without CurrencyFormationg: " + RemoveCurrencyFormating(tbText));	
	    		// var temp = String.Format("{0:D0}", tbText2);					   
	    	}
	    	
	    	
	    	if(tbText.Length>0 && tbText.IndexOf(" ") == -1){
	    		decimal cubic = Convert.ToDecimal(tbText); 
	        	tb.Text = string.Format("{0:c}", Convert.ToDecimal(cubic));
	        	label1.Text = tb.Text;
	    	}
	    }
    
		
		void TextBox_EnterEvent(object sender, EventArgs e)
		{
			var tb = sender as TextBox;
			tb.Text = RemoveCurrencyFormating(tb.Text);
		}
		
		/// <summary>
		/// Remove currency from an input string
		/// </summary>
		/// <param name="moneyWithCurrency"></param>
		/// <returns>String.Format("{0:D0}, inputString)</returns>
		string RemoveCurrencyFormating(string moneyWithCurrency){

			if(moneyWithCurrency.IndexOf(" ") !=-1)
			{
	    		var moneyWithOutCurrencyFormating = moneyWithCurrency.Substring(0, moneyWithCurrency.IndexOf(" ")-1);	    	
	    		return String.Format("{0:D0}", moneyWithOutCurrencyFormating);				
	    	}
			return "";
		}// RemoveCurrencyFormating
	}// end of class
}
