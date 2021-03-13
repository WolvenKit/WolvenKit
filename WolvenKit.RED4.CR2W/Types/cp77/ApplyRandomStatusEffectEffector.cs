using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyRandomStatusEffectEffector : gameEffector
	{
		[Ordinal(0)] [RED("target")] public wCHandle<gameObject> Target { get; set; }
		[Ordinal(1)] [RED("applicationTarget")] public CString ApplicationTarget { get; set; }
		[Ordinal(2)] [RED("effects")] public CArray<TweakDBID> Effects { get; set; }
		[Ordinal(3)] [RED("appliedEffect")] public TweakDBID AppliedEffect { get; set; }

		public ApplyRandomStatusEffectEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
