using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DeadOnInitTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("preventSkippingDeathAnimation")] public CBool PreventSkippingDeathAnimation { get; set; }

		public DeadOnInitTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
