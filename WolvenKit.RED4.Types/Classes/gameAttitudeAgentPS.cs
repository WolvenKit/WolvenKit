using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttitudeAgentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("currentAttitudeGroup")] 
		public CName CurrentAttitudeGroup
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameAttitudeAgentPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
