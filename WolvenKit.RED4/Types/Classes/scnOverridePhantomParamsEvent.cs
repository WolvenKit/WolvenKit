using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnOverridePhantomParamsEvent : scnSceneEvent
	{
		[Ordinal(6)] 
		[RED("params")] 
		public scnOverridePhantomParamsEventParams Params
		{
			get => GetPropertyValue<scnOverridePhantomParamsEventParams>();
			set => SetPropertyValue<scnOverridePhantomParamsEventParams>(value);
		}

		public scnOverridePhantomParamsEvent()
		{
			Id = new() { Id = 18446744073709551615 };
			Params = new() { Performer = new() { Id = 4294967040 } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
