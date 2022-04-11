using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkanimPlayVideoEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("videoResource")] 
		public CResourceAsyncReference<Bink> VideoResource
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}
	}
}
