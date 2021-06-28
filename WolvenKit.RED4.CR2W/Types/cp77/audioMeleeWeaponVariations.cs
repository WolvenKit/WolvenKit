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
			get => GetProperty(ref _playerWeaponConfigurationName);
			set => SetProperty(ref _playerWeaponConfigurationName, value);
		}

		[Ordinal(2)] 
		[RED("NPCWeaponConfigurationName")] 
		public CName NPCWeaponConfigurationName
		{
			get => GetProperty(ref _nPCWeaponConfigurationName);
			set => SetProperty(ref _nPCWeaponConfigurationName, value);
		}

		public audioMeleeWeaponVariations(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
