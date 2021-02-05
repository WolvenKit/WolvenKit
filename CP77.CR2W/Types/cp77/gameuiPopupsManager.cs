using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiPopupsManager : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("bracketsContainer")] public inkCompoundWidgetReference BracketsContainer { get; set; }
		[Ordinal(1)]  [RED("tutorialOverlayContainer")] public inkCompoundWidgetReference TutorialOverlayContainer { get; set; }
		[Ordinal(2)]  [RED("bracketLibraryID")] public CName BracketLibraryID { get; set; }

		public gameuiPopupsManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
