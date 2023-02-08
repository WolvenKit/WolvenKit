using System;
using System.Linq;

namespace NAudioWpfDemo
{
    //https://github.com/naudio/NAudio/blob/8e162ed1b1dc13491794ace46327e35d866465cc/NAudioWpfDemo/IWaveFormRenderer.cs
    public interface IWaveFormRenderer
    {
        void AddValue(float maxValue, float minValue);
    }
}
