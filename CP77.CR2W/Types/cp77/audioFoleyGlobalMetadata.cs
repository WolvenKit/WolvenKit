using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioFoleyGlobalMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("fadeoutRtpc")] public CName FadeoutRtpc { get; set; }
		[Ordinal(1)]  [RED("fadeoutTime")] public CFloat FadeoutTime { get; set; }

		public audioFoleyGlobalMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
