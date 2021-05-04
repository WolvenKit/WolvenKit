using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeRigTypeMeleeWeaponConfigurationMap : CVariable
	{
		private CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem> _mapItems;

		[Ordinal(0)] 
		[RED("mapItems")] 
		public CArray<audioMeleeRigTypeMeleeWeaponConfigurationMapItem> MapItems
		{
			get => GetProperty(ref _mapItems);
			set => SetProperty(ref _mapItems, value);
		}

		public audioMeleeRigTypeMeleeWeaponConfigurationMap(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
