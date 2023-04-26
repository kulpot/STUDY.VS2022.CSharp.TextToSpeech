using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer _SS = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();

            foreach(object obj in _SS.GetInstalledVoices())
            {
                var voice = (InstalledVoice)obj;

                listBox1.Items.Add(voice.VoiceInfo.Name);
            }
            _SS.Volume = 80;
            _SS.Rate = 1;
            //_SS.Voice.
            //_SS.State = SynthesizerState.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _SS.SpeakAsync("Hey there big guy, want a soda?");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            _SS.SpeakAsyncCancelAll();
            base.OnClosing(e);
        }
    }
}
