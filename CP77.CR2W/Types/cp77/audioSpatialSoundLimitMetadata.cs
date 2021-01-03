using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class audioSpatialSoundLimitMetadata : audioAudioMetadata
	{
		[Ordinal(0)]  [RED("eventNames")] public CArray<CName> EventNames { get; set; }
		[Ordinal(1)]  [RED("radius")] public CFloat Radius { get; set; }
		[Ordinal(2)]  [RED("readOnlyEventNames")] public CArray<CName> ReadOnlyEventNames { get; set; }
		[Ordinal(3)]  [RED("writeOnlyEventNames")] public CArray<CName> WriteOnlyEventNames { get; set; }

		public audioSpatialSoundLimitMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
