using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamestateMachineComponent : gamePlayerControlledComponent
	{
		[Ordinal(3)] 
		[RED("packageName")] 
		public CString PackageName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gamestateMachineComponent()
		{
			Name = "StateMachine";
			PackageName = "playerStateMachine";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
