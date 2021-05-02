using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmmoStateChangeEvent : redEvent
	{
		private wCHandle<gameObject> _weaponOwner;

		[Ordinal(0)] 
		[RED("weaponOwner")] 
		public wCHandle<gameObject> WeaponOwner
		{
			get => GetProperty(ref _weaponOwner);
			set => SetProperty(ref _weaponOwner, value);
		}

		public AmmoStateChangeEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
