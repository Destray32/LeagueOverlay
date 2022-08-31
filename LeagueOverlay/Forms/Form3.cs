using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueOverlay
{
    public partial class Form3 : Form
    {

        #region LOCAL VARS
        Point BSFrogXY, BSWolfsXY, BSRaptorsXY, BSRocksXY,
                TSFrogXY, TSWolfsXY, TSRaptorsXY, TSRocksXY;


        public static int val = 0;
        public static int prevVal = 0;
        Form2 form2 = Form1.s_form2;

        Label[] labels = null;
        Label currentLabel = null;
        #endregion

        public Form3()
        {
            InitializeComponent();

            labels = new Label[8] { form2.BSFrog, form2.BSWolf, form2.BSRaptors, form2.BSRocks,
                                    form2.TSFrog, form2.TSWolfs, form2.TSRaptors, form2.TSRocks };
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // bind handler for closing form3
            this.FormClosing += Form3_FormClosing;
            ////

            foreach (Label label in labels)
            {
                label.Show();
            }
        }

        #region Action with form elements
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentLabel = labels[comboBox1.SelectedIndex];
            trackBar2.Value = currentLabel.Location.Y;
            trackBar3.Value = currentLabel.Location.X;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            LoadFromConfig();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            SaveToConfig();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            // X trackbar
            if (currentLabel == null) return;
            currentLabel.Location = new Point(trackBar3.Value, currentLabel.Location.Y);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            // Y trackbar
            if (currentLabel == null) return;
            currentLabel.Location = new Point(currentLabel.Location.X, trackBar2.Value);
        }
        private void Form3_FormClosing(Object sender, FormClosingEventArgs e)
        {
            foreach (Label label in labels)
            {
                Form2.canHide.TryGetValue(label, out bool val);
                if (val)
                {
                    label.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadFromConfig();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveToConfig();
        }


        #endregion

        #region User functions
        public void LoadFromConfig()
        {
            BSFrogXY = Properties.Settings.Default.BSFrogCoords;
            BSWolfsXY = Properties.Settings.Default.BSWolfsCoords;
            BSRaptorsXY = Properties.Settings.Default.BSRaptorsCoords;
            BSRocksXY = Properties.Settings.Default.BSRocksCoords;

            TSFrogXY = Properties.Settings.Default.TSFrogCoords;
            TSWolfsXY = Properties.Settings.Default.TSWolfsCoords;
            TSRaptorsXY = Properties.Settings.Default.TSRaptorsCoords;
            TSRocksXY = Properties.Settings.Default.TSRocksCoords;

            Point[] labelPointsXY = new Point[8] {BSFrogXY, BSWolfsXY, BSRaptorsXY,
                                                    BSRocksXY, TSFrogXY, TSWolfsXY,
                                                    TSRaptorsXY, TSRocksXY};
            Int32 i = 0;
            foreach (Label label in labels)
            {
                label.Location = labelPointsXY[i];
                i++;
            }
        }

        public void SaveToConfig()
        {
            Properties.Settings.Default.BSFrogCoords = form2.BSFrog.Location;
            Properties.Settings.Default.BSWolfsCoords = form2.BSWolf.Location;
            Properties.Settings.Default.BSRaptorsCoords = form2.BSRaptors.Location;
            Properties.Settings.Default.BSRocksCoords = form2.BSRocks.Location;

            Properties.Settings.Default.TSFrogCoords = form2.TSFrog.Location;
            Properties.Settings.Default.TSWolfsCoords = form2.TSWolfs.Location;
            Properties.Settings.Default.TSRaptorsCoords = form2.TSRaptors.Location;
            Properties.Settings.Default.TSRocksCoords = form2.TSRocks.Location;

            Properties.Settings.Default.Save();
        }
        #endregion
    }
}
