using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetProficiencyLevel : gamePlayerScriptableSystemRequest
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

		public SetProficiencyLevel(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
