using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePopupSettings : CVariable
	{
		[Ordinal(0)]  [RED("closeAtInput")] public CBool CloseAtInput { get; set; }
		[Ordinal(1)]  [RED("pauseGame")] public CBool PauseGame { get; set; }
		[Ordinal(2)]  [RED("fullscreen")] public CBool Fullscreen { get; set; }
		[Ordinal(3)]  [RED("position")] public CEnum<gamePopupPosition> Position { get; set; }
		[Ordinal(4)]  [RED("hideInMenu")] public CBool HideInMenu { get; set; }
		[Ordinal(5)]  [RED("margin")] public inkMargin Margin { get; set; }

		public gamePopupSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
