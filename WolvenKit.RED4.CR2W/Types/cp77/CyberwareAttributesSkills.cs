using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberwareAttributesSkills : gameuiWidgetGameController
	{
		private CyberwareAttributes_ContainersStruct _attributes;
		private CyberwareAttributes_ResistancesStruct _resistances;
		private inkTextWidgetReference _levelUpPoints;
		private CHandle<gameIBlackboard> _uiBlackboard;
		private wCHandle<PlayerPuppet> _playerPuppet;
		private CInt32 _devPoints;

		[Ordinal(2)] 
		[RED("attributes")] 
		public CyberwareAttributes_ContainersStruct Attributes
		{
			get
			{
				if (_attributes == null)
				{
					_attributes = (CyberwareAttributes_ContainersStruct) CR2WTypeManager.Create("CyberwareAttributes_ContainersStruct", "attributes", cr2w, this);
				}
				return _attributes;
			}
			set
			{
				if (_attributes == value)
				{
					return;
				}
				_attributes = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("resistances")] 
		public CyberwareAttributes_ResistancesStruct Resistances
		{
			get
			{
				if (_resistances == null)
				{
					_resistances = (CyberwareAttributes_ResistancesStruct) CR2WTypeManager.Create("CyberwareAttributes_ResistancesStruct", "resistances", cr2w, this);
				}
				return _resistances;
			}
			set
			{
				if (_resistances == value)
				{
					return;
				}
				_resistances = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("levelUpPoints")] 
		public inkTextWidgetReference LevelUpPoints
		{
			get
			{
				if (_levelUpPoints == null)
				{
					_levelUpPoints = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "levelUpPoints", cr2w, this);
				}
				return _levelUpPoints;
			}
			set
			{
				if (_levelUpPoints == value)
				{
					return;
				}
				_levelUpPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("uiBlackboard")] 
		public CHandle<gameIBlackboard> UiBlackboard
		{
			get
			{
				if (_uiBlackboard == null)
				{
					_uiBlackboard = (CHandle<gameIBlackboard>) CR2WTypeManager.Create("handle:gameIBlackboard", "uiBlackboard", cr2w, this);
				}
				return _uiBlackboard;
			}
			set
			{
				if (_uiBlackboard == value)
				{
					return;
				}
				_uiBlackboard = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("playerPuppet")] 
		public wCHandle<PlayerPuppet> PlayerPuppet
		{
			get
			{
				if (_playerPuppet == null)
				{
					_playerPuppet = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "playerPuppet", cr2w, this);
				}
				return _playerPuppet;
			}
			set
			{
				if (_playerPuppet == value)
				{
					return;
				}
				_playerPuppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("devPoints")] 
		public CInt32 DevPoints
		{
			get
			{
				if (_devPoints == null)
				{
					_devPoints = (CInt32) CR2WTypeManager.Create("Int32", "devPoints", cr2w, this);
				}
				return _devPoints;
			}
			set
			{
				if (_devPoints == value)
				{
					return;
				}
				_devPoints = value;
				PropertySet(this);
			}
		}

		public CyberwareAttributesSkills(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
