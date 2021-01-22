using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DismembermentDebrisEvent : redEvent
	{
		[Ordinal(0)]  [RED("resourcePath")] public CString ResourcePath { get; set; }
		[Ordinal(1)]  [RED("strength")] public CFloat Strength { get; set; }

		public DismembermentDebrisEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
