using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entLookAtAddEvent : entAnimTargetAddEvent
	{
		[Ordinal(0)]  [RED("outLookAtRef")] public animLookAtRef OutLookAtRef { get; set; }
		[Ordinal(1)]  [RED("request")] public animLookAtRequest Request { get; set; }

		public entLookAtAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
