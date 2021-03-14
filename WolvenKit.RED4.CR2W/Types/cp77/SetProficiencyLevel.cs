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
			get
			{
				if (_newLevel == null)
				{
					_newLevel = (CInt32) CR2WTypeManager.Create("Int32", "newLevel", cr2w, this);
				}
				return _newLevel;
			}
			set
			{
				if (_newLevel == value)
				{
					return;
				}
				_newLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get
			{
				if (_proficiencyType == null)
				{
					_proficiencyType = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "proficiencyType", cr2w, this);
				}
				return _proficiencyType;
			}
			set
			{
				if (_proficiencyType == value)
				{
					return;
				}
				_proficiencyType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("telemetryLevelGainReason")] 
		public CEnum<telemetryLevelGainReason> TelemetryLevelGainReason
		{
			get
			{
				if (_telemetryLevelGainReason == null)
				{
					_telemetryLevelGainReason = (CEnum<telemetryLevelGainReason>) CR2WTypeManager.Create("telemetryLevelGainReason", "telemetryLevelGainReason", cr2w, this);
				}
				return _telemetryLevelGainReason;
			}
			set
			{
				if (_telemetryLevelGainReason == value)
				{
					return;
				}
				_telemetryLevelGainReason = value;
				PropertySet(this);
			}
		}

		public SetProficiencyLevel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
