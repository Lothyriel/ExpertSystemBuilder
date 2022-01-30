using RuleEngine.Domain;
using WindowsForms.ExpertSystemForms;

namespace WindowsForms
{
    public partial class MainScreen : Form
    {
        public static MainScreen? Instance { get; set; }

        public MainScreen()
        {
            Instance = this;
            InitializeComponent();
            bt_RunSystem.Enabled = false;
        }

        private void ShowForm(Form form)
        {
            form.Show();
            Hide();
        }

        #region Events

        private void bt_RunSystem_Click(object sender, EventArgs e)
        {
            ShowForm(new ESRun((ExpertSystem)lb_ExpertSystems.SelectedItem));
        }

        private void lb_ExpertSystems_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = lb_ExpertSystems.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                ShowForm(new ESEdit((ExpertSystem)lb_ExpertSystems.SelectedItem));
            }
        }

        private void lb_ExpertSystems_MouseClick(object sender, MouseEventArgs e)
        {
            if (lb_ExpertSystems.SelectedItem != null)
            {
                bt_RunSystem.Enabled = true;
            }
        }

        private void bt_CreateSystem_Click(object sender, EventArgs e)
        {
            ShowForm(new ESCreate());
        }

        #endregion
    }
}