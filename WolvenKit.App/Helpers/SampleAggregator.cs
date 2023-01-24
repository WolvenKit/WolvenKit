// (c) Copyright Jacob Johnston.
// This source is subject to Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.

using System;
using NAudio.Dsp;

namespace WolvenKit.MVVM.Views.Components.Tools.AudioTool
{
    public class SampleAggregator
    {
        #region Fields

        private readonly int binaryExponentitation;
        private readonly int bufferSize;
        private readonly Complex[] channelData;
        private int channelDataPosition;

        #endregion Fields

        #region Constructors

        public SampleAggregator(int bufferSize)
        {
            this.bufferSize = bufferSize;
            binaryExponentitation = (int)Math.Log(bufferSize, 2);
            channelData = new Complex[bufferSize];
        }

        #endregion Constructors

        #region Properties

        public float LeftMaxVolume { get; private set; }

        public float LeftMinVolume { get; private set; }

        public float RightMaxVolume { get; private set; }

        public float RightMinVolume { get; private set; }

        #endregion Properties

        #region Methods

        /// <summary>
        /// Add a sample value to the aggregator.
        /// </summary>
        /// <param name="value">The value of the sample.</param>
        public void Add(float leftValue, float rightValue)
        {
            if (channelDataPosition == 0)
            {
                LeftMaxVolume = float.MinValue;
                RightMaxVolume = float.MinValue;
                LeftMinVolume = float.MaxValue;
                RightMinVolume = float.MaxValue;
            }

            // Make stored channel data stereo by averaging left and right values.
            channelData[channelDataPosition].X = (leftValue + rightValue) / 2.0f;
            channelData[channelDataPosition].Y = 0;
            channelDataPosition++;

            LeftMaxVolume = Math.Max(LeftMaxVolume, leftValue);
            LeftMinVolume = Math.Min(LeftMinVolume, leftValue);
            RightMaxVolume = Math.Max(RightMaxVolume, rightValue);
            RightMinVolume = Math.Min(RightMinVolume, rightValue);

            if (channelDataPosition >= channelData.Length)
            {
                channelDataPosition = 0;
            }
        }

        public void Clear()
        {
            LeftMaxVolume = float.MinValue;
            RightMaxVolume = float.MinValue;
            LeftMinVolume = float.MaxValue;
            RightMinVolume = float.MaxValue;
            channelDataPosition = 0;
        }

        /// <summary>
        /// Performs an FFT calculation on the channel data upon request.
        /// </summary>
        /// <param name="fftBuffer">A buffer where the FFT data will be stored.</param>
        public void GetFFTResults(float[] fftBuffer)
        {
            var channelDataClone = new Complex[bufferSize];
            channelData.CopyTo(channelDataClone, 0);
            FastFourierTransform.FFT(true, binaryExponentitation, channelDataClone);
            for (var i = 0; i < channelDataClone.Length / 2; i++)
            {
                // Calculate actual intensities for the FFT results.
                fftBuffer[i] = (float)Math.Sqrt((channelDataClone[i].X * channelDataClone[i].X) + (channelDataClone[i].Y * channelDataClone[i].Y));
            }
        }

        #endregion Methods
    }
}
