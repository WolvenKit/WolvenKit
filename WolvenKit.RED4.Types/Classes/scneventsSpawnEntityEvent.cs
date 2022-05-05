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
			Id = new() { Id = 18446744073709551615 };
			Params = new() { Performer = new() { Id = 4294967040 }, ReferencePerformer = new() { Id = 4294967040 }, FallbackData = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
