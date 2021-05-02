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
		private CUInt32 _bbCbShowSceneComment;
		private CUInt32 _bbCbHideSceneComment;
		private CHandle<gameIBlackboard> _uiSceneCommentsBlackboard;

		[Ordinal(28)] 
		[RED("sceneComment")] 
		public wCHandle<inkTextWidget> SceneComment
		{
			get => GetProperty(ref _sceneComment);
			set => SetProperty(ref _sceneComment, value);
		}

		[Ordinal(29)] 
		[RED("subtitlesPanel")] 
		public wCHandle<inkVerticalPanelWidget> SubtitlesPanel
		{
			get => GetProperty(ref _subtitlesPanel);
			set => SetProperty(ref _subtitlesPanel, value);
		}

		[Ordinal(30)] 
		[RED("bbCbShowSceneComment")] 
		public CUInt32 BbCbShowSceneComment
		{
			get => GetProperty(ref _bbCbShowSceneComment);
			set => SetProperty(ref _bbCbShowSceneComment, value);
		}

		[Ordinal(31)] 
		[RED("bbCbHideSceneComment")] 
		public CUInt32 BbCbHideSceneComment
		{
			get => GetProperty(ref _bbCbHideSceneComment);
			set => SetProperty(ref _bbCbHideSceneComment, value);
		}

		[Ordinal(32)] 
		[RED("uiSceneCommentsBlackboard")] 
		public CHandle<gameIBlackboard> UiSceneCommentsBlackboard
		{
			get => GetProperty(ref _uiSceneCommentsBlackboard);
			set => SetProperty(ref _uiSceneCommentsBlackboard, value);
		}

		public SubtitlesGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
