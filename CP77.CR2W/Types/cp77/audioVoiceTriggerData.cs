using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class audioVoiceTriggerData : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("variationIndex")] public CUInt32 VariationIndex { get; set; }
		[Ordinal(2)]  [RED("variationNumber")] public CUInt32 VariationNumber { get; set; }
		[Ordinal(3)]  [RED("overridingVoContext")] public CEnum<locVoiceoverContext> OverridingVoContext { get; set; }

		public audioVoiceTriggerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
