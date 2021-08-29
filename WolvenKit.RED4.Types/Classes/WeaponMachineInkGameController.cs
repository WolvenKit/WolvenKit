using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponMachineInkGameController : VendingMachineInkGameController
	{
		private CWeakHandle<WeaponVendorActionWidgetController> _buttonRef;

		[Ordinal(25)] 
		[RED("buttonRef")] 
		public CWeakHandle<WeaponVendorActionWidgetController> ButtonRef
		{
			get => GetProperty(ref _buttonRef);
			set => SetProperty(ref _buttonRef, value);
		}
	}
}
