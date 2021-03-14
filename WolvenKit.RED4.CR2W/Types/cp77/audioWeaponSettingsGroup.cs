using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponSettingsGroup : audioAudioMetadata
	{
		private CName _playerSettings;
		private CName _playerSilenced;
		private CName _npcSettings;
		private CName _npcSilenced;

		[Ordinal(1)] 
		[RED("playerSettings")] 
		public CName PlayerSettings
		{
			get
			{
				if (_playerSettings == null)
				{
					_playerSettings = (CName) CR2WTypeManager.Create("CName", "playerSettings", cr2w, this);
				}
				return _playerSettings;
			}
			set
			{
				if (_playerSettings == value)
				{
					return;
				}
				_playerSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("playerSilenced")] 
		public CName PlayerSilenced
		{
			get
			{
				if (_playerSilenced == null)
				{
					_playerSilenced = (CName) CR2WTypeManager.Create("CName", "playerSilenced", cr2w, this);
				}
				return _playerSilenced;
			}
			set
			{
				if (_playerSilenced == value)
				{
					return;
				}
				_playerSilenced = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("npcSettings")] 
		public CName NpcSettings
		{
			get
			{
				if (_npcSettings == null)
				{
					_npcSettings = (CName) CR2WTypeManager.Create("CName", "npcSettings", cr2w, this);
				}
				return _npcSettings;
			}
			set
			{
				if (_npcSettings == value)
				{
					return;
				}
				_npcSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("npcSilenced")] 
		public CName NpcSilenced
		{
			get
			{
				if (_npcSilenced == null)
				{
					_npcSilenced = (CName) CR2WTypeManager.Create("CName", "npcSilenced", cr2w, this);
				}
				return _npcSilenced;
			}
			set
			{
				if (_npcSilenced == value)
				{
					return;
				}
				_npcSilenced = value;
				PropertySet(this);
			}
		}

		public audioWeaponSettingsGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
