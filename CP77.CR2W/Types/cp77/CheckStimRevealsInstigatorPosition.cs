using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CheckStimRevealsInstigatorPosition : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("checkStimType")] public CBool CheckStimType { get; set; }
		[Ordinal(1)]  [RED("stimType")] public CEnum<gamedataStimType> StimType { get; set; }

		public CheckStimRevealsInstigatorPosition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
