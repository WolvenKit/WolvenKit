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
			Id = new scnSceneEventId();
			Params = new scneventsSpawnEntityEventParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
