using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttitudeAgent : gameComponent
	{
		[Ordinal(4)] 
		[RED("baseAttitudeGroup")] 
		public CName BaseAttitudeGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameAttitudeAgent()
		{
			Name = "AttitudeAgent";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
