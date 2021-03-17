using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSlotDataHolder : IScriptable
	{
		private CArray<gameAmmoData> _ammoData;
		private gameSlotWeaponData _weapon;

		[Ordinal(0)] 
		[RED("ammoData")] 
		public CArray<gameAmmoData> AmmoData
		{
			get => GetProperty(ref _ammoData);
			set => SetProperty(ref _ammoData, value);
		}

		[Ordinal(1)] 
		[RED("weapon")] 
		public gameSlotWeaponData Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		public gameSlotDataHolder(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
