using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TerminalInkGameControllerBase : MasterDeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("currentLayoutLibraryID")] public CName CurrentLayoutLibraryID { get; set; }
		[Ordinal(1)]  [RED("currentlyActiveDevices")] public CArray<gamePersistentID> CurrentlyActiveDevices { get; set; }
		[Ordinal(2)]  [RED("layoutID")] public TweakDBID LayoutID { get; set; }
		[Ordinal(3)]  [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(4)]  [RED("mainLayout")] public wCHandle<inkWidget> MainLayout { get; set; }
		[Ordinal(5)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(6)]  [RED("terminalTitle")] public CString TerminalTitle { get; set; }

		public TerminalInkGameControllerBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
