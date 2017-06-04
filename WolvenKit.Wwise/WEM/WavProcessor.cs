using System;

namespace WolvenKit.Wwise.WEM
{
    public class WavProcessor
    {
        public static void ConvertToAdpcm(WavFile wavFile)
        {
            if (wavFile == null)
                throw new ArgumentNullException(nameof(wavFile), "wavFile has to be loaded.");
            if (wavFile.FormatTag == 1)
            {
                const int blockAlignment = 36;
                const int num1 = 64;
                var numArray1 = ImaAdpcmCodec.EncodeStream(wavFile.AudioData, wavFile.Channels, blockAlignment);
                wavFile.AudioData = numArray1;
                wavFile.FormatTag = 2;
                var wavFile1 = wavFile;
                int num2 = wavFile1.Channels;
                wavFile1.Channels = (ushort) num2;
                var wavFile2 = wavFile;
                var num3 = (int) wavFile2.SamplesPerSec;
                wavFile2.SamplesPerSec = (uint) num3;
                wavFile.AvgBytesPerSec =
                    Convert.ToUInt32(wavFile.Channels*wavFile.SamplesPerSec/(float) num1*blockAlignment);
                wavFile.BlockAlign = Convert.ToUInt16(blockAlignment);
                wavFile.BitsPerSample = 4;
                if (wavFile.Channels == 1)
                {
                    var wavFile3 = wavFile;
                    var numArray2 = new byte[6];
                    const int index = 2;
                    const int num4 = 4;
                    numArray2[index] = (byte) num4;
                    wavFile3.FormatExtension = numArray2;
                }
                else
                {
                    var wavFile3 = wavFile;
                    var numArray2 = new byte[6];
                    const int index = 2;
                    const int num4 = 3;
                    numArray2[index] = (byte) num4;
                    wavFile3.FormatExtension = numArray2;
                }
            }
            else
            {
                if (Enum.IsDefined(typeof (WavFile.WaveFormatCategories), wavFile.FormatTag))
                    throw new InvalidOperationException($"Conversion from {Enum.ToObject(typeof (WavFile.WaveFormatCategories), wavFile.FormatTag)} to {WavFile.WaveFormatCategories.MsAdpcm} is not supported.");
                throw new InvalidOperationException($"Conversion from 0x{wavFile.FormatTag} to {WavFile.WaveFormatCategories.MsAdpcm} is not supported.");
            }
        }

        public static void ConvertToPcm(WavFile wavFile)
        {
            if (wavFile == null)
                throw new ArgumentNullException(nameof(wavFile), "wavFile has to be loaded.");
            if (wavFile.FormatTag == 2)
            {
                var numArray = ImaAdpcmCodec.DecodeStream(wavFile.AudioData, wavFile.Channels, wavFile.BlockAlign);
                wavFile.AudioData = numArray;
                wavFile.FormatTag = 1;
                var wavFile1 = wavFile;
                int num1 = wavFile1.Channels;
                wavFile1.Channels = (ushort) num1;
                var wavFile2 = wavFile;
                var num2 = (int) wavFile2.SamplesPerSec;
                wavFile2.SamplesPerSec = (uint) num2;
                var wavFile3 = wavFile;
                var num3 = wavFile3.Channels*(int) wavFile.SamplesPerSec*2;
                wavFile3.AvgBytesPerSec = (uint) num3;
                wavFile.BlockAlign = Convert.ToUInt16(wavFile.Channels*2);
                wavFile.BitsPerSample = 16;
                wavFile.FormatExtension = null;
            }
            else
            {
                if (Enum.IsDefined(typeof (WavFile.WaveFormatCategories), wavFile.FormatTag))
                    throw new InvalidOperationException($"Conversion from {Enum.ToObject(typeof (WavFile.WaveFormatCategories), wavFile.FormatTag)} to {WavFile.WaveFormatCategories.Pcm} is not supported.");
                throw new InvalidOperationException($"Conversion from 0x{wavFile.FormatTag} to {WavFile.WaveFormatCategories.Pcm.ToString()} is not supported.");
            }
        }
    }
}