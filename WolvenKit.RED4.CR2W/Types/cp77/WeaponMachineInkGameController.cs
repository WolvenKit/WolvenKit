using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponMachineInkGameController : VendingMachineInkGameController
	{
		private CHandle<WeaponVendorActionWidgetController> _buttonRef;

		[Ordinal(25)] 
		[RED("buttonRef")] 
		public CHandle<WeaponVendorActionWidgetController> ButtonRef
		{
			get => GetProperty(ref _buttonRef);
			set => SetProperty(ref _buttonRef, value);
		}

		public WeaponMachineInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
