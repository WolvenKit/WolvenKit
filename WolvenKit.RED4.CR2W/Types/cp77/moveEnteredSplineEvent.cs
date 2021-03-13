using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class moveEnteredSplineEvent : redEvent
	{
		[Ordinal(0)] [RED("useDoors")] public CBool UseDoors { get; set; }

		public moveEnteredSplineEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
