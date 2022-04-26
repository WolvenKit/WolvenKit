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
			Id = new() { Id = 18446744073709551615 };
			Params = new() { Performer = new() { Id = 4294967040 } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
