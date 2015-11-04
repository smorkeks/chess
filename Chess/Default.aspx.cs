using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Chess
{
    public partial class Default : System.Web.UI.Page
    {
        src.Game game;

        protected void Page_Load(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello, world! How about a game of chess?";
            game = new src.Game();
        }

        protected void TerminalButton_Click(object sender, EventArgs e)
        {
            TerminalOutput.Text += TerminalInput.Text + "\n";
            TerminalInput.Text = "";

        }
    }
}