using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnUnmountEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("performer")] 
		public scnPerformerId Performer
		{
			get => GetPropertyValue<scnPerformerId>();
			set => SetPropertyValue<scnPerformerId>(value);
		}

		public scnUnmountEvent()
		{
			Id = new scnSceneEventId();
			Performer = new scnPerformerId();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
