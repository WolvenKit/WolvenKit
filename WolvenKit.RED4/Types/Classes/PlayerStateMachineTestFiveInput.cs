using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlayerStateMachineTestFiveInput : IScriptable
	{
		[Ordinal(0)] 
		[RED("counter")] 
		public CInt32 Counter
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public PlayerStateMachineTestFiveInput()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
