using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyEffectorEffector : gameEffector
	{
		[Ordinal(0)] [RED("target")] public entEntityID Target { get; set; }
		[Ordinal(1)] [RED("applicationTarget")] public CString ApplicationTarget { get; set; }
		[Ordinal(2)] [RED("effectorToApply")] public TweakDBID EffectorToApply { get; set; }

		public ApplyEffectorEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
