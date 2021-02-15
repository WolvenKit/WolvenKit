using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ComputerInkGameController : DeviceInkGameControllerBase
	{
		[Ordinal(16)] [RED("layoutID")] public TweakDBID LayoutID { get; set; }
		[Ordinal(17)] [RED("currentLayoutLibraryID")] public CName CurrentLayoutLibraryID { get; set; }
		[Ordinal(18)] [RED("mainLayout")] public wCHandle<inkWidget> MainLayout { get; set; }
		[Ordinal(19)] [RED("devicesMenuInitialized")] public CBool DevicesMenuInitialized { get; set; }
		[Ordinal(20)] [RED("devicesMenuSpawned")] public CBool DevicesMenuSpawned { get; set; }
		[Ordinal(21)] [RED("devicesMenuSpawnRequested")] public CBool DevicesMenuSpawnRequested { get; set; }
		[Ordinal(22)] [RED("menuInitialized")] public CBool MenuInitialized { get; set; }
		[Ordinal(23)] [RED("mainDisplayWidget")] public wCHandle<inkVideoWidget> MainDisplayWidget { get; set; }
		[Ordinal(24)] [RED("forceOpenDocumentType")] public CEnum<EDocumentType> ForceOpenDocumentType { get; set; }
		[Ordinal(25)] [RED("forceOpenDocumentAdress")] public SDocumentAdress ForceOpenDocumentAdress { get; set; }
		[Ordinal(26)] [RED("onMailThumbnailWidgetsUpdateListener")] public CUInt32 OnMailThumbnailWidgetsUpdateListener { get; set; }
		[Ordinal(27)] [RED("onFileThumbnailWidgetsUpdateListener")] public CUInt32 OnFileThumbnailWidgetsUpdateListener { get; set; }
		[Ordinal(28)] [RED("onMailWidgetsUpdateListener")] public CUInt32 OnMailWidgetsUpdateListener { get; set; }
		[Ordinal(29)] [RED("onFileWidgetsUpdateListener")] public CUInt32 OnFileWidgetsUpdateListener { get; set; }
		[Ordinal(30)] [RED("onMenuButtonWidgetsUpdateListener")] public CUInt32 OnMenuButtonWidgetsUpdateListener { get; set; }
		[Ordinal(31)] [RED("onMainMenuButtonWidgetsUpdateListener")] public CUInt32 OnMainMenuButtonWidgetsUpdateListener { get; set; }
		[Ordinal(32)] [RED("onBannerWidgetsUpdateListener")] public CUInt32 OnBannerWidgetsUpdateListener { get; set; }
		[Ordinal(33)] [RED("onGlitchingStateChangedListener")] public CUInt32 OnGlitchingStateChangedListener { get; set; }

		public ComputerInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
