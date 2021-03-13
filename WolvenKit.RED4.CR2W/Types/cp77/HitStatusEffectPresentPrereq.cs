using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitStatusEffectPresentPrereq : GenericHitPrereq
	{
		[Ordinal(5)] [RED("checkType")] public CString CheckType { get; set; }
		[Ordinal(6)] [RED("statusEffectParam")] public CString StatusEffectParam { get; set; }
		[Ordinal(7)] [RED("tag")] public CName Tag { get; set; }

		public HitStatusEffectPresentPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
