using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class InVehicleCombatDecorator : AIVehicleTaskAbstract
	{
		private CWeakHandle<gameObject> _targetToChase;

		[Ordinal(0)] 
		[RED("targetToChase")] 
		public CWeakHandle<gameObject> TargetToChase
		{
			get => GetProperty(ref _targetToChase);
			set => SetProperty(ref _targetToChase, value);
		}
	}
}
