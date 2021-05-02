using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterManagerCombat_SetWeaponState : questICharacterManagerCombat_NodeSubType
	{
		private CEnum<gameCityAreaType> _areaType;

		[Ordinal(0)] 
		[RED("areaType")] 
		public CEnum<gameCityAreaType> AreaType
		{
			get => GetProperty(ref _areaType);
			set => SetProperty(ref _areaType, value);
		}

		public questCharacterManagerCombat_SetWeaponState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
