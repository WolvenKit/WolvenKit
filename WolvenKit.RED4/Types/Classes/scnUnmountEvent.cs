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
			Id = new scnSceneEventId { Id = long.MaxValue };
			Performer = new scnPerformerId { Id = 4294967040 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
