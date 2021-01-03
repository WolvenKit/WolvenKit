using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiHUDVideoStopEvent : CVariable
	{
		[Ordinal(0)]  [RED("isSkip")] public CBool IsSkip { get; set; }
		[Ordinal(1)]  [RED("videoPathHash")] public CUInt64 VideoPathHash { get; set; }

		public gameuiHUDVideoStopEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
