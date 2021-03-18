using System;
using System.Windows.Forms;


namespace MyNotePad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void saveMenuItemClick(object sender, EventArgs e)
        {
            // Saves file.
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Text Documnet(*.txt)|*.txt|All Files(* , *)|";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    rtb.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = sfd.FileName;
            }
            catch
            {
                string message = "Error";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }


        private void openMenuItemClick(object sender, EventArgs e)
        {
            // Opens file.
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Checks if the file is .rtf or .txt.
                    if (ofd.FileName.Substring(ofd.FileName.Length - 3, 3) == "rtf")
                    {
                        rtb.LoadFile(ofd.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        rtb.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                this.Text = ofd.FileName;
            }
            catch
            {
                string message = "Error";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }


        private void copyMenuItemClick(object sender, EventArgs e)
        {
            // Copies text.
            rtb.Copy();
        }


        private void pasteMenuItemClick(object sender, EventArgs e)
        {
            // Pastes text.
            rtb.Paste();
        }


        private void ctrlZClick(object sender, EventArgs e)
        {
            // Cancels the last action.
            rtb.Undo();
        }


        private void ctrlAClick(object sender, EventArgs e)
        {
            // Selects all.
            rtb.SelectAll();
        }


        private void ctrlXClick(object sender, EventArgs e)
        {
            // Cuts.
            rtb.Cut();
        }


        private void exitMenuItemClick(object sender, EventArgs e)
        {
            // Exits the application.
            Environment.Exit(0);
        }


        private void fontClick(object sender, EventArgs e)
        {
            // Changes font.
            try
            {
                FontDialog font = new FontDialog();
                font.Font = rtb.SelectionFont;
                if (font.ShowDialog() == DialogResult.OK)
                {
                    rtb.SelectionFont = font.Font;
                }
            }
            catch
            {
                string message = "Error";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void backClick(object sender, EventArgs e)
        {
            // Chages background appearance.
            try
            {
                ColorDialog color = new ColorDialog();
                if (color.ShowDialog() == DialogResult.OK)
                {
                    rtb.BackColor = color.Color;
                }
            }
            catch
            {
                string message = "Error";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}