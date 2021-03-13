using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckStimRevealsInstigatorPosition : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("checkStimType")] public CBool CheckStimType { get; set; }
		[Ordinal(1)] [RED("stimType")] public CEnum<gamedataStimType> StimType { get; set; }

		public CheckStimRevealsInstigatorPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
