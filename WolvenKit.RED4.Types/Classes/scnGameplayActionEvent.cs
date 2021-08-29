using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnGameplayActionEvent : scnSceneEvent
	{
		private scnPerformerId _performer;
		private CHandle<scnIGameplayActionData> _gameplayActionData;

		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetProperty(ref _performer);
			set => SetProperty(ref _performer, value);
		}

		[Ordinal(7)] 
		[RED("gameplayActionData")] 
		public CHandle<scnIGameplayActionData> GameplayActionData
		{
			get => GetProperty(ref _gameplayActionData);
			set => SetProperty(ref _gameplayActionData, value);
		}
	}
}
