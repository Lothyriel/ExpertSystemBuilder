using RuleEngine.Domain;

namespace WindowsForms.ExpertSystemForms
{
    public partial class VariableCreate : Form
    {
        private HashSet<string> ObjectiveValues { get; } = new();
        private ESBuilder ESBuilder { get; }

        public VariableCreate(ESBuilder eSBuilder)
        {
            InitializeComponent();
            cb_Type.Items.Add(VariableType.Numeric);
            cb_Type.Items.Add(VariableType.Binary);
            cb_Type.Items.Add(VariableType.Objective);
            cb_Type.SelectedIndex = 0;

            ESBuilder = eSBuilder;
            ChangeObjectiveValuesVisibility(false);
        }

        private void ChangeObjectiveValuesVisibility(bool visible)
        {
            var tagControls = new List<Control>();
            foreach (Control control in Controls)
            {
                if ((string)control.Tag == "ObjectiveValue")
                    tagControls.Add(control);
            }
            tagControls.ForEach(control => control.Visible = visible);
        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            var variable = Value.CreateValue((VariableType)cb_Type.SelectedItem, tb_Name.Text, tb_Value.Text, ObjectiveValues);
            if (variable == null)
            {
                Utils.InvalidValueTypeMessage((VariableType)cb_Type.SelectedItem);
                return;
            }
            ESBuilder.Variables.Add(variable);
            MainScreen.Instance!.OpenFormPanel(new ESEdit(ESBuilder));
        }

        private void cb_Type_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeObjectiveValuesVisibility(cb_Type.SelectedItem is VariableType.Objective);
        }
    }
}