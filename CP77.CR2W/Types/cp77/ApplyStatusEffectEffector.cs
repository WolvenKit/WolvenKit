using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectEffector : gameEffector
	{
		[Ordinal(0)]  [RED("applicationTarget")] public CString ApplicationTarget { get; set; }
		[Ordinal(1)]  [RED("count")] public CFloat Count { get; set; }
		[Ordinal(2)]  [RED("instigator")] public CString Instigator { get; set; }
		[Ordinal(3)]  [RED("inverted")] public CBool Inverted { get; set; }
		[Ordinal(4)]  [RED("record")] public TweakDBID Record { get; set; }
		[Ordinal(5)]  [RED("removeWithEffector")] public CBool RemoveWithEffector { get; set; }
		[Ordinal(6)]  [RED("target")] public wCHandle<gameObject> Target { get; set; }

		public ApplyStatusEffectEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
