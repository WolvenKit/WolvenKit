using NAudioDemo.AudioPlaybackDemo;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WolvenKit.Wwise.Player
{
    public class AudioPlaybackPanelPlugin
    {
        public string Name
        {
            get { return "Audio File Playback"; }
        }

        public Control CreatePanel()
        {
            return new AudioPlaybackPanel();
        }
    }
}
