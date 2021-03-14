using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RepeatLookatEvent : redEvent
	{
		[Ordinal(0)] [RED("target")] public wCHandle<entEntity> Target { get; set; }

		public RepeatLookatEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
