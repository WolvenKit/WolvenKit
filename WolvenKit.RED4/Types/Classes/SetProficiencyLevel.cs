using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SetProficiencyLevel : gamePlayerScriptableSystemRequest
	{
		[Ordinal(1)] 
		[RED("newLevel")] 
		public CInt32 NewLevel
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get => GetPropertyValue<CEnum<gamedataProficiencyType>>();
			set => SetPropertyValue<CEnum<gamedataProficiencyType>>(value);
		}

		[Ordinal(3)] 
		[RED("telemetryLevelGainReason")] 
		public CEnum<telemetryLevelGainReason> TelemetryLevelGainReason
		{
			get => GetPropertyValue<CEnum<telemetryLevelGainReason>>();
			set => SetPropertyValue<CEnum<telemetryLevelGainReason>>(value);
		}

		public SetProficiencyLevel()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
