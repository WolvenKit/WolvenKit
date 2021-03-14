using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponVariations : audioAudioMetadata
	{
		private CName _playerWeaponConfigurationName;
		private CName _nPCWeaponConfigurationName;

		[Ordinal(1)] 
		[RED("playerWeaponConfigurationName")] 
		public CName PlayerWeaponConfigurationName
		{
			get
			{
				if (_playerWeaponConfigurationName == null)
				{
					_playerWeaponConfigurationName = (CName) CR2WTypeManager.Create("CName", "playerWeaponConfigurationName", cr2w, this);
				}
				return _playerWeaponConfigurationName;
			}
			set
			{
				if (_playerWeaponConfigurationName == value)
				{
					return;
				}
				_playerWeaponConfigurationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("NPCWeaponConfigurationName")] 
		public CName NPCWeaponConfigurationName
		{
			get
			{
				if (_nPCWeaponConfigurationName == null)
				{
					_nPCWeaponConfigurationName = (CName) CR2WTypeManager.Create("CName", "NPCWeaponConfigurationName", cr2w, this);
				}
				return _nPCWeaponConfigurationName;
			}
			set
			{
				if (_nPCWeaponConfigurationName == value)
				{
					return;
				}
				_nPCWeaponConfigurationName = value;
				PropertySet(this);
			}
		}

		public audioMeleeWeaponVariations(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
