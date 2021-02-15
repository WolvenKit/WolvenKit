using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("statusEffectRecordID")] public TweakDBID StatusEffectRecordID { get; set; }
		[Ordinal(1)] [RED("tag")] public CName Tag { get; set; }
		[Ordinal(2)] [RED("checkType")] public CString CheckType { get; set; }
		[Ordinal(3)] [RED("invert")] public CBool Invert { get; set; }
		[Ordinal(4)] [RED("fireAndForget")] public CBool FireAndForget { get; set; }

		public StatusEffectPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
