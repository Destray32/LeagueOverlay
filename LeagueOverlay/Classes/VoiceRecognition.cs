using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Windows.Forms;

namespace LeagueOverlay.Klasy.VoiceRecognition
{

    internal class VoiceRecognition
    {
        SpeechRecognitionEngine engine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        public VoiceRecognition()
        {

        }

        public void WlaczRozpoznawanieMowy()
        {
            // Adding words for recognition engine
            Choices choices = new Choices(new string[] { "frog", "wolves", "raptors", "krugs" });

            // Grammar building
            GrammarBuilder grammarBuilder = new GrammarBuilder(choices);

            grammarBuilder.Culture = new System.Globalization.CultureInfo("en-US");
            Grammar grammar = new Grammar(grammarBuilder);

            // Loading engine etc.
            engine.LoadGrammar(grammar);

            engine.SpeechRecognized += Akcja_SlowoRozpoznane;
            engine.SetInputToDefaultAudioDevice();
            engine.RecognizeAsync(RecognizeMode.Multiple);


            // debug log
            //Console.WriteLine("Wlaczono rozpoznawanie mowy");
        }
        private void Akcja_SlowoRozpoznane(object sender, SpeechRecognizedEventArgs e)
        {
            // turn timers in Form1
            Form1.TurnCountingViaVR(e.Result.Text);
        }


    }
}
