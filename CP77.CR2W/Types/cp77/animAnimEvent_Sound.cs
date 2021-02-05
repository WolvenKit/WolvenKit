using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_Sound : animAnimEvent
	{
		[Ordinal(0)]  [RED("switches")] public CArray<audioAudSwitch> Switches { get; set; }
		[Ordinal(1)]  [RED("params")] public CArray<audioAudParameter> Params { get; set; }
		[Ordinal(2)]  [RED("dynamicParams")] public CArray<CName> DynamicParams { get; set; }
		[Ordinal(3)]  [RED("metadataContext")] public CName MetadataContext { get; set; }
		[Ordinal(4)]  [RED("onlyPlayOn")] public CName OnlyPlayOn { get; set; }
		[Ordinal(5)]  [RED("dontPlayOn")] public CName DontPlayOn { get; set; }
		[Ordinal(6)]  [RED("playerGenderAlt")] public CEnum<animAnimEventGenderAlt> PlayerGenderAlt { get; set; }

		public animAnimEvent_Sound(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
