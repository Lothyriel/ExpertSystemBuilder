using RuleEngine.Domain;
using RuleEngine.Domain.ValueTypes;

namespace WindowsForms.ExpertSystemForms
{
    public partial class RuleCreate : Form
    {
        public RuleCreate(ESBuilder eSBuilder)
        {
            InitializeComponent();
            ESBuilder = eSBuilder;

            cb_OperationTypes.Items.Add(OperatorType.Equals);
            cb_OperationTypes.Items.Add(OperatorType.NotEquals);
            cb_OperationTypes.Items.Add(OperatorType.Lesser);
            cb_OperationTypes.Items.Add(OperatorType.Greater);
            cb_OperationTypes.Items.Add(OperatorType.LesserOrEquals);
            cb_OperationTypes.Items.Add(OperatorType.GreaterOrEquals);
            cb_OperationTypes.SelectedIndex = 0;

            cb_Variables.DataSource = eSBuilder.Variables;

            bt_Create.Enabled = false;
        }

        public ESBuilder ESBuilder { get; }
        
        private void bt_Create_Click(object sender, EventArgs e)
        {
            var variable = (Value)cb_Variables.SelectedItem;
            var objectiveValues = variable is ObjectiveValue objValue ? objValue.PossibleValues : new();
            var value = Value.CreateValue(variable.Type, $"Target of {variable.Name}", tb_TargetValue.Text, objectiveValues);

            if (value == null)
            {
                Utils.InvalidValueTypeMessage(variable.Type);
                return;
            }
            ESBuilder.Variables.Add(value);
            MainScreen.Instance!.OpenFormPanel(new ESEdit(ESBuilder));
        }

        private void tb_TargetValue_TextChanged(object sender, EventArgs e)
        {
            bt_Create.Enabled = tb_TargetValue.Text != "";
        }
    }
}
