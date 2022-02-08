using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleTransition : DefaultTransition
	{
		[Ordinal(0)] 
		[RED("stateMachineInitData")] 
		public CWeakHandle<VehicleTransitionInitData> StateMachineInitData
		{
			get => GetPropertyValue<CWeakHandle<VehicleTransitionInitData>>();
			set => SetPropertyValue<CWeakHandle<VehicleTransitionInitData>>(value);
		}
	}
}
