using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameGodModeData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<gameGodModeType> Type
		{
			get => GetPropertyValue<CEnum<gameGodModeType>>();
			set => SetPropertyValue<CEnum<gameGodModeType>>(value);
		}

		[Ordinal(1)] 
		[RED("source")] 
		public CName Source
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameGodModeData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
