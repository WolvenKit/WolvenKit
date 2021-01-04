using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RepeatLookatEvent : redEvent
	{
		[Ordinal(0)]  [RED("target")] public wCHandle<entEntity> Target { get; set; }

		public RepeatLookatEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
