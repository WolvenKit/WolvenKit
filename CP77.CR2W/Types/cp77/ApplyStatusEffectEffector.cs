using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectEffector : gameEffector
	{
		[Ordinal(0)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(1)] [RED("applicationTarget")] public CString ApplicationTarget { get; set; }
		[Ordinal(2)] [RED("record")] public TweakDBID Record { get; set; }
		[Ordinal(3)] [RED("removeWithEffector")] public CBool RemoveWithEffector { get; set; }
		[Ordinal(4)] [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(5)] [RED("count")] public CFloat Count { get; set; }
		[Ordinal(6)] [RED("instigator")] public CString Instigator { get; set; }

		public ApplyStatusEffectEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
