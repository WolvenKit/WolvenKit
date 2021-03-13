using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioSpatialSoundLimitMetadata : audioAudioMetadata
	{
		[Ordinal(1)] [RED("eventNames")] public CArray<CName> EventNames { get; set; }
		[Ordinal(2)] [RED("writeOnlyEventNames")] public CArray<CName> WriteOnlyEventNames { get; set; }
		[Ordinal(3)] [RED("readOnlyEventNames")] public CArray<CName> ReadOnlyEventNames { get; set; }
		[Ordinal(4)] [RED("radius")] public CFloat Radius { get; set; }

		public audioSpatialSoundLimitMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
