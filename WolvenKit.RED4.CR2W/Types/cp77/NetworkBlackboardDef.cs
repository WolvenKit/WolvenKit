using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NetworkBlackboardDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _minigameDef;
		private gamebbScriptID_String _networkName;
		private gamebbScriptID_Variant _networkTDBID;
		private gamebbScriptID_Int32 _devicesCount;
		private gamebbScriptID_EntityID _deviceID;
		private gamebbScriptID_Bool _officerBreach;
		private gamebbScriptID_Bool _suicideBreach;
		private gamebbScriptID_Bool _remoteBreach;
		private gamebbScriptID_Bool _itemBreach;
		private gamebbScriptID_Int32 _attempt;
		private gamebbScriptID_Variant _selectedMinigameDef;

		[Ordinal(0)] 
		[RED("MinigameDef")] 
		public gamebbScriptID_Variant MinigameDef
		{
			get
			{
				if (_minigameDef == null)
				{
					_minigameDef = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "MinigameDef", cr2w, this);
				}
				return _minigameDef;
			}
			set
			{
				if (_minigameDef == value)
				{
					return;
				}
				_minigameDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("NetworkName")] 
		public gamebbScriptID_String NetworkName
		{
			get
			{
				if (_networkName == null)
				{
					_networkName = (gamebbScriptID_String) CR2WTypeManager.Create("gamebbScriptID_String", "NetworkName", cr2w, this);
				}
				return _networkName;
			}
			set
			{
				if (_networkName == value)
				{
					return;
				}
				_networkName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("NetworkTDBID")] 
		public gamebbScriptID_Variant NetworkTDBID
		{
			get
			{
				if (_networkTDBID == null)
				{
					_networkTDBID = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "NetworkTDBID", cr2w, this);
				}
				return _networkTDBID;
			}
			set
			{
				if (_networkTDBID == value)
				{
					return;
				}
				_networkTDBID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("DevicesCount")] 
		public gamebbScriptID_Int32 DevicesCount
		{
			get
			{
				if (_devicesCount == null)
				{
					_devicesCount = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "DevicesCount", cr2w, this);
				}
				return _devicesCount;
			}
			set
			{
				if (_devicesCount == value)
				{
					return;
				}
				_devicesCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("DeviceID")] 
		public gamebbScriptID_EntityID DeviceID
		{
			get
			{
				if (_deviceID == null)
				{
					_deviceID = (gamebbScriptID_EntityID) CR2WTypeManager.Create("gamebbScriptID_EntityID", "DeviceID", cr2w, this);
				}
				return _deviceID;
			}
			set
			{
				if (_deviceID == value)
				{
					return;
				}
				_deviceID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("OfficerBreach")] 
		public gamebbScriptID_Bool OfficerBreach
		{
			get
			{
				if (_officerBreach == null)
				{
					_officerBreach = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "OfficerBreach", cr2w, this);
				}
				return _officerBreach;
			}
			set
			{
				if (_officerBreach == value)
				{
					return;
				}
				_officerBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("SuicideBreach")] 
		public gamebbScriptID_Bool SuicideBreach
		{
			get
			{
				if (_suicideBreach == null)
				{
					_suicideBreach = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "SuicideBreach", cr2w, this);
				}
				return _suicideBreach;
			}
			set
			{
				if (_suicideBreach == value)
				{
					return;
				}
				_suicideBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("RemoteBreach")] 
		public gamebbScriptID_Bool RemoteBreach
		{
			get
			{
				if (_remoteBreach == null)
				{
					_remoteBreach = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "RemoteBreach", cr2w, this);
				}
				return _remoteBreach;
			}
			set
			{
				if (_remoteBreach == value)
				{
					return;
				}
				_remoteBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("ItemBreach")] 
		public gamebbScriptID_Bool ItemBreach
		{
			get
			{
				if (_itemBreach == null)
				{
					_itemBreach = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "ItemBreach", cr2w, this);
				}
				return _itemBreach;
			}
			set
			{
				if (_itemBreach == value)
				{
					return;
				}
				_itemBreach = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Attempt")] 
		public gamebbScriptID_Int32 Attempt
		{
			get
			{
				if (_attempt == null)
				{
					_attempt = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "Attempt", cr2w, this);
				}
				return _attempt;
			}
			set
			{
				if (_attempt == value)
				{
					return;
				}
				_attempt = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("SelectedMinigameDef")] 
		public gamebbScriptID_Variant SelectedMinigameDef
		{
			get
			{
				if (_selectedMinigameDef == null)
				{
					_selectedMinigameDef = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "SelectedMinigameDef", cr2w, this);
				}
				return _selectedMinigameDef;
			}
			set
			{
				if (_selectedMinigameDef == value)
				{
					return;
				}
				_selectedMinigameDef = value;
				PropertySet(this);
			}
		}

		public NetworkBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
