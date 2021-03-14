using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLookAtAddEvent : entAnimTargetAddEvent
	{
		[Ordinal(2)] [RED("outLookAtRef")] public animLookAtRef OutLookAtRef { get; set; }
		[Ordinal(3)] [RED("request")] public animLookAtRequest Request { get; set; }

		public entLookAtAddEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
