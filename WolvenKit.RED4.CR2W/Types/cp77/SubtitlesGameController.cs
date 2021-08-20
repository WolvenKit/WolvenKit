using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SubtitlesGameController : BaseSubtitlesGameController
	{
		private wCHandle<inkTextWidget> _sceneComment;
		private wCHandle<inkVerticalPanelWidget> _subtitlesPanel;
		private CHandle<redCallbackObject> _bbCbShowSceneComment;
		private CHandle<redCallbackObject> _bbCbHideSceneComment;
		private wCHandle<gameIBlackboard> _uiSceneCommentsBlackboard;

		[Ordinal(29)] 
		[RED("sceneComment")] 
		public wCHandle<inkTextWidget> SceneComment
		{
			get => GetProperty(ref _sceneComment);
			set => SetProperty(ref _sceneComment, value);
		}

		[Ordinal(30)] 
		[RED("subtitlesPanel")] 
		public wCHandle<inkVerticalPanelWidget> SubtitlesPanel
		{
			get => GetProperty(ref _subtitlesPanel);
			set => SetProperty(ref _subtitlesPanel, value);
		}

		[Ordinal(31)] 
		[RED("bbCbShowSceneComment")] 
		public CHandle<redCallbackObject> BbCbShowSceneComment
		{
			get => GetProperty(ref _bbCbShowSceneComment);
			set => SetProperty(ref _bbCbShowSceneComment, value);
		}

		[Ordinal(32)] 
		[RED("bbCbHideSceneComment")] 
		public CHandle<redCallbackObject> BbCbHideSceneComment
		{
			get => GetProperty(ref _bbCbHideSceneComment);
			set => SetProperty(ref _bbCbHideSceneComment, value);
		}

		[Ordinal(33)] 
		[RED("uiSceneCommentsBlackboard")] 
		public wCHandle<gameIBlackboard> UiSceneCommentsBlackboard
		{
			get => GetProperty(ref _uiSceneCommentsBlackboard);
			set => SetProperty(ref _uiSceneCommentsBlackboard, value);
		}

		public SubtitlesGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
