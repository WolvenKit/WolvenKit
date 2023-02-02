using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMultiPrereqState : gamePrereqState
	{
		[Ordinal(0)] 
		[RED("nestedStates")] 
		public CArray<CHandle<gamePrereqState>> NestedStates
		{
			get => GetPropertyValue<CArray<CHandle<gamePrereqState>>>();
			set => SetPropertyValue<CArray<CHandle<gamePrereqState>>>(value);
		}

		public gameMultiPrereqState()
		{
			NestedStates = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
