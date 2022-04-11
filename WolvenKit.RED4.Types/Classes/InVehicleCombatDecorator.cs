using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InVehicleCombatDecorator : AIVehicleTaskAbstract
	{
		[Ordinal(0)] 
		[RED("targetToChase")] 
		public CWeakHandle<gameObject> TargetToChase
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
