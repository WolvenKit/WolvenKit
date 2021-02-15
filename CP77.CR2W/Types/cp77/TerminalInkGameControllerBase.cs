using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TerminalInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		[Ordinal(18)] [RED("layoutID")] public TweakDBID LayoutID { get; set; }
		[Ordinal(19)] [RED("currentLayoutLibraryID")] public CName CurrentLayoutLibraryID { get; set; }
		[Ordinal(20)] [RED("mainLayout")] public wCHandle<inkWidget> MainLayout { get; set; }
		[Ordinal(21)] [RED("currentlyActiveDevices")] public CArray<gamePersistentID> CurrentlyActiveDevices { get; set; }
		[Ordinal(22)] [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(23)] [RED("terminalTitle")] public CString TerminalTitle { get; set; }
		[Ordinal(24)] [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }

		public TerminalInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
