using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkanimChangeTexturePartEvent : inkanimEvent
	{
		[Ordinal(1)] 
		[RED("imageTexturePartName")] 
		public CName ImageTexturePartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public inkanimChangeTexturePartEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
