using System.Windows.Forms;

namespace W10DebloatingTool
{
    public static class Utils
    {
        public static DialogResult Info(string message, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, Application.ProductName, buttons, MessageBoxIcon.Information);
        }

        public static DialogResult Error(string message, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, Application.ProductName, buttons, MessageBoxIcon.Error);
        }

        public static DialogResult Warning(string message, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, Application.ProductName, buttons, MessageBoxIcon.Warning);
        }

        public static DialogResult Question(string message, MessageBoxButtons buttons = MessageBoxButtons.OK)
        {
            return MessageBox.Show(message, Application.ProductName, buttons, MessageBoxIcon.Question);
        }

        public static bool Prompt(string message, MessageBoxIcon icon = MessageBoxIcon.Question)
        {
            return MessageBox.Show(message, Application.ProductName, MessageBoxButtons.YesNo, icon) == DialogResult.Yes;
        }
    }
}
