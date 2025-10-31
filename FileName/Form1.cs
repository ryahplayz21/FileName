using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                FrmFileName frmFileName = new FrmFileName();
                frmFileName.ShowDialog();

                string getInput = txtInput.Text;
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, FrmFileName.SetFileName)))
                {
                    outputFile.WriteLine(getInput);
                }

                MessageBox.Show("File created successfully in your Documents folder!");
            }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegistration frmReg = new FrmRegistration();
            frmReg.ShowDialog();
        }
    }
    
}
