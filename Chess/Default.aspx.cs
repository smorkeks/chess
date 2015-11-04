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
        private string unreadInput = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            HelloWorldLabel.Text = "Hello, world! How about a game of chess?";
        }

        protected void TerminalButton_Click(object sender, EventArgs e)
        {
            TerminalOutput.Text += TerminalInput.Text + "\n";
            unreadInput = TerminalInput.Text;
            TerminalInput.Text = "";
        }

        protected void StartButton_Click(object sender, EventArgs e)
        {
            putString("Kom igen nu Britt-Marie, kör för fa-an!");
            game = new src.Game(putString, readString);

        }

        private void putString(string s)
        {
            TerminalOutput.Text += s + "\n";
        }

        private string readString()
        {
            putString("1");
            while(unreadInput == "")
            {
                putString("#yolo");
            }
            string tmp = unreadInput;
            unreadInput = "";
            return tmp;
        }
    }
}