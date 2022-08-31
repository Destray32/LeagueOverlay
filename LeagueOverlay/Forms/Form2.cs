using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

using LeagueOverlay.Klasy.VoiceRecognition;



namespace LeagueOverlay
{
    public partial class Form2 : Form
    {

        VoiceRecognition voiceRecognition = new VoiceRecognition();

        public static string side = "";
        bool voiceRecognitonWlaczone = false;

        #region TRANSPARENCY
        protected override bool ShowWithoutActivation => true;
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_LAYERED = 0x80000;
                const int WS_EX_TRANSPARENT = 0x20;
                const int WS_EX_TOOLWINDOW = 0x00000080;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_LAYERED;
                cp.ExStyle |= WS_EX_TRANSPARENT;
                cp.ExStyle |= WS_EX_TOOLWINDOW;
                return cp;
            }
        }
        #endregion

        #region LOCAL VARS
        readonly Label[] labels = null;
        #endregion

        // dictionary that contains boolean indicating if a label can be hidden or not
        public static IDictionary<Label, bool> canHide = new Dictionary<Label, bool>();

        public Form2()
        {

            this.Opacity = 0.99;
            this.TopMost = true;

            this.ControlBox = false;
            this.Text = String.Empty;

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            this.StartPosition = FormStartPosition.Manual;

            Rectangle poleRobocze = Screen.PrimaryScreen.Bounds;
            this.Location = new Point((poleRobocze.Width - 600), (poleRobocze.Height - 570));

            InitializeComponent();

            labels = new Label[8] { BSFrog, BSWolf, BSRaptors, BSRocks,
                TSFrog, TSWolfs, TSRaptors, TSRocks };
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            foreach (Label label in labels)
            {
                label.Hide();

                canHide.Add(label, true);
            }
        }

        #region Action with form elements
        private void notifyIcon1_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            MessageBox.Show("Someone just double clicked on the icon!");
        }

        private void zmienWielkoscMapyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void hideControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Label label in Form1.labels)
            {
                label.Hide();
            }
        }

        private void showControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Label label in Form1.labels)
            {
                label.Show();
            }
        }

        private void leftSideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            side = "left";
            ActivateVoiceRecognition();
        }

        private void rightSideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            side = "right";
            ActivateVoiceRecognition();
        }

        private void ActivateVoiceRecognition()
        {
            if (!voiceRecognitonWlaczone)
            {
                voiceRecognition.WlaczRozpoznawanieMowy();
                voiceRecognitonWlaczone = true;
            }
        }

        private void turnOffVoiceRecognitionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

    }
}
