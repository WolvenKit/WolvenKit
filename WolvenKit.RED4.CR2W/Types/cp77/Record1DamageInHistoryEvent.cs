using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Record1DamageInHistoryEvent : redEvent
	{
		[Ordinal(0)] [RED("source")] public wCHandle<gameObject> Source { get; set; }

		public Record1DamageInHistoryEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
