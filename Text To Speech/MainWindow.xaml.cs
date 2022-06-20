using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Synthesis;
using System.Globalization;

namespace Text_To_Speech
{
    public partial class MainWindow : Window
    {

        private string speak;

        public MainWindow()
        {
            InitializeComponent();


            

        }

        private void TextBoxForSpeech_TextChanged(object sender, TextChangedEventArgs e)
        {
            speak = TextBoxForSpeech.Text;
        }

        private void Talk()
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Adult);

            

            synth.Speak(speak);

            synth.Dispose();
        }

        private void ButtonSpeak_Click(object sender, RoutedEventArgs e)
        {
            Talk();
        }
    }
}
