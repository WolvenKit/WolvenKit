using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubtitlesGameController : BaseSubtitlesGameController
	{
		[Ordinal(28)] [RED("sceneComment")] public wCHandle<inkTextWidget> SceneComment { get; set; }
		[Ordinal(29)] [RED("subtitlesPanel")] public wCHandle<inkVerticalPanelWidget> SubtitlesPanel { get; set; }
		[Ordinal(30)] [RED("bbCbShowSceneComment")] public CUInt32 BbCbShowSceneComment { get; set; }
		[Ordinal(31)] [RED("bbCbHideSceneComment")] public CUInt32 BbCbHideSceneComment { get; set; }
		[Ordinal(32)] [RED("uiSceneCommentsBlackboard")] public CHandle<gameIBlackboard> UiSceneCommentsBlackboard { get; set; }

		public SubtitlesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
