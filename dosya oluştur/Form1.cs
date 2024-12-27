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

namespace dosya_oluştur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "dosya öğrneği.txt";
            string content = "bugün hava çok güzel";
            File.WriteAllText(path, content);
            string içerik = File.ReadAllText(path);
            içerik += "  'n/'ek satır";
            içerik += "yeniii";
            File.WriteAllText(path, içerik);

            string deneme = File.ReadAllText(path);
            string[] ekle = { "deneme yaptım", "deneme ", " deneme" };
            foreach (string str in ekle)
                File.WriteAllLines(path, ekle);

        }
    }
}
