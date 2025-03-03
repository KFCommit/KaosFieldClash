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

            string path = "Data/questions.json";

            List<Question> question = Json.Load<Question>(path);

            De de = new De();

            de.ViewDice(de.RollDice(), pbDe);
        }
    }
}
