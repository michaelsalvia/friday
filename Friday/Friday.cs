using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Friday
{
    class Friday
    {
        FridayConsole fridayConsole;
        
        public Friday(FridayConsole fridayConsole)
        {
            this.fridayConsole = fridayConsole;
            SpeechRecognitionEngine _recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));

            //_recognizer.LoadGrammar(new Grammar(new GrammarBuilder("test")) { Name = "testGrammar" }); // load a grammar "test"

            Grammar grammar1 = new Grammar(new GrammarBuilder("thank you"));
            grammar1.Name = "testGrammar";
            
            Grammar grammar2 = new Grammar(new GrammarBuilder("what is your name"));
            grammar2.Name = "nameGrammar";

            _recognizer.LoadGrammar(grammar1);
            _recognizer.LoadGrammar(grammar2);
            _recognizer.SpeechRecognized += _recognizer_SpeechRecognized;

            _recognizer.SetInputToDefaultAudioDevice(); // set the input of the speech recognizer to the default audio device
            _recognizer.RecognizeAsync(RecognizeMode.Multiple); // recognize speech asynchronous

            //_recognizer.LoadGrammar(new Grammar(new GrammarBuilder("test"))); // load a "test" grammar
        }


        void _recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.SetOutputToDefaultAudioDevice();

                String response = "i do not understand";

                if (e.Result.Text == "thank you")
                {
                    response = "you are welcome";  
                }

                if (e.Result.Text == "what is your name")
                {
                    response = "my name is Friday";
                }

                synth.Speak(response);
                fridayConsole.writeToConsole(response);
            }
        } 
    }
}
