using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetProficiencyLevel : gamePlayerScriptableSystemRequest
	{
		private CInt32 _newLevel;
		private CEnum<gamedataProficiencyType> _proficiencyType;
		private CEnum<telemetryLevelGainReason> _telemetryLevelGainReason;

		[Ordinal(1)] 
		[RED("newLevel")] 
		public CInt32 NewLevel
		{
			get => GetProperty(ref _newLevel);
			set => SetProperty(ref _newLevel, value);
		}

		[Ordinal(2)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get => GetProperty(ref _proficiencyType);
			set => SetProperty(ref _proficiencyType, value);
		}

		[Ordinal(3)] 
		[RED("telemetryLevelGainReason")] 
		public CEnum<telemetryLevelGainReason> TelemetryLevelGainReason
		{
			get => GetProperty(ref _telemetryLevelGainReason);
			set => SetProperty(ref _telemetryLevelGainReason, value);
		}
	}
}
