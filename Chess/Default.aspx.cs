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
        private src.Game game;

        protected void Page_Load(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "How about a game of chess?";
        }

        protected void TerminalButton_Click(object sender, EventArgs e)
        {
            TerminalOutput.Text += TerminalInput.Text + "\n";
            string tmp = TerminalInput.Text;
            TerminalInput.Text = "";
            game.setNewPlayerInput(tmp);
        }

        protected void StartButton_Click(object sender, EventArgs e)
        {
            game = new src.Game(putString);
            PlayerWhiteAgentList.Enabled = false;
            PlayerBlackAgentList.Enabled = false;
            StartButton.Enabled = false;
            game.start(PlayerWhiteAgentList.SelectedValue, PlayerBlackAgentList.SelectedValue);
        }

        private void putString(string s)
        {
            TerminalOutput.Text += s + "\n";
        }
    }
}