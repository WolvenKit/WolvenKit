using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsDespawnEntityEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("params")] 
		public scneventsDespawnEntityEventParams Params
		{
			get => GetPropertyValue<scneventsDespawnEntityEventParams>();
			set => SetPropertyValue<scneventsDespawnEntityEventParams>(value);
		}

		public scneventsDespawnEntityEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			Params = new scneventsDespawnEntityEventParams { Performer = new scnPerformerId { Id = 4294967040 } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
