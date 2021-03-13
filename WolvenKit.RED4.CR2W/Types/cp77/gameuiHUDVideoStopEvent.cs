using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoStopEvent : CVariable
	{
		[Ordinal(0)] [RED("videoPathHash")] public CUInt64 VideoPathHash { get; set; }
		[Ordinal(1)] [RED("isSkip")] public CBool IsSkip { get; set; }

		public gameuiHUDVideoStopEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
