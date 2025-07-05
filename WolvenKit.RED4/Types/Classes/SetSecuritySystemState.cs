using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetSecuritySystemState : redEvent
	{
		[Ordinal(0)] 
		[RED("state")] 
		public CEnum<ESecuritySystemState> State
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		public SetSecuritySystemState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
