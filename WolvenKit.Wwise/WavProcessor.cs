using System;

namespace Orangelynx.Multimedia
{
  public class WavProcessor
  {
    public static void ConvertToADPCM(WavFile wavFile)
    {
      if (wavFile == null)
        throw new ArgumentNullException("wavFile", "wavFile has to be loaded.");
      if ((int) wavFile.FormatTag == 1)
      {
        int blockAlignment = 36;
        int num1 = 64;
        byte[] numArray1 = ImaAdpcmCodec.EncodeStream(wavFile.AudioData, (int) wavFile.Channels, blockAlignment);
        wavFile.AudioData = numArray1;
        wavFile.FormatTag = (ushort) 2;
        WavFile wavFile1 = wavFile;
        int num2 = (int) wavFile1.Channels;
        wavFile1.Channels = (ushort) num2;
        WavFile wavFile2 = wavFile;
        int num3 = (int) wavFile2.SamplesPerSec;
        wavFile2.SamplesPerSec = (uint) num3;
        wavFile.AvgBytesPerSec = Convert.ToUInt32((float) ((uint) wavFile.Channels * wavFile.SamplesPerSec) / (float) num1 * (float) blockAlignment);
        wavFile.BlockAlign = Convert.ToUInt16(blockAlignment);
        wavFile.BitsPerSample = (ushort) 4;
        if ((int) wavFile.Channels == 1)
        {
          WavFile wavFile3 = wavFile;
          byte[] numArray2 = new byte[6];
          int index = 2;
          int num4 = 4;
          numArray2[index] = (byte) num4;
          wavFile3.FormatExtension = numArray2;
        }
        else
        {
          WavFile wavFile3 = wavFile;
          byte[] numArray2 = new byte[6];
          int index = 2;
          int num4 = 3;
          numArray2[index] = (byte) num4;
          wavFile3.FormatExtension = numArray2;
        }
      }
      else
      {
        if (Enum.IsDefined(typeof (WavFile.WAVEFormatCategories), (object) wavFile.FormatTag))
          throw new InvalidOperationException(string.Format("Conversion from {0} to {1} is not supported.", (object) Enum.ToObject(typeof (WavFile.WAVEFormatCategories), wavFile.FormatTag).ToString(), (object) WavFile.WAVEFormatCategories.MS_ADPCM.ToString()));
        throw new InvalidOperationException(string.Format("Conversion from 0x{0} to {1} is not supported.", (object) wavFile.FormatTag, (object) WavFile.WAVEFormatCategories.MS_ADPCM.ToString()));
      }
    }

    public static void ConvertToPCM(WavFile wavFile)
    {
      if (wavFile == null)
        throw new ArgumentNullException("wavFile", "wavFile has to be loaded.");
      if ((int) wavFile.FormatTag == 2)
      {
        byte[] numArray = ImaAdpcmCodec.DecodeStream(wavFile.AudioData, (int) wavFile.Channels, (int) wavFile.BlockAlign);
        wavFile.AudioData = numArray;
        wavFile.FormatTag = (ushort) 1;
        WavFile wavFile1 = wavFile;
        int num1 = (int) wavFile1.Channels;
        wavFile1.Channels = (ushort) num1;
        WavFile wavFile2 = wavFile;
        int num2 = (int) wavFile2.SamplesPerSec;
        wavFile2.SamplesPerSec = (uint) num2;
        WavFile wavFile3 = wavFile;
        int num3 = (int) wavFile3.Channels * (int) wavFile.SamplesPerSec * 2;
        wavFile3.AvgBytesPerSec = (uint) num3;
        wavFile.BlockAlign = Convert.ToUInt16((int) wavFile.Channels * 2);
        wavFile.BitsPerSample = (ushort) 16;
        wavFile.FormatExtension = (byte[]) null;
      }
      else
      {
        if (Enum.IsDefined(typeof (WavFile.WAVEFormatCategories), (object) wavFile.FormatTag))
          throw new InvalidOperationException(string.Format("Conversion from {0} to {1} is not supported.", (object) Enum.ToObject(typeof (WavFile.WAVEFormatCategories), wavFile.FormatTag).ToString(), (object) WavFile.WAVEFormatCategories.PCM.ToString()));
        throw new InvalidOperationException(string.Format("Conversion from 0x{0} to {1} is not supported.", (object) wavFile.FormatTag, (object) WavFile.WAVEFormatCategories.PCM.ToString()));
      }
    }
  }
}
