using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiBinkResource : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}
	}
}
