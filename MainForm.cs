/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 05/05/2022
 * Time: 21:33
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace blocoDeNota
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

		}
		void Button2Click(object sender, EventArgs e)
		{
			//SALVAR
			richTextBox1.SaveFile(textBox1.Text,RichTextBoxStreamType.PlainText);
		}
		void Button1Click(object sender, EventArgs e)
		{
			//ABRIR
			richTextBox1.LoadFile(textBox1.Text, RichTextBoxStreamType.PlainText);
		}
		void Button3Click(object sender, EventArgs e)
		{
			//limpar
			richTextBox1.Clear();
		}
		
	}
}
