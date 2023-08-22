using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsSpawnEntityEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("params")] 
		public scneventsSpawnEntityEventParams Params
		{
			get => GetPropertyValue<scneventsSpawnEntityEventParams>();
			set => SetPropertyValue<scneventsSpawnEntityEventParams>(value);
		}

		public scneventsSpawnEntityEvent()
		{
			Id = new scnSceneEventId { Id = long.MaxValue };
			Params = new scneventsSpawnEntityEventParams { Performer = new scnPerformerId { Id = 4294967040 }, ReferencePerformer = new scnPerformerId { Id = 4294967040 }, FallbackData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
