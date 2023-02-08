namespace NAudioWpfDemo.AudioPlaybackDemo
{
    // https://github.com/naudio/NAudio/blob/8e162ed1b1dc13491794ace46327e35d866465cc/NAudioWpfDemo/AudioPlaybackDemo/PolylineWaveFormVisualization.cs
    class PolylineWaveFormVisualization : IVisualizationPlugin
    {
        private readonly PolylineWaveFormControl polylineWaveFormControl = new PolylineWaveFormControl();

        public string Name => "Polyline WaveForm Visualization";

        public object Content => polylineWaveFormControl;

        public void OnMaxCalculated(float min, float max)
        {
            polylineWaveFormControl.AddValue(max, min);
        }

        public void OnFftCalculated(NAudio.Dsp.Complex[] result)
        {
            // nothing to do
        }
    }
}
