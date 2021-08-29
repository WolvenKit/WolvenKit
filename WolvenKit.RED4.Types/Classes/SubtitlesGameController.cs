using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubtitlesGameController : BaseSubtitlesGameController
	{
		private CWeakHandle<inkTextWidget> _sceneComment;
		private CWeakHandle<inkVerticalPanelWidget> _subtitlesPanel;
		private CHandle<redCallbackObject> _bbCbShowSceneComment;
		private CHandle<redCallbackObject> _bbCbHideSceneComment;
		private CWeakHandle<gameIBlackboard> _uiSceneCommentsBlackboard;

		[Ordinal(29)] 
		[RED("sceneComment")] 
		public CWeakHandle<inkTextWidget> SceneComment
		{
			get => GetProperty(ref _sceneComment);
			set => SetProperty(ref _sceneComment, value);
		}

		[Ordinal(30)] 
		[RED("subtitlesPanel")] 
		public CWeakHandle<inkVerticalPanelWidget> SubtitlesPanel
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
		public CWeakHandle<gameIBlackboard> UiSceneCommentsBlackboard
		{
			get => GetProperty(ref _uiSceneCommentsBlackboard);
			set => SetProperty(ref _uiSceneCommentsBlackboard, value);
		}
	}
}
