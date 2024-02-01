using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DetailedLocomotionPSMPrereqState : PlayerStateMachinePrereqState
	{
		[Ordinal(3)] 
		[RED("locomotionID")] 
		public gamebbScriptID_Int32 LocomotionID
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public DetailedLocomotionPSMPrereqState()
		{
			LocomotionID = new gamebbScriptID_Int32();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
