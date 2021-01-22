using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entLookAtAddEvent : entAnimTargetAddEvent
	{
		[Ordinal(0)]  [RED("outLookAtRef")] public animLookAtRef OutLookAtRef { get; set; }
		[Ordinal(1)]  [RED("request")] public animLookAtRequest Request { get; set; }

		public entLookAtAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
