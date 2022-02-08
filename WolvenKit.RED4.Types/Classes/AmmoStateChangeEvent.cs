using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AmmoStateChangeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("weaponOwner")] 
		public CWeakHandle<gameObject> WeaponOwner
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}
	}
}
