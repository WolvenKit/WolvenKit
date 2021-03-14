using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EquipmentSystem : gameScriptableSystem
	{
		private CArray<CHandle<EquipmentSystemPlayerData>> _ownerData;

		[Ordinal(0)] 
		[RED("ownerData")] 
		public CArray<CHandle<EquipmentSystemPlayerData>> OwnerData
		{
			get
			{
				if (_ownerData == null)
				{
					_ownerData = (CArray<CHandle<EquipmentSystemPlayerData>>) CR2WTypeManager.Create("array:handle:EquipmentSystemPlayerData", "ownerData", cr2w, this);
				}
				return _ownerData;
			}
			set
			{
				if (_ownerData == value)
				{
					return;
				}
				_ownerData = value;
				PropertySet(this);
			}
		}

		public EquipmentSystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
