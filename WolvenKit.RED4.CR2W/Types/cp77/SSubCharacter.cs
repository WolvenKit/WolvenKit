using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SSubCharacter : CVariable
	{
		private gamePersistentID _persistentID;
		private CEnum<gamedataSubCharacter> _subCharType;
		private CHandle<EquipmentSystemPlayerData> _equipmentData;

		[Ordinal(0)] 
		[RED("persistentID")] 
		public gamePersistentID PersistentID
		{
			get
			{
				if (_persistentID == null)
				{
					_persistentID = (gamePersistentID) CR2WTypeManager.Create("gamePersistentID", "persistentID", cr2w, this);
				}
				return _persistentID;
			}
			set
			{
				if (_persistentID == value)
				{
					return;
				}
				_persistentID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("subCharType")] 
		public CEnum<gamedataSubCharacter> SubCharType
		{
			get
			{
				if (_subCharType == null)
				{
					_subCharType = (CEnum<gamedataSubCharacter>) CR2WTypeManager.Create("gamedataSubCharacter", "subCharType", cr2w, this);
				}
				return _subCharType;
			}
			set
			{
				if (_subCharType == value)
				{
					return;
				}
				_subCharType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("equipmentData")] 
		public CHandle<EquipmentSystemPlayerData> EquipmentData
		{
			get
			{
				if (_equipmentData == null)
				{
					_equipmentData = (CHandle<EquipmentSystemPlayerData>) CR2WTypeManager.Create("handle:EquipmentSystemPlayerData", "equipmentData", cr2w, this);
				}
				return _equipmentData;
			}
			set
			{
				if (_equipmentData == value)
				{
					return;
				}
				_equipmentData = value;
				PropertySet(this);
			}
		}

		public SSubCharacter(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
