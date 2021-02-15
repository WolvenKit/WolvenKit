using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entIKTargetAddEvent : entAnimTargetAddEvent
	{
		[Ordinal(2)] [RED("outIKTargetRef")] public animIKTargetRef OutIKTargetRef { get; set; }
		[Ordinal(3)] [RED("orientationProvider")] public CHandle<entIOrientationProvider> OrientationProvider { get; set; }
		[Ordinal(4)] [RED("request")] public animIKTargetRequest Request { get; set; }

		public entIKTargetAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
