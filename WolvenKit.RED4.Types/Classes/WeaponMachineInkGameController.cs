using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class WeaponMachineInkGameController : VendingMachineInkGameController
	{
		[Ordinal(26)] 
		[RED("buttonRef")] 
		public CWeakHandle<WeaponVendorActionWidgetController> ButtonRef
		{
			get => GetPropertyValue<CWeakHandle<WeaponVendorActionWidgetController>>();
			set => SetPropertyValue<CWeakHandle<WeaponVendorActionWidgetController>>(value);
		}
	}
}
