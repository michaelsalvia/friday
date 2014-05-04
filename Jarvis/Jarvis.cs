using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;

namespace Jarvis
{
    class Jarvis
    {

        SpeechRecognitionEngine speechRecognitionEngine;
        Terminal terminal;
        Boolean active;
        
        public Jarvis(Terminal terminal)
        {
            this.terminal = terminal;
            speechRecognitionEngine = new SpeechRecognitionEngine();
            speechRecognitionEngine.SetInputToDefaultAudioDevice();
            speechRecognitionEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(jarvis_Understood);
            speechRecognitionEngine.SpeechHypothesized += new EventHandler<SpeechHypothesizedEventArgs>(jarvis_Hypothesized);
            speechRecognitionEngine.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(jarvis_SpeechDetected);
            Grammar jarvisGrammer = new DictationGrammar();
            speechRecognitionEngine.LoadGrammar(jarvisGrammer);
        }

        public void enable()
        {
            if (active == true)
            {
                terminal.writeToConsole("Jarvis is already running. No action is taken.");
            }
            else
            {
                active = true;
                speechRecognitionEngine.RecognizeAsync();
                
                terminal.writeToConsole("Jarvis is ONLINE!");
            }

        }

        public void disable()
        {
            if (active == false)
            {
                terminal.writeToConsole("Jarvis is not online. No action is taken.");
            }
            else
            {
                active = false;
                speechRecognitionEngine.RecognizeAsyncStop();
                terminal.writeToConsole("Jarvis is OFFLINE!");
            }
        }
       
         void jarvis_Understood(object sender, SpeechRecognizedEventArgs e)
        {
            this.terminal.setUnderstood(e.Result.Text);
        }
         void jarvis_Hypothesized(object sender, SpeechHypothesizedEventArgs e)
        {
            this.terminal.setHypothesized(e.Result.Text);
        }
         void jarvis_SpeechDetected(object sender, SpeechDetectedEventArgs e)
         {
             this.terminal.writeToConsole(e.AudioPosition + " is current audio position.");
         }
    }
}
