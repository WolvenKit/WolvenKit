using System;
using System.IO;

namespace Orangelynx.Multimedia
{
  public class ImaAdpcmCodec
  {
    private static readonly int[] NextStepIndexTable = new int[16]
    {
      -1,
      -1,
      -1,
      -1,
      2,
      4,
      6,
      8,
      -1,
      -1,
      -1,
      -1,
      2,
      4,
      6,
      8
    };
    private static readonly int[] StepTable = new int[89]
    {
      7,
      8,
      9,
      10,
      11,
      12,
      13,
      14,
      16,
      17,
      19,
      21,
      23,
      25,
      28,
      31,
      34,
      37,
      41,
      45,
      50,
      55,
      60,
      66,
      73,
      80,
      88,
      97,
      107,
      118,
      130,
      143,
      157,
      173,
      190,
      209,
      230,
      253,
      279,
      307,
      337,
      371,
      408,
      449,
      494,
      544,
      598,
      658,
      724,
      796,
      876,
      963,
      1060,
      1166,
      1282,
      1411,
      1552,
      1707,
      1878,
      2066,
      2272,
      2499,
      2749,
      3024,
      3327,
      3660,
      4026,
      4428,
      4871,
      5358,
      5894,
      6484,
      7132,
      7845,
      8630,
      9493,
      10442,
      11487,
      12635,
      13899,
      15289,
      16818,
      18500,
      20350,
      22385,
      24623,
      27086,
      29794,
      (int) short.MaxValue
    };
    private const int PcmSampleSize = 16;
    private const int AdpcmSampleSize = 4;

    public static byte[] EncodeStream(byte[] pcmData, int channelCount, int blockAlignment)
    {
      if (channelCount > 2 || channelCount < 1)
        throw new InvalidOperationException("input data has to be mono or stereo.");
      if (blockAlignment < 32 || blockAlignment > 512)
        throw new ArgumentOutOfRangeException("blockAlignment has to be between 32 and 512 bytes.");
      int num1 = pcmData.Length / 2;
      uint num2 = (uint) ((blockAlignment - 4) * 2);
      byte[] buffer1 = new byte[(long) (uint) Math.Ceiling((double) (uint) num1 / (double) num2) * (long) blockAlignment];
      MemoryStream memoryStream1 = new MemoryStream(pcmData);
      MemoryStream memoryStream2 = new MemoryStream(buffer1);
      byte[] numArray = new byte[(int) num2 * 2];
      int nextStepIndex = 0;
      while (memoryStream1.Position < memoryStream1.Length)
      {
        memoryStream1.Read(numArray, 0, numArray.Length);
        byte[] buffer2 = ImaAdpcmCodec.EncodeBlock(numArray, nextStepIndex, out nextStepIndex, channelCount);
        memoryStream2.Write(buffer2, 0, buffer2.Length);
      }
      memoryStream1.Close();
      memoryStream2.Close();
      return buffer1;
    }

    private static byte[] EncodeBlock(byte[] pcmBlock, int seedStepIndex, out int nextStepIndex, int channelCount)
    {
      if (channelCount > 2 || channelCount < 1)
        throw new InvalidOperationException("input data has to be mono or stereo.");
      if (seedStepIndex > 88 || seedStepIndex < 0)
        throw new ArgumentOutOfRangeException("Seed Step Index has to be in the interval [0,88].");
      byte[] buffer = new byte[(int) (uint) (4.0 + (double) (uint) ((double) pcmBlock.Length / 2.0) * 0.5)];
      BinaryWriter binaryWriter = new BinaryWriter((Stream) new MemoryStream(buffer));
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(pcmBlock));
      short num1 = binaryReader.ReadInt16();
      binaryWriter.Write(num1);
      binaryWriter.Write(Convert.ToByte(seedStepIndex));
      binaryWriter.Write((byte) 0);
      int previousStep1 = seedStepIndex;
      short newPredSample = num1;
      int num2 = 2;
      while (num2 < 64)
      {
        byte num3 = ImaAdpcmCodec.EncodeSample(binaryReader.ReadInt16(), newPredSample, ImaAdpcmCodec.StepTable[previousStep1], out newPredSample);
        int previousStep2 = ImaAdpcmCodec.NextStepIndex(previousStep1, (int) num3 & 15);
        short sample = binaryReader.ReadInt16();
        byte num4 = (byte) ((uint) num3 | (uint) (byte) ((uint) ImaAdpcmCodec.EncodeSample(sample, newPredSample, ImaAdpcmCodec.StepTable[previousStep2], out newPredSample) << 4));
        previousStep1 = ImaAdpcmCodec.NextStepIndex(previousStep2, (int) num4 >> 4);
        binaryWriter.Write(num4);
        num2 += 2;
      }
      byte num5 = ImaAdpcmCodec.EncodeSample(binaryReader.ReadInt16(), newPredSample, ImaAdpcmCodec.StepTable[previousStep1], out newPredSample);
      int num6 = ImaAdpcmCodec.NextStepIndex(previousStep1, (int) num5 & 15);
      binaryWriter.Write(num5);
      nextStepIndex = num6;
      binaryWriter.Close();
      binaryReader.Close();
      return buffer;
    }

    private static byte EncodeSample(short sample, short predSample, int step, out short newPredSample)
    {
      byte num1 = (byte) 0;
      int num2 = (int) sample - (int) predSample;
      int num3 = Math.Abs(num2);
      int num4 = 0;
      if (num2 < num4)
        num1 |= (byte) 8;
      if (num3 >= step)
      {
        num1 |= (byte) 4;
        num3 -= step;
      }
      if (num3 >= step >> 1)
      {
        num1 |= (byte) 2;
        num3 -= step >> 1;
      }
      if (num3 >= step >> 2)
      {
        num1 |= (byte) 1;
        num3 -= step >> 2;
      }
      int num5 = 0;
      int num6 = num2 >= num5 ? (int) sample - num3 + (step >> 3) : (int) sample + num3 - (step >> 3);
      newPredSample = num6 <= (int) short.MaxValue ? (num6 >= (int) short.MinValue ? Convert.ToInt16(num6) : short.MinValue) : short.MaxValue;
      return num1;
    }

    public static byte[] DecodeStream(byte[] adpcmData, int channelCount, int blockAlignment)
    {
      if (channelCount > 2 || channelCount < 1)
        throw new InvalidOperationException("input data has to be mono or stereo.");
      if (blockAlignment < 32 || blockAlignment > 512)
        throw new ArgumentOutOfRangeException("blockAlignment has to be between 32 and 512 bytes.");
      uint num = (uint) ((blockAlignment - 4) * 2);
      byte[] buffer1 = new byte[(long) (adpcmData.Length / blockAlignment) * (long) num * 2L];
      MemoryStream memoryStream1 = new MemoryStream(adpcmData);
      MemoryStream memoryStream2 = new MemoryStream(buffer1);
      byte[] numArray = new byte[blockAlignment];
      while (memoryStream2.Position < memoryStream2.Length)
      {
        memoryStream1.Read(numArray, 0, blockAlignment);
        byte[] buffer2 = ImaAdpcmCodec.DecodeBlock(numArray, channelCount);
        memoryStream2.Write(buffer2, 0, buffer2.Length);
      }
      memoryStream1.Close();
      memoryStream2.Close();
      return buffer1;
    }

    private static byte[] DecodeBlock(byte[] adpcmBlock, int channelCount)
    {
      if (channelCount > 2 || channelCount < 1)
        throw new InvalidOperationException("input data has to be mono or stereo.");
      uint num1 = (uint) ((adpcmBlock.Length - 4) * 2);
      byte[] buffer = new byte[(int) num1 * 2];
      BinaryWriter binaryWriter = new BinaryWriter((Stream) new MemoryStream(buffer));
      BinaryReader binaryReader = new BinaryReader((Stream) new MemoryStream(adpcmBlock));
      short num2 = binaryReader.ReadInt16();
      int num3 = (int) binaryReader.ReadByte();
      int num4 = (int) binaryReader.ReadByte();
      binaryWriter.Write(num2);
      short prevSample1 = num2;
      int previousStep1 = num3;
      int num5 = 2;
      while ((long) num5 < (long) num1)
      {
        byte num6 = binaryReader.ReadByte();
        short prevSample2 = ImaAdpcmCodec.DecodeSample((byte) ((uint) num6 & 15U), prevSample1, ImaAdpcmCodec.StepTable[previousStep1]);
        int previousStep2 = ImaAdpcmCodec.NextStepIndex(previousStep1, (int) num6 & 15);
        binaryWriter.Write(prevSample2);
        prevSample1 = ImaAdpcmCodec.DecodeSample((byte) ((uint) num6 >> 4), prevSample2, ImaAdpcmCodec.StepTable[previousStep2]);
        previousStep1 = ImaAdpcmCodec.NextStepIndex(previousStep2, (int) num6 >> 4);
        binaryWriter.Write(prevSample1);
        num5 += 2;
      }
      short num7 = ImaAdpcmCodec.DecodeSample((byte) ((uint) binaryReader.ReadByte() & 15U), prevSample1, ImaAdpcmCodec.StepTable[previousStep1]);
      binaryWriter.Write(num7);
      binaryReader.Close();
      binaryWriter.Close();
      return buffer;
    }

    private static short DecodeSample(byte sample, short prevSample, int step)
    {
      int num1 = step >> 3;
      if (((int) sample & 1) != 0)
        num1 += step >> 2;
      if (((int) sample & 2) != 0)
        num1 += step >> 1;
      if (((int) sample & 4) != 0)
        num1 += step;
      if (((int) sample & 8) != 0)
        num1 = -num1;
      int num2 = (int) prevSample + num1;
      if (num2 > (int) short.MaxValue)
        num2 = (int) short.MaxValue;
      else if (num2 < (int) short.MinValue)
        num2 = (int) short.MinValue;
      return Convert.ToInt16(num2);
    }

    private static int NextStepIndex(int previousStep, int sample)
    {
      int num = previousStep + ImaAdpcmCodec.NextStepIndexTable[sample];
      if (num > 88)
        num = 88;
      else if (num < 0)
        num = 0;
      return num;
    }
  }
}
