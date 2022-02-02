using RuleEngine.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms.ExpertSystemForms
{
    public partial class ESEdit : Form
    {
        public ESEdit(ExpertSystem? expertSystem = null)
        {
            expertSystem ??= new ExpertSystem();
            InitializeComponent();
            ExpertSystem = expertSystem;
        }

        private ExpertSystem ExpertSystem { get; }

        private void bt_AddRule_Click(object sender, EventArgs e)
        {
            new RuleCreate().Show();
        }
    }
}
