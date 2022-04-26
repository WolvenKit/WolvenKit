using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimPlayVideoEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("videoResource")] 
		public CResourceAsyncReference<Bink> VideoResource
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		public inkanimPlayVideoEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
