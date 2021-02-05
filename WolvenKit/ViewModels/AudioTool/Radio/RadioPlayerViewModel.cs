using Catel.MVVM;
using FmodAudio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Views.AudioTool.Radio;

namespace WolvenKit.ViewModels.AudioTool.Radio
{
    class RadioPlayerViewModel : ViewModelBase
    {

     
        public int RadioVolume {
            get
            {
                if (RadioPlayerView.RadioChannel != null)
                {
                          return (int)RadioPlayerView.RadioChannel.Volume;
                }

                return 100;
           
            }
            set
            {
                if (RadioPlayerView.RadioChannel != null)
                {
                    if (RadioPlayerView.RadioChannel.Volume != value)
                    {
                        RadioPlayerView.RadioChannel.Volume = value;

                    }
                }
            }
        }
    }
}
