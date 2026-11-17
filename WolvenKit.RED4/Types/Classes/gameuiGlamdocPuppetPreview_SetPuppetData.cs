using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiGlamdocPuppetPreview_SetPuppetData : redEvent
	{
		[Ordinal(0)] 
		[RED("cyberware")] 
		public CInt32 Cyberware
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("menu")] 
		public CInt32 Menu
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("color")] 
		public CInt32 Color
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameuiGlamdocPuppetPreview_SetPuppetData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
