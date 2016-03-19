using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class FrmMagic8Ball : Form
    {
        static List<string> list;
        static Random rand;

        public FrmMagic8Ball()
        {
            InitList();
            rand = new Random();
            InitializeComponent();
        }

        private void FrmMagic8Ball_Load(object sender, EventArgs e)
        {

        }

        private void BtnGetAnswer_Click(object sender, EventArgs e)
        {
            TBAnswer.Text = GetSaying();
        }

        static void InitList()
        {
            list = new List<string>();
            list.Add("It is certain");
            list.Add("It is decidedly so");
            list.Add("Without a doubt");
            list.Add("Yes, definitely");
            list.Add("You may rely on it");
            list.Add("As I see it, yes");
            list.Add("Most likely");
            list.Add("Outlook good");
            list.Add("Yes");
            list.Add("Signs point to yes");
            list.Add("Replay hazy try again");
            list.Add("Ask again later");
            list.Add("Better not tell you now");
            list.Add("Cannot predict now");
            list.Add("Concentrate and ask again");
            list.Add("Don't count on it");
            list.Add("My reply is no");
            list.Add("My sources say no");
            list.Add("Outlook not so good");
            list.Add("Very doubtful");
        }
        static string GetSaying()
        {
            string saying;
            saying = list.ElementAt(rand.Next(0, list.Count));
            return saying;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LblMessage_Click(object sender, EventArgs e)
        {

        }

        private void TBAnswer_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
