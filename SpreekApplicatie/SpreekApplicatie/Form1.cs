using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech; 
using System.Speech.Recognition; 
using System.Speech.Synthesis; 
using System.Threading;
using System.Diagnostics;

namespace SpreekApplicatie
{
    public partial class Form1 : Form
    {
        
        SpeechRecognitionEngine MyEngine = new SpeechRecognitionEngine();
        SpeechSynthesizer MySyn = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            // Message if there is no text in the text box
            if (string.IsNullOrEmpty(rtxtInput.Text))
            {
                MySyn.SpeakAsync("Sorry,  I can't read without text, Enter text first");
            }
            else
            {
                MySyn.Dispose(); 
                MySyn = new SpeechSynthesizer(); 
                MySyn.SpeakAsync(rtxtInput.Text); // print the text in text box
            }
        }

        private void btnInport_Click(object sender, EventArgs e)
        {
            btnInport.Enabled = false;
            btnStop.Enabled = true;
            // Creating list with strings the computer can print
            Choices sList = new Choices();
            sList.Add(new string[] { "say hello", "how are you", "exit", "what is the current time", "thank you" });
            GrammarBuilder gb = new GrammarBuilder();
            gb.Append(sList);
            Grammar gr = new Grammar(gb);

            // Try to print the text in the text box
            try
            {
                MyEngine.RequestRecognizerUpdate();
                MyEngine.LoadGrammar(gr);
                MyEngine.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(MyEngine_SpeechRecognized);
                MyEngine.SetInputToDefaultAudioDevice();
                MyEngine.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void MyEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text != "")
            {
                if (e.Result.Text == "exit")
                {
                    Application.Exit();
                }
                else if (e.Result.Text == "how are you")
                {
                    MySyn.SpeakAsync("I'm fine, thanks for asking");
                }
                else if (e.Result.Text == "what is the current time")
                {
                    MySyn.SpeakAsync("The current time is " + DateTime.Now.ToLongTimeString());
                }
                else if (e.Result.Text == "thank you")
                {
                    MySyn.SpeakAsync("no thanks, have a nice day");
                }
                else if (e.Result.Text == "say hello")
                {
                    MySyn.SpeakAsync("hello, nice to see you again");
                }
                rtxtInput.Text = rtxtInput.Text + " " + e.Result.Text.ToString() + Environment.NewLine;
            }
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            MyEngine.RecognizeAsyncStop();
            btnStop.Enabled = false;
            btnInport.Enabled = true;
        }
    }
}
