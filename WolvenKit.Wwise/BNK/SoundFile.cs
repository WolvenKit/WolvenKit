using WolvenKit.Wwise.BNK.Sections;

namespace WolvenKit.Wwise.BNK
{
    public class SoundFile
    {
        public uint data_offset;
        public string effects;
        public uint id;
        public object length_object;
        public object loop_object;
        public string name;
        public bool streamed;

        public double GetLength()
        {
            if (length_object == null)
                return -1.0D;

            if (length_object is HIRC_SoundSFX)
                return (length_object as HIRC_SoundSFX).soundlength;
            if (length_object is HIRC_MusicTrack)
                return (length_object as HIRC_MusicTrack).soundLength;

            return -1.0D;
        }

        public double[] GetLooppoints()
        {
            var points = new double[2];

            if (loop_object == null)
                return points;

            points[0] = (loop_object as HIRC_MusicSegment).looppoint1;
            points[1] = (loop_object as HIRC_MusicSegment).looppoint2;

            return points;
        }

        public override string ToString()
        {
            return (string.IsNullOrWhiteSpace(name) ? id.ToString() : name);
        }
    }
}