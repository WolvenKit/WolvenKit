using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTutorialOverlayUserData : inkUserData
	{
		[Ordinal(0)]  [RED("overlayId")] public CUInt32 OverlayId { get; set; }
		[Ordinal(1)]  [RED("hideOnInput")] public CBool HideOnInput { get; set; }

		public gameTutorialOverlayUserData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
