using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioFoleyGlobalMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("fadeoutTime")] public CFloat FadeoutTime { get; set; }
		[Ordinal(2)] [RED("fadeoutRtpc")] public CName FadeoutRtpc { get; set; }

		public audioFoleyGlobalMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
