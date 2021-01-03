using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entIKTargetAddEvent : entAnimTargetAddEvent
	{
		[Ordinal(0)]  [RED("orientationProvider")] public CHandle<entIOrientationProvider> OrientationProvider { get; set; }
		[Ordinal(1)]  [RED("outIKTargetRef")] public animIKTargetRef OutIKTargetRef { get; set; }
		[Ordinal(2)]  [RED("request")] public animIKTargetRequest Request { get; set; }

		public entIKTargetAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
