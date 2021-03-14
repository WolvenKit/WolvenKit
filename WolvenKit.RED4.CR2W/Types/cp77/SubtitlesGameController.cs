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
			get
			{
				if (_sceneComment == null)
				{
					_sceneComment = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "sceneComment", cr2w, this);
				}
				return _sceneComment;
			}
			set
			{
				if (_sceneComment == value)
				{
					return;
				}
				_sceneComment = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("subtitlesPanel")] 
		public wCHandle<inkVerticalPanelWidget> SubtitlesPanel
		{
			get
			{
				if (_subtitlesPanel == null)
				{
					_subtitlesPanel = (wCHandle<inkVerticalPanelWidget>) CR2WTypeManager.Create("whandle:inkVerticalPanelWidget", "subtitlesPanel", cr2w, this);
				}
				return _subtitlesPanel;
			}
			set
			{
				if (_subtitlesPanel == value)
				{
					return;
				}
				_subtitlesPanel = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("bbCbShowSceneComment")] 
		public CUInt32 BbCbShowSceneComment
		{
			get
			{
				if (_bbCbShowSceneComment == null)
				{
					_bbCbShowSceneComment = (CUInt32) CR2WTypeManager.Create("Uint32", "bbCbShowSceneComment", cr2w, this);
				}
				return _bbCbShowSceneComment;
			}
			set
			{
				if (_bbCbShowSceneComment == value)
				{
					return;
				}
				_bbCbShowSceneComment = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("bbCbHideSceneComment")] 
		public CUInt32 BbCbHideSceneComment
		{
			get
			{
				if (_bbCbHideSceneComment == null)
				{
					_bbCbHideSceneComment = (CUInt32) CR2WTypeManager.Create("Uint32", "bbCbHideSceneComment", cr2w, this);
				}
				return _bbCbHideSceneComment;
			}
			set
			{
				if (_bbCbHideSceneComment == value)
				{
					return;
				}
				_bbCbHideSceneComment = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("uiSceneCommentsBlackboard")] 
		public CHandle<gameIBlackboard> UiSceneCommentsBlackboard
		{
			get
			{
				if (_uiSceneCommentsBlackboard == null)
				{
					_uiSceneCommentsBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiSceneCommentsBlackboard", cr2w, this);
				}
				return _uiSceneCommentsBlackboard;
			}
			set
			{
				if (_uiSceneCommentsBlackboard == value)
				{
					return;
				}
				_uiSceneCommentsBlackboard = value;
				PropertySet(this);
			}
		}

		public SubtitlesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
