using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Recognition;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarvis
{

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        
        static JarvisMainForm jarvis = null;
        
[STAThread]
        static void Main()
        {

            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            Application.Run(new Terminal());
=======
=======
>>>>>>> Stashed changes
            jarvis = new JarvisMainForm();
            Application.Run(jarvis);
            
        }
        public static void something()
        {
            using (SpeechRecognitionEngine recognizer =
             new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US")))
            {

                //// Create a grammar.
                ////  Create lists of alternative choices.
                //Choices listTypes = new Choices(new string[] { "albums", "artists" });
                //Choices genres = new Choices(new string[] { "blues", "classical", "gospel", "jazz", "rock" });

                ////  Create a GrammarBuilder object and assemble the grammar components.
                //GrammarBuilder mediaMenu = new GrammarBuilder("Display the list of");
                //mediaMenu.Append(listTypes);
                //mediaMenu.Append("in the");
                //mediaMenu.Append(genres);
                //mediaMenu.Append("category.");

                //  Build a Grammar object from the GrammarBuilder.
                //Grammar mediaMenuGrammar = new Grammar(mediaMenu);
                //mediaMenuGrammar.Name = "Media Chooser";

                // Attach event handlers.
            
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
                recognizer.SpeechHypothesized +=
                  new EventHandler<SpeechHypothesizedEventArgs>(recognizer_SpeechHypothesized);

                //// Load the grammar object to the recognizer.
                //recognizer.LoadGrammarAsync(mediaMenuGrammar);

                DictationGrammar dg = new DictationGrammar();

                recognizer.LoadGrammar(dg);

                // Set the input to the recognizer.
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous recognition.
                recognizer.RecognizeAsync();

                // Keep the console window open.
                Console.ReadLine();
            }
        

        }
        // Handle the SpeechHypothesized event.
        static void recognizer_SpeechHypothesized(object sender, SpeechHypothesizedEventArgs e)
        {
           jarvis.setHypothesized(e.Result.Text);
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
        }

        // Handle the SpeechRecognized event.
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            jarvis.setRecognized(e.Result.Text);
        }

     
    }
}

