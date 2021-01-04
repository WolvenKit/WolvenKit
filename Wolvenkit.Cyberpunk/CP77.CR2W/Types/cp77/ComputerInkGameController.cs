using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(0)]  [RED("currentLayoutLibraryID")] public CName CurrentLayoutLibraryID { get; set; }
		[Ordinal(1)]  [RED("devicesMenuInitialized")] public CBool DevicesMenuInitialized { get; set; }
		[Ordinal(2)]  [RED("devicesMenuSpawnRequested")] public CBool DevicesMenuSpawnRequested { get; set; }
		[Ordinal(3)]  [RED("devicesMenuSpawned")] public CBool DevicesMenuSpawned { get; set; }
		[Ordinal(4)]  [RED("forceOpenDocumentAdress")] public SDocumentAdress ForceOpenDocumentAdress { get; set; }
		[Ordinal(5)]  [RED("forceOpenDocumentType")] public CEnum<EDocumentType> ForceOpenDocumentType { get; set; }
		[Ordinal(6)]  [RED("layoutID")] public TweakDBID LayoutID { get; set; }
		[Ordinal(7)]  [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(8)]  [RED("mainLayout")] public wCHandle<inkWidget> MainLayout { get; set; }
		[Ordinal(9)]  [RED("menuInitialized")] public CBool MenuInitialized { get; set; }
		[Ordinal(10)]  [RED("onBannerWidgetsUpdateListener")] public CUInt32 OnBannerWidgetsUpdateListener { get; set; }
		[Ordinal(11)]  [RED("onFileThumbnailWidgetsUpdateListener")] public CUInt32 OnFileThumbnailWidgetsUpdateListener { get; set; }
		[Ordinal(12)]  [RED("onFileWidgetsUpdateListener")] public CUInt32 OnFileWidgetsUpdateListener { get; set; }
		[Ordinal(13)]  [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }
		[Ordinal(14)]  [RED("onMailThumbnailWidgetsUpdateListener")] public CUInt32 OnMailThumbnailWidgetsUpdateListener { get; set; }
		[Ordinal(15)]  [RED("onMailWidgetsUpdateListener")] public CUInt32 OnMailWidgetsUpdateListener { get; set; }
		[Ordinal(16)]  [RED("onMainMenuButtonWidgetsUpdateListener")] public CUInt32 OnMainMenuButtonWidgetsUpdateListener { get; set; }
		[Ordinal(17)]  [RED("onMenuButtonWidgetsUpdateListener")] public CUInt32 OnMenuButtonWidgetsUpdateListener { get; set; }

		public ComputerInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
