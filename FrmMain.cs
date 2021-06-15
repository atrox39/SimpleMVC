using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleMVC.Controler;

namespace SimpleMVC
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            Test test_controller = new Test();
            test_controller.Insert("Carlos Eduardo", "Ortega Frias", 23);
        }
    }
}
