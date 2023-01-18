using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class State : MorphData
	{
		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<ESecuritySystemState> State_
		{
			get => GetPropertyValue<CEnum<ESecuritySystemState>>();
			set => SetPropertyValue<CEnum<ESecuritySystemState>>(value);
		}

		public State()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
