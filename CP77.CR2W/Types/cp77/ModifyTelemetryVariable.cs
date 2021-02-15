using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ModifyTelemetryVariable : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] [RED("dataTrackingFact")] public CEnum<ETelemetryData> DataTrackingFact { get; set; }
		[Ordinal(2)] [RED("value")] public CInt32 Value { get; set; }

		public ModifyTelemetryVariable(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
