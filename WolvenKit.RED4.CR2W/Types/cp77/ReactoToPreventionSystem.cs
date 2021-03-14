using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactoToPreventionSystem : redEvent
	{
		[Ordinal(0)] [RED("wakeUp")] public CBool WakeUp { get; set; }

		public ReactoToPreventionSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
