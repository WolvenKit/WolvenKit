namespace NAudioWpfDemo.AudioPlaybackDemo
{
    // https://github.com/naudio/NAudio/blob/8e162ed1b1dc13491794ace46327e35d866465cc/NAudioWpfDemo/AudioPlaybackDemo/PolygonWaveFormVisualization.cs
    class PolygonWaveFormVisualization : IVisualizationPlugin
    {
        private readonly PolygonWaveFormControl polygonWaveFormControl = new PolygonWaveFormControl();

        public string Name => "Polygon WaveForm Visualization";

        public object Content => polygonWaveFormControl;

        public void OnMaxCalculated(float min, float max)
        {
            polygonWaveFormControl.AddValue(max, min);
        }

        public void OnFftCalculated(NAudio.Dsp.Complex[] result)
        {
            // nothing to do
        }
    }
}
