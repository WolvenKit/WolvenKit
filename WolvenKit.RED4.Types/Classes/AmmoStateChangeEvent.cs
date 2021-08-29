using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AmmoStateChangeEvent : redEvent
	{
		private CWeakHandle<gameObject> _weaponOwner;

		[Ordinal(0)] 
		[RED("weaponOwner")] 
		public CWeakHandle<gameObject> WeaponOwner
		{
			get => GetProperty(ref _weaponOwner);
			set => SetProperty(ref _weaponOwner, value);
		}
	}
}
