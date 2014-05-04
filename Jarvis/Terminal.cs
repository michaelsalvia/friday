using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarvis
{
    public partial class Terminal : Form
    {
        Jarvis jarvis;
        public Terminal()
        {
            InitializeComponent();
            jarvis = new Jarvis(this);
            writeToConsole("Hello, sir! Please click 'Enable' to begin.");
        }

        //TODO Put speech recognition stuff here.

        private void enableButton_Click(object sender, EventArgs e)
        {
            this.jarvis.enable();
        }

        private void disableButton_click(object sender, EventArgs e)
        {
            this.jarvis.disable();
        }

        internal void writeToConsole(string text)
        {
            this.consoleTextArea.AppendText(text + "\n");
            this.consoleTextArea.ScrollToCaret();
        }
        internal void consoleToLog()
        {

        }

        internal void setUnderstood(string understoodSpeech)
        {
            this.understoodInstructionText.Text = understoodSpeech;
            this.Update();
        }

        internal void setHypothesized(string hypothesizedSpeech)
        {
            this.hypothesizedRecognitionText.Text = hypothesizedSpeech;
            this.Update();
        }
    }
}
