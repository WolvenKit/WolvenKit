using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ChangeJuryrigTrapState : redEvent
	{
		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<EJuryrigTrapState> NewState
		{
			get => GetPropertyValue<CEnum<EJuryrigTrapState>>();
			set => SetPropertyValue<CEnum<EJuryrigTrapState>>(value);
		}

		public ChangeJuryrigTrapState()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
