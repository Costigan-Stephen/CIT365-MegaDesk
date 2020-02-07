using System;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void navAddQuote_Click(object sender, EventArgs e)
        {
            AddQuote newquote = new AddQuote();
            newquote.Tag = this;
            try
            {
                newquote.Show(this);
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("The rush order pricing file is missing or corrupted!", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void NavViewQuotes_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewquote = new ViewAllQuotes();
            viewquote.Tag = this;
            viewquote.Show(this);
            Hide();
        }

        private void navSearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes findquote = new SearchQuotes();
            findquote.Tag = this;
            findquote.Show(this);
            Hide();
        }

        public void navShowQuote_ref(string json)
        {
            DisplayQuote viewquote = new DisplayQuote(json);
            viewquote.Tag = this;
            viewquote.Show(this);
            Hide();
        }

        private void navExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
