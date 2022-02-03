using RuleEngine.Domain;
using static System.Windows.Forms.Control;

namespace WindowsForms
{
    public class Utils
    {
        public static void InvalidValueTypeMessage(VariableType variableType)
        {
            MessageBox.Show($"Invalid value for the type {variableType}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}