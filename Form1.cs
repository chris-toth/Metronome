using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //https://msdn.microsoft.com/en-us/library/bb383890(v=vs.90).aspx
        /*
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "Audio Files (.wav)|*.wav";


        if(dialog.ShowDialog() == DialogResult.OK)
        {
        string path = dialog.FileName;
        playSound(path);
        }*/

    //Function to play the sound using the System.Media.SoundPlayer class
    //INPUTS: nothing since the sound is embedded in the resource folder
    //OUTPUTS: sound plays
    private void playSound()
        {
            System.Media.SoundPlayer player =
                new System.Media.SoundPlayer(Template.Properties.Resources.clap);
            
            player.Play();
        }

        //Every tick will call the playSound void function to play the sound
        private void timer1_Tick(object sender, EventArgs e)
        {
            playSound();            
        }

        //Controllable track bar to change the BPM of the metronome. also display the BPM as a label on screen
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value;
            label3.Text = (60000/trackBar1.Value) + " BPM".ToString();
        }
    }
}
