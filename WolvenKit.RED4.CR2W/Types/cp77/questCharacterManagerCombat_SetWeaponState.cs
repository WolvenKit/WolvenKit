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
			get
			{
				if (_areaType == null)
				{
					_areaType = (CEnum<gameCityAreaType>) CR2WTypeManager.Create("gameCityAreaType", "areaType", cr2w, this);
				}
				return _areaType;
			}
			set
			{
				if (_areaType == value)
				{
					return;
				}
				_areaType = value;
				PropertySet(this);
			}
		}

		public questCharacterManagerCombat_SetWeaponState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
