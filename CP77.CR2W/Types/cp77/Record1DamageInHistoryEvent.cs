using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Record1DamageInHistoryEvent : redEvent
	{
		[Ordinal(0)] [RED("source")] public wCHandle<gameObject> Source { get; set; }

		public Record1DamageInHistoryEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
