using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SubtitlesGameController : BaseSubtitlesGameController
	{
		[Ordinal(0)]  [RED("bbCbHideSceneComment")] public CUInt32 BbCbHideSceneComment { get; set; }
		[Ordinal(1)]  [RED("bbCbShowSceneComment")] public CUInt32 BbCbShowSceneComment { get; set; }
		[Ordinal(2)]  [RED("sceneComment")] public wCHandle<inkTextWidget> SceneComment { get; set; }
		[Ordinal(3)]  [RED("subtitlesPanel")] public wCHandle<inkVerticalPanelWidget> SubtitlesPanel { get; set; }
		[Ordinal(4)]  [RED("uiSceneCommentsBlackboard")] public CHandle<gameIBlackboard> UiSceneCommentsBlackboard { get; set; }

		public SubtitlesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
