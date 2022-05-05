using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimSetStyleEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("style")] 
		public CResourceAsyncReference<inkStyleResource> Style
		{
			get => GetPropertyValue<CResourceAsyncReference<inkStyleResource>>();
			set => SetPropertyValue<CResourceAsyncReference<inkStyleResource>>(value);
		}

		public inkanimSetStyleEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
