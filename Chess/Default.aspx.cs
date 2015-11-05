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
            game = Session["game"] as src.Game;
            if (game == null)
            {
            HelloWorldLabel.Text = "How about a game of chess?";
                game = new src.Game(putString);
            }
            else
            {
                game.run();
            }
            Session["game"] = game;
        }

        protected void TerminalButton_Click(object sender, EventArgs e)
        {
            game = Session["game"] as src.Game;
            TerminalOutput.Text += TerminalInput.Text + "\n";
            string tmp = TerminalInput.Text;
            TerminalInput.Text = "";
            game.setNewPlayerInput(tmp);
            game.run();
            Session["Game"] = game;
        }

        protected void StartButton_Click(object sender, EventArgs e)
        {
            game = Session["game"] as src.Game;
            PlayerWhiteAgentList.Enabled = false;
            PlayerBlackAgentList.Enabled = false;
            StartButton.Enabled = false;
            game.start(PlayerWhiteAgentList.SelectedValue, PlayerBlackAgentList.SelectedValue);
            Session["Game"] = game;
        }

        private void putString(string s)
        {
            TerminalOutput.Text += s + "\n";
        }
    }
}