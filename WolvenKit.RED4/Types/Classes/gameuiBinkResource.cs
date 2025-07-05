using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBinkResource : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		public gameuiBinkResource()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
