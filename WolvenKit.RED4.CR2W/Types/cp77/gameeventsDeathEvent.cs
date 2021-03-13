using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameeventsDeathEvent : redEvent
	{
		[Ordinal(0)] [RED("instigator")] public wCHandle<gameObject> Instigator { get; set; }

		public gameeventsDeathEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
