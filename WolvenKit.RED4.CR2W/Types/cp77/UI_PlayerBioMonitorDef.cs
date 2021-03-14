using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_PlayerBioMonitorDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _playerStatsInfo;
		private gamebbScriptID_Variant _buffsList;
		private gamebbScriptID_Variant _debuffsList;
		private gamebbScriptID_Variant _cooldowns;
		private gamebbScriptID_Float _adrenalineBar;
		private gamebbScriptID_Int32 _currentNetrunnerCharges;
		private gamebbScriptID_Int32 _networkChargesCapacity;
		private gamebbScriptID_CName _networkName;
		private gamebbScriptID_Float _memoryPercent;

		[Ordinal(0)] 
		[RED("PlayerStatsInfo")] 
		public gamebbScriptID_Variant PlayerStatsInfo
		{
			get
			{
				if (_playerStatsInfo == null)
				{
					_playerStatsInfo = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "PlayerStatsInfo", cr2w, this);
				}
				return _playerStatsInfo;
			}
			set
			{
				if (_playerStatsInfo == value)
				{
					return;
				}
				_playerStatsInfo = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("BuffsList")] 
		public gamebbScriptID_Variant BuffsList
		{
			get
			{
				if (_buffsList == null)
				{
					_buffsList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "BuffsList", cr2w, this);
				}
				return _buffsList;
			}
			set
			{
				if (_buffsList == value)
				{
					return;
				}
				_buffsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("DebuffsList")] 
		public gamebbScriptID_Variant DebuffsList
		{
			get
			{
				if (_debuffsList == null)
				{
					_debuffsList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "DebuffsList", cr2w, this);
				}
				return _debuffsList;
			}
			set
			{
				if (_debuffsList == value)
				{
					return;
				}
				_debuffsList = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Cooldowns")] 
		public gamebbScriptID_Variant Cooldowns
		{
			get
			{
				if (_cooldowns == null)
				{
					_cooldowns = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "Cooldowns", cr2w, this);
				}
				return _cooldowns;
			}
			set
			{
				if (_cooldowns == value)
				{
					return;
				}
				_cooldowns = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("AdrenalineBar")] 
		public gamebbScriptID_Float AdrenalineBar
		{
			get
			{
				if (_adrenalineBar == null)
				{
					_adrenalineBar = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "AdrenalineBar", cr2w, this);
				}
				return _adrenalineBar;
			}
			set
			{
				if (_adrenalineBar == value)
				{
					return;
				}
				_adrenalineBar = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("CurrentNetrunnerCharges")] 
		public gamebbScriptID_Int32 CurrentNetrunnerCharges
		{
			get
			{
				if (_currentNetrunnerCharges == null)
				{
					_currentNetrunnerCharges = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "CurrentNetrunnerCharges", cr2w, this);
				}
				return _currentNetrunnerCharges;
			}
			set
			{
				if (_currentNetrunnerCharges == value)
				{
					return;
				}
				_currentNetrunnerCharges = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("NetworkChargesCapacity")] 
		public gamebbScriptID_Int32 NetworkChargesCapacity
		{
			get
			{
				if (_networkChargesCapacity == null)
				{
					_networkChargesCapacity = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "NetworkChargesCapacity", cr2w, this);
				}
				return _networkChargesCapacity;
			}
			set
			{
				if (_networkChargesCapacity == value)
				{
					return;
				}
				_networkChargesCapacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("NetworkName")] 
		public gamebbScriptID_CName NetworkName
		{
			get
			{
				if (_networkName == null)
				{
					_networkName = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "NetworkName", cr2w, this);
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

		[Ordinal(8)] 
		[RED("MemoryPercent")] 
		public gamebbScriptID_Float MemoryPercent
		{
			get
			{
				if (_memoryPercent == null)
				{
					_memoryPercent = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "MemoryPercent", cr2w, this);
				}
				return _memoryPercent;
			}
			set
			{
				if (_memoryPercent == value)
				{
					return;
				}
				_memoryPercent = value;
				PropertySet(this);
			}
		}

		public UI_PlayerBioMonitorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
