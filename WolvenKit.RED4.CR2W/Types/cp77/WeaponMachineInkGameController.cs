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
			get
			{
				if (_buttonRef == null)
				{
					_buttonRef = (CHandle<WeaponVendorActionWidgetController>) CR2WTypeManager.Create("handle:WeaponVendorActionWidgetController", "buttonRef", cr2w, this);
				}
				return _buttonRef;
			}
			set
			{
				if (_buttonRef == value)
				{
					return;
				}
				_buttonRef = value;
				PropertySet(this);
			}
		}

		public WeaponMachineInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
