using System;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace AudioRecorder
{
    public partial class Form1 : Form
    {
        private SoundRecorder recorder;
        private string outputFilePath;

        public Form1()
        {
            InitializeComponent();
            recorder = new SoundRecorder();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Start recording
            recorder.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop recording
            recorder.Stop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize UI
            btnStop.Enabled = false;
            outputFilePath = Path.Combine(Application.StartupPath, "output.wav"); // Output file path
        }

        private class SoundRecorder
        {
            private SoundRecorder()
            {
                // Constructor
            }

            public void Start()
            {
                // Start recording
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = "null"; // Use "null" as sound location to capture audio
                player.Play();
            }

            public void Stop()
            {
                // Stop recording
                SoundPlayer player = new SoundPlayer();
                player.Stop();
                player.SoundLocation = ""; // Clear sound location to stop recording
                player.Play();
                player.Dispose();
            }
        }
    }
}




