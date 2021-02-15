using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioShockwavePropertyMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("eventName")] public CName EventName { get; set; }
		[Ordinal(2)] [RED("maxDistance")] public CFloat MaxDistance { get; set; }
		[Ordinal(3)] [RED("probability")] public CFloat Probability { get; set; }

		public audioShockwavePropertyMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
