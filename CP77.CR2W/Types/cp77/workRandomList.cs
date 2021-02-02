using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workRandomList : workIContainerEntry
	{
		[Ordinal(0)]  [RED("minClips")] public CInt8 MinClips { get; set; }
		[Ordinal(1)]  [RED("maxClips")] public CInt8 MaxClips { get; set; }
		[Ordinal(2)]  [RED("dontRepeatLastAnims")] public CInt8 DontRepeatLastAnims { get; set; }
		[Ordinal(3)]  [RED("pauseBetweenLength")] public CFloat PauseBetweenLength { get; set; }
		[Ordinal(4)]  [RED("pauseLengthDeviation")] public CFloat PauseLengthDeviation { get; set; }
		[Ordinal(5)]  [RED("pauseBlendOutTime")] public CFloat PauseBlendOutTime { get; set; }
		[Ordinal(6)]  [RED("weights")] public CArray<CFloat> Weights { get; set; }

		public workRandomList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
