using System.Windows.Forms;

namespace NetControlApp
{
    public static class FormHelpers
    {
        public static void ToggleButtonState(Button button, bool enabled)
        {
            button.Enabled = enabled;
        }

        public static void ShowMessage(string message, string caption = "Information")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static DialogResult ShowConfirmDialog(string message, string caption = "Confirm")
        {
            return MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public static void DisplayError(string message, string caption = "Error")
        {
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
