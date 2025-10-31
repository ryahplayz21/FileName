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
using static System.Net.Mime.MediaTypeNames;

namespace FileName
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string fileName = txtStudNo.Text + ".txt";
                string filePath = Path.Combine(docPath, fileName);

                // Create array of registration details
                string[] info = {
                "Student No.: " + txtStudNo.Text,
                "Full Name: " + txtLName.Text + ", " + txtFName.Text + ", " + txtMI.Text,
                "Program: " + cboProgram.Text,
                "Gender: " + cboGender.Text,
                "Age: " + numAge.Value.ToString(),
                "Birthday: " + dtpBday.Value.ToShortDateString(),
                "Contact No.: " + txtContact.Text
            };

                // Write to text file
                using (StreamWriter outputFile = new StreamWriter(filePath))
                {
                    foreach (string line in info)
                    {
                        outputFile.WriteLine(line);
                    }
                }

                MessageBox.Show("Registration saved as " + fileName);
            }
        }
    }
}
    }
}
