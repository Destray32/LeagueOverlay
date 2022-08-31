using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;

using Utilities;
using LeagueOverlay.Klasy.Konsola;

namespace LeagueOverlay
{
    public partial class Form1 : Form
    {
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

        #region TIMER LOCAL VARS
        private static Timer myTimer1 = new Timer();
        private static Timer myTimer2 = new Timer();
        private static Timer myTimer3 = new Timer();
        private static Timer myTimer4 = new Timer();
        private static Timer myTimer5 = new Timer();
        private static Timer myTimer6 = new Timer();
        private static Timer myTimer7 = new Timer();
        private static Timer myTimer8 = new Timer();

        private static Int32 time1 = 135;
        private static Int32 time2 = 135;
        private static Int32 time3 = 135;
        private static Int32 time4 = 135;
        private static Int32 time5 = 135;
        private static Int32 time6 = 135;
        private static Int32 time7 = 135;
        private static Int32 time8 = 135;
        #endregion

        #region OTHER LOCAL VARS
        // static reference for other forms
        public static Form2 s_form2 = null;

        // Global low level keyboard hotkey constructor
        globalKeyboardHook ghk = new globalKeyboardHook();

        Int32 BSFrogKey, BSWolfsKey, BSRaptorsKey,
                    BSRocksKey, TSFrogKey, TSWolfsKey,
                        TSRaptorsKey, TSRocksKey;


        public static Label[] labels;

        private Keys[] keys = {
            Properties.Settings.Default.BSWolfs, Properties.Settings.Default.BSRocks,
            Properties.Settings.Default.BSRaptors, Properties.Settings.Default.BSFrog,
            Properties.Settings.Default.TSFrog, Properties.Settings.Default.TSRaptors,
            Properties.Settings.Default.TSRocks, Properties.Settings.Default.TSWolfs
        };


        #endregion

        public Form1()
        {

            int marginesPrawy = 10;
            int marginesGora = 80;

            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;

            this.Opacity = 0.99;
            this.ControlBox = false;
            this.Text = String.Empty;

            this.StartPosition = FormStartPosition.Manual;

            Rectangle poleRobocze = Screen.PrimaryScreen.Bounds;
            this.Location = new Point(poleRobocze.Width - this.ClientSize.Width - marginesPrawy, 0 + marginesGora);

            InitializeComponent();

            labels = new Label[8] {
                            label1, label2, label3,
                            label4, label5, label6,
                            label7, label8
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();

            // Load form2 upon loading form1
            s_form2 = new Form2();
            s_form2.Show();

            AddKeysToHook();


            // Setting timers on form load
            // 1: Timer
            // 2: Lablel for timer
            // 3: Unique index for timer
            SetupTimer(myTimer1, s_form2.BSRocks, 1);
            SetupTimer(myTimer2, s_form2.BSRaptors, 2);
            SetupTimer(myTimer3, s_form2.BSWolf, 3);
            SetupTimer(myTimer4, s_form2.BSFrog, 4);
            SetupTimer(myTimer5, s_form2.TSFrog, 5);
            SetupTimer(myTimer6, s_form2.TSWolfs, 6);
            SetupTimer(myTimer7, s_form2.TSRaptors, 7);
            SetupTimer(myTimer8, s_form2.TSRocks, 8);

            SetForm1GUI();

            // Turning console on
            //Konsola konsola = new Konsola();
            //konsola.WlaczKonsole();


        }


        #region KEYS HOOKING RELATED
        private void AddKeysToHook()
        {
            foreach (Keys key in keys)
            {
                ghk.HookedKeys.Add(key);
            }
            ghk.KeyDown += new KeyEventHandler(Ghk_KeyDown);
        }

        void Ghk_KeyDown(object sender, KeyEventArgs e)
        {

            switch (e.KeyValue)
            {
                // If timer corensponding to key has default value it is going to count down
                // if not, we say that we handled a key input
                //
                case var value when value == BSRocksKey: // BSRocks
                    if (time1 == 135)
                    {
                        myTimer1.Start();

                        s_form2.BSRocks.Show();
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case var value when value == BSRaptorsKey: // BSRaptors
                    if (time2 == 135)
                    {
                        myTimer2.Start();

                        s_form2.BSRaptors.Show();
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case var value when value == BSWolfsKey: // BSWolf
                    if (time3 == 135)
                    {
                        myTimer3.Start();

                        s_form2.BSWolf.Show();
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case var value when value == BSFrogKey: // BSFrog
                    if (time4 == 135)
                    {
                        myTimer4.Start();

                        s_form2.BSFrog.Show();
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case var value when value == TSFrogKey: // TSFrog
                    if (time5 == 135)
                    {
                        myTimer5.Start();

                        s_form2.TSFrog.Show();
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case var value when value == TSWolfsKey: // TSWolfs
                    if (time6 == 135)
                    {
                        myTimer6.Start();

                        s_form2.TSWolfs.Show();
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case var value when value == TSRaptorsKey: // TSRaptors
                    if (time7 == 135)
                    {
                        myTimer7.Start();

                        s_form2.TSRaptors.Show();
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                case var value when value == TSRocksKey: // TSRocks
                    if (time8 == 135)
                    {
                        myTimer8.Start();

                        s_form2.TSRocks.Show();
                        e.Handled = true;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region TIMER RELATED

        private void SetupTimer(Timer timer, Label label, Int32 index)
        {
            timer.Tick += new EventHandler((sender, e) => TimerProcessor(sender, e, label, index));
            timer.Interval = 1000;
        }

        private static void TimerProcessor(Object myObject, EventArgs e, Label label, Int32 index)
        {
            switch (index)
            {
                case 1:
                    time1--;
                    label.Text = ChangeToMMSS(time1);

                    // set if label cannot be hidden bcs it's counting time right now
                    Form2.canHide[label] = false;
                    if (time1 == 0)
                    {
                        myTimer1.Stop();
                        label.Hide();

                        // restore to default setting
                        Form2.canHide[label] = true;
                        time1 = 135;
                    }
                    return;
                case 2:
                    time2--;
                    label.Text = ChangeToMMSS(time2);
                    Form2.canHide[label] = false;
                    if (time2 == 0)
                    {
                        myTimer2.Stop();
                        label.Hide();
                        Form2.canHide[label] = true;
                        time2 = 135;
                    }
                    return;
                case 3:
                    time3--;
                    label.Text = ChangeToMMSS(time3);
                    Form2.canHide[label] = false;
                    if (time3 == 0)
                    {
                        myTimer3.Stop();
                        label.Hide();
                        Form2.canHide[label] = true;
                        time3 = 135;
                    }
                    return;
                case 4:
                    time4--;
                    label.Text = ChangeToMMSS(time4);
                    Form2.canHide[label] = false;
                    if (time4 == 0)
                    {
                        myTimer4.Stop();
                        label.Hide();
                        Form2.canHide[label] = true;
                        time4 = 135;
                    }
                    return;
                case 5:
                    time5--;
                    label.Text = ChangeToMMSS(time5);
                    Form2.canHide[label] = false;
                    if (time5 == 0)
                    {
                        myTimer5.Stop();
                        label.Hide();
                        Form2.canHide[label] = true;
                        time5 = 135;
                    }
                    return;
                case 6:
                    time6--;
                    label.Text = ChangeToMMSS(time6);
                    Form2.canHide[label] = false;
                    if (time6 == 0)
                    {
                        myTimer6.Stop();
                        label.Hide();
                        Form2.canHide[label] = true;
                        time6 = 135;
                    }
                    return;
                case 7:
                    time7--;
                    label.Text = ChangeToMMSS(time7);
                    Form2.canHide[label] = false;
                    if (time7 == 0)
                    {
                        myTimer7.Stop();
                        label.Hide();
                        Form2.canHide[label] = true;
                        time7 = 135;
                    }
                    return;
                case 8:
                    time8--;
                    label.Text = ChangeToMMSS(time8);
                    Form2.canHide[label] = false;
                    if (time8 == 0)
                    {
                        myTimer8.Stop();
                        label.Hide();
                        Form2.canHide[label] = true;
                        time8 = 135;
                    }
                    return;
            }
        }
        #endregion

        #region User private functions
        private void GetSettings()
        {
            BSFrogKey = (Int32)Properties.Settings.Default.BSFrog;
            BSWolfsKey = (Int32)Properties.Settings.Default.BSWolfs;
            BSRaptorsKey = (Int32)Properties.Settings.Default.BSRaptors;
            BSRocksKey = (Int32)Properties.Settings.Default.BSRocks;

            TSFrogKey = (Int32)Properties.Settings.Default.TSFrog;
            TSWolfsKey = (Int32)Properties.Settings.Default.TSWolfs;
            TSRaptorsKey = (Int32)Properties.Settings.Default.TSRaptors;
            TSRocksKey = (Int32)Properties.Settings.Default.TSRocks;
        }
        private void SetForm1GUI()
        {
            this.label1.Text += $" {keys[3].ToString()}";
            this.label2.Text += $" {keys[0].ToString()}";
            this.label3.Text += $" {keys[2].ToString()}";
            this.label4.Text += $" {keys[1].ToString()}";

            this.label5.Text += $" {keys[6].ToString()}";
            this.label6.Text += $" {keys[5].ToString()}";
            this.label7.Text += $" {keys[7].ToString()}";
            this.label8.Text += $" {keys[4].ToString()}";
        }

        private static String ChangeToMMSS(Int32 time)
        {
            return TimeSpan.FromMinutes(time).ToString("hh':'mm");
        }

        #endregion

        #region User public functions

        public static void TurnCountingViaVR(string campToShow)
        {
            // Voice recognition switch
            //
            if (Form2.side == "left")
                switch (campToShow)
                {
                    case "krugs":
                        if (time1 == 135)
                        {
                            myTimer1.Start();

                            s_form2.BSRocks.Show();
                        }
                        break;
                    case "raptors":
                        if (time2 == 135)
                        {
                            myTimer2.Start();

                            s_form2.BSRaptors.Show();
                        }
                        break;
                    case "wolves":
                        if (time3 == 135)
                        {
                            myTimer3.Start();

                            s_form2.BSWolf.Show();
                        }
                        break;
                    case "frog":
                        if (time4 == 135)
                        {
                            myTimer4.Start();

                            s_form2.BSFrog.Show();
                        }
                        break;
                }
            else if(Form2.side == "right")
                switch (campToShow)
                {
                    case "krugs":
                        if (time8 == 135)
                        {
                            myTimer8.Start();

                            s_form2.TSRocks.Show();
                        }
                        break;
                    case "raptors":
                        if (time7 == 135)
                        {
                            myTimer7.Start();

                            s_form2.TSRaptors.Show();
                        }
                        break;
                    case "wolves":
                        if (time6 == 135)
                        {
                            myTimer6.Start();

                            s_form2.TSWolfs.Show();
                        }
                        break;
                    case "frog":
                        if (time5 == 135)
                        {
                            myTimer5.Start();

                            s_form2.TSFrog.Show();
                        }
                        break;
                }
        }

        #endregion

        #region Action with form elements
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
