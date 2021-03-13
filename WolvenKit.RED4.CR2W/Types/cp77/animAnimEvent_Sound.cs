using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_Sound : animAnimEvent
	{
		[Ordinal(3)] [RED("switches")] public CArray<audioAudSwitch> Switches { get; set; }
		[Ordinal(4)] [RED("params")] public CArray<audioAudParameter> Params { get; set; }
		[Ordinal(5)] [RED("dynamicParams")] public CArray<CName> DynamicParams { get; set; }
		[Ordinal(6)] [RED("metadataContext")] public CName MetadataContext { get; set; }
		[Ordinal(7)] [RED("onlyPlayOn")] public CName OnlyPlayOn { get; set; }
		[Ordinal(8)] [RED("dontPlayOn")] public CName DontPlayOn { get; set; }
		[Ordinal(9)] [RED("playerGenderAlt")] public CEnum<animAnimEventGenderAlt> PlayerGenderAlt { get; set; }

		public animAnimEvent_Sound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
