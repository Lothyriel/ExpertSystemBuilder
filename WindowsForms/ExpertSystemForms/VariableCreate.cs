using RuleEngine.Domain;

namespace WindowsForms.ExpertSystemForms
{
    public partial class VariableCreate : Form
    {
        private HashSet<string> ObjectiveValues { get; } = new();
        private List<Value> Variables { get; }

        public VariableCreate(List<Value> variables)
        {
            InitializeComponent();
            for (VariableType i = VariableType.Numeric; i < VariableType.Objective; i++)
            {
                cb_Type.Items.Add(i);
            }

            Variables = variables;
            HideObjectiveValues();
        }

        private void HideObjectiveValues()
        {
            var tagControls = new List<Control>();
            foreach (Control control in Controls)
            {
                if ((string)control.Tag == "ObjectiveValue")
                    tagControls.Add(control);
            }
            tagControls.ForEach(control => control.Visible = false);
        }

        private void bt_Create_Click(object sender, EventArgs e)
        {
            var variable = Value.CreateValue((VariableType)cb_Type.SelectedItem, tb_Value.Text, ObjectiveValues);
            if (variable == null)
            {
                MessageBox.Show("Valores inválidos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Variables.Add(variable);
        }
    }
}