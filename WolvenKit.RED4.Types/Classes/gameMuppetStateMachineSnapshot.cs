using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMuppetStateMachineSnapshot : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("stateMachineId")] 
		public CName StateMachineId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("stateId")] 
		public CName StateId
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameMuppetStateMachineSnapshot()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
