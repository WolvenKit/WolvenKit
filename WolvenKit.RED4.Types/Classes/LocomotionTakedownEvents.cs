using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class LocomotionTakedownEvents : LocomotionEventsTransition
	{
		[Ordinal(3)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<LocomotionTakedownInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<LocomotionTakedownInitData>>();
			set => SetPropertyValue<CWeakHandle<LocomotionTakedownInitData>>(value);
		}
	}
}
