using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PreventionDamageRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)]  [RED("damagePercentValue")] public CFloat DamagePercentValue { get; set; }
		[Ordinal(1)]  [RED("isInternal")] public CBool IsInternal { get; set; }
		[Ordinal(2)]  [RED("targetID")] public entEntityID TargetID { get; set; }
		[Ordinal(3)]  [RED("targetPosition")] public Vector4 TargetPosition { get; set; }

		public PreventionDamageRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
