/*
 * Created by SharpDevelop.
 * User: aluno.etec
 * Date: 12/05/2022
 * Time: 22:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BD_AGENda
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Button4Click(object sender, EventArgs e)
		{
			richTextBox1.Text += textBox1.Text + " | " + textBox2.Text + " | " + textBox3.Text + " | " + "\n";
			textBox1.Clear();
			textBox2.Clear();
			textBox3.Clear();
			MessageBox.Show("Registro feito com sucesso.\nSe deseja salvar esse registro, adicione um nome e clique em 'Salvar'");
		}
		void Button3Click(object sender, EventArgs e)
		{
			// LIMPAR
			richTextBox1.Clear();
		}
		void Button5Click(object sender, EventArgs e)
		{
			// consultar
			richTextBox1.LoadFile(textBox4.Text,RichTextBoxStreamType.PlainText);
		}
		void Button2Click(object sender, EventArgs e)
		{
			// salvar
			richTextBox1.SaveFile(textBox4.Text, RichTextBoxStreamType.PlainText);
		} 
	}
}
