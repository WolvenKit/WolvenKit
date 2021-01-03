using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioAdvertMetadata : audioEmitterMetadata
	{
		[Ordinal(0)]  [RED("advertSoundNames")] public CArray<CName> AdvertSoundNames { get; set; }
		[Ordinal(1)]  [RED("filter")] public CEnum<audioAdvertIndoorFilter> Filter { get; set; }
		[Ordinal(2)]  [RED("maxSilenceTime")] public CFloat MaxSilenceTime { get; set; }
		[Ordinal(3)]  [RED("minDistance")] public CFloat MinDistance { get; set; }
		[Ordinal(4)]  [RED("minSilenceTime")] public CFloat MinSilenceTime { get; set; }

		public audioAdvertMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
