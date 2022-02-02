namespace WindowsForms
{
    public partial class MainScreen : Form
    {
        public static MainScreen? Instance { get; set; }
        public MainScreen()
        {
            Instance = this;
            InitializeComponent();
            OpenFormPanel(new ExpertSystemsView());
        }
        public void OpenFormPanel(Form panelForm)
        {
            panelForm.TopLevel = false;
            panelForm.FormBorderStyle = FormBorderStyle.None;
            panelForm.Dock = DockStyle.Fill;

            Panel.Controls.Clear();
            Panel.Controls.Add(panelForm);

            panelForm.BringToFront();
            panelForm.Show();
        }
    }
}
