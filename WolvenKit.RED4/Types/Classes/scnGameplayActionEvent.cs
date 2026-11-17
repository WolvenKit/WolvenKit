using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnGameplayActionEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		[Ordinal(7)] 
		[RED("gameplayActionData")] 
		public CHandle<scnIGameplayActionData> GameplayActionData
		{
			get => GetPropertyValue<CHandle<scnIGameplayActionData>>();
			set => SetPropertyValue<CHandle<scnIGameplayActionData>>(value);
		}

		public scnGameplayActionEvent()
		{
			Id = new scnSceneEventId();
			Performer = new scnPerformerId();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
