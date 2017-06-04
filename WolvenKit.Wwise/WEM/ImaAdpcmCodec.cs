using System;
using System.IO;

namespace WolvenKit.Wwise.WEM
{
    public class ImaAdpcmCodec
    {
        private const int PcmSampleSize = 16;
        private const int AdpcmSampleSize = 4;

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
            short.MaxValue
        };

        public static byte[] EncodeStream(byte[] pcmData, int channelCount, int blockAlignment)
        {
            if (channelCount > 2 || channelCount < 1)
                throw new InvalidOperationException("input data has to be mono or stereo.");
            if (blockAlignment < 32 || blockAlignment > 512)
                throw new ArgumentOutOfRangeException("blockAlignment has to be between 32 and 512 bytes.");
            var num1 = pcmData.Length/2;
            var num2 = (uint) ((blockAlignment - 4)*2);
            var buffer1 = new byte[(uint) Math.Ceiling((uint) num1/(double) num2)*blockAlignment];
            var memoryStream1 = new MemoryStream(pcmData);
            var memoryStream2 = new MemoryStream(buffer1);
            var numArray = new byte[(int) num2*2];
            var nextStepIndex = 0;
            while (memoryStream1.Position < memoryStream1.Length)
            {
                memoryStream1.Read(numArray, 0, numArray.Length);
                var buffer2 = EncodeBlock(numArray, nextStepIndex, out nextStepIndex, channelCount);
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
            var buffer = new byte[(int) (uint) (4.0 + (uint) (pcmBlock.Length/2.0)*0.5)];
            var binaryWriter = new BinaryWriter(new MemoryStream(buffer));
            var binaryReader = new BinaryReader(new MemoryStream(pcmBlock));
            var num1 = binaryReader.ReadInt16();
            binaryWriter.Write(num1);
            binaryWriter.Write(Convert.ToByte(seedStepIndex));
            binaryWriter.Write((byte) 0);
            var previousStep1 = seedStepIndex;
            var newPredSample = num1;
            var num2 = 2;
            while (num2 < 64)
            {
                var num3 = EncodeSample(binaryReader.ReadInt16(), newPredSample, StepTable[previousStep1],
                    out newPredSample);
                var previousStep2 = NextStepIndex(previousStep1, num3 & 15);
                var sample = binaryReader.ReadInt16();
                var num4 =
                    (byte)
                        (num3 |
                         (uint)
                             (byte)
                                 ((uint)
                                     EncodeSample(sample, newPredSample, StepTable[previousStep2], out newPredSample) <<
                                  4));
                previousStep1 = NextStepIndex(previousStep2, num4 >> 4);
                binaryWriter.Write(num4);
                num2 += 2;
            }
            var num5 = EncodeSample(binaryReader.ReadInt16(), newPredSample, StepTable[previousStep1], out newPredSample);
            var num6 = NextStepIndex(previousStep1, num5 & 15);
            binaryWriter.Write(num5);
            nextStepIndex = num6;
            binaryWriter.Close();
            binaryReader.Close();
            return buffer;
        }

        private static byte EncodeSample(short sample, short predSample, int step, out short newPredSample)
        {
            byte num1 = 0;
            var num2 = sample - predSample;
            var num3 = Math.Abs(num2);
            var num4 = 0;
            if (num2 < num4)
                num1 |= 8;
            if (num3 >= step)
            {
                num1 |= 4;
                num3 -= step;
            }
            if (num3 >= step >> 1)
            {
                num1 |= 2;
                num3 -= step >> 1;
            }
            if (num3 >= step >> 2)
            {
                num1 |= 1;
                num3 -= step >> 2;
            }
            var num5 = 0;
            var num6 = num2 >= num5 ? sample - num3 + (step >> 3) : sample + num3 - (step >> 3);
            newPredSample = num6 <= (int) short.MaxValue
                ? (num6 >= (int) short.MinValue ? Convert.ToInt16(num6) : short.MinValue)
                : short.MaxValue;
            return num1;
        }

        public static byte[] DecodeStream(byte[] adpcmData, int channelCount, int blockAlignment)
        {
            if (channelCount > 2 || channelCount < 1)
                throw new InvalidOperationException("input data has to be mono or stereo.");
            if (blockAlignment < 32 || blockAlignment > 512)
                throw new ArgumentOutOfRangeException("blockAlignment has to be between 32 and 512 bytes.");
            var num = (uint) ((blockAlignment - 4)*2);
            var buffer1 = new byte[adpcmData.Length/blockAlignment*num*2L];
            var memoryStream1 = new MemoryStream(adpcmData);
            var memoryStream2 = new MemoryStream(buffer1);
            var numArray = new byte[blockAlignment];
            while (memoryStream2.Position < memoryStream2.Length)
            {
                memoryStream1.Read(numArray, 0, blockAlignment);
                var buffer2 = DecodeBlock(numArray, channelCount);
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
            var num1 = (uint) ((adpcmBlock.Length - 4)*2);
            var buffer = new byte[(int) num1*2];
            var binaryWriter = new BinaryWriter(new MemoryStream(buffer));
            var binaryReader = new BinaryReader(new MemoryStream(adpcmBlock));
            var num2 = binaryReader.ReadInt16();
            int num3 = binaryReader.ReadByte();
            int num4 = binaryReader.ReadByte();
            binaryWriter.Write(num2);
            var prevSample1 = num2;
            var previousStep1 = num3;
            var num5 = 2;
            while (num5 < num1)
            {
                var num6 = binaryReader.ReadByte();
                var prevSample2 = DecodeSample((byte) (num6 & 15U), prevSample1, StepTable[previousStep1]);
                var previousStep2 = NextStepIndex(previousStep1, num6 & 15);
                binaryWriter.Write(prevSample2);
                prevSample1 = DecodeSample((byte) ((uint) num6 >> 4), prevSample2, StepTable[previousStep2]);
                previousStep1 = NextStepIndex(previousStep2, num6 >> 4);
                binaryWriter.Write(prevSample1);
                num5 += 2;
            }
            var num7 = DecodeSample((byte) (binaryReader.ReadByte() & 15U), prevSample1, StepTable[previousStep1]);
            binaryWriter.Write(num7);
            binaryReader.Close();
            binaryWriter.Close();
            return buffer;
        }

        private static short DecodeSample(byte sample, short prevSample, int step)
        {
            var num1 = step >> 3;
            if ((sample & 1) != 0)
                num1 += step >> 2;
            if ((sample & 2) != 0)
                num1 += step >> 1;
            if ((sample & 4) != 0)
                num1 += step;
            if ((sample & 8) != 0)
                num1 = -num1;
            var num2 = prevSample + num1;
            if (num2 > short.MaxValue)
                num2 = short.MaxValue;
            else if (num2 < short.MinValue)
                num2 = short.MinValue;
            return Convert.ToInt16(num2);
        }

        private static int NextStepIndex(int previousStep, int sample)
        {
            var num = previousStep + NextStepIndexTable[sample];
            if (num > 88)
                num = 88;
            else if (num < 0)
                num = 0;
            return num;
        }
    }
}