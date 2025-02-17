using KaosFieldClash.Class;
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

namespace KaosFieldClash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "questions.json");

            List<Question> question = Json.Load<Question>(path);

        }
    }
}
