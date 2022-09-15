using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace NuclearReactor
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void reactorControlLabel_Click(object sender, EventArgs e)
        {

        }

        private void reactorStartButton_Click(object sender, EventArgs e)
        {
            SoundPlayer sirenPlayer = new SoundPlayer(Properties.Resources.siren);
            sirenPlayer.Play();
            Thread.Sleep(800);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            reactorControlLabel.Text = "Meltdown Imminent";
            reactorControlLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Red;
            reactor2StateLabel.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(400);

            reactor1StateLabel.BackColor = Color.Honeydew;
            reactor2StateLabel.BackColor = Color.Honeydew;
            Refresh();
            Thread.Sleep(400);

            

           

        }
    }
}
