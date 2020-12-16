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

namespace MiniRPGLikeTESO
{
    public partial class HistoriForm : Form
    {
        public HistoriForm()
        {
            InitializeComponent();
            ReadFile();
        }

        void ReadFile()
        {
            string path = @"Player.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                richTextBox1.Text += $"Текст из файла:\n {sr.ReadToEnd()}";
            }
        }
    }
}
