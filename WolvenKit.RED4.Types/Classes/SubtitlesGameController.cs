using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SubtitlesGameController : BaseSubtitlesGameController
	{
		[Ordinal(29)] 
		[RED("sceneComment")] 
		public CWeakHandle<inkTextWidget> SceneComment
		{
			get => GetPropertyValue<CWeakHandle<inkTextWidget>>();
			set => SetPropertyValue<CWeakHandle<inkTextWidget>>(value);
		}

		[Ordinal(30)] 
		[RED("subtitlesPanel")] 
		public CWeakHandle<inkVerticalPanelWidget> SubtitlesPanel
		{
			get => GetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>();
			set => SetPropertyValue<CWeakHandle<inkVerticalPanelWidget>>(value);
		}

		[Ordinal(31)] 
		[RED("bbCbShowSceneComment")] 
		public CHandle<redCallbackObject> BbCbShowSceneComment
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(32)] 
		[RED("bbCbHideSceneComment")] 
		public CHandle<redCallbackObject> BbCbHideSceneComment
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(33)] 
		[RED("uiSceneCommentsBlackboard")] 
		public CWeakHandle<gameIBlackboard> UiSceneCommentsBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}
	}
}
