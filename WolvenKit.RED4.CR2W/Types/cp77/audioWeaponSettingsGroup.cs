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
			get => GetProperty(ref _playerSettings);
			set => SetProperty(ref _playerSettings, value);
		}

		[Ordinal(2)] 
		[RED("playerSilenced")] 
		public CName PlayerSilenced
		{
			get => GetProperty(ref _playerSilenced);
			set => SetProperty(ref _playerSilenced, value);
		}

		[Ordinal(3)] 
		[RED("npcSettings")] 
		public CName NpcSettings
		{
			get => GetProperty(ref _npcSettings);
			set => SetProperty(ref _npcSettings, value);
		}

		[Ordinal(4)] 
		[RED("npcSilenced")] 
		public CName NpcSilenced
		{
			get => GetProperty(ref _npcSilenced);
			set => SetProperty(ref _npcSilenced, value);
		}

		public audioWeaponSettingsGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
