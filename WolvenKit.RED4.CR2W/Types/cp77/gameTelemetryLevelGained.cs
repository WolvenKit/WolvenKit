using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryLevelGained : CVariable
	{
		private wCHandle<gameObject> _playerPuppet;
		private CEnum<gamedataProficiencyType> _proficiencyType;
		private CInt32 _proficiencyValue;
		private CInt32 _perkPointsAwarded;
		private CInt32 _attributePointsAwarded;
		private CBool _isDebugEvt;

		[Ordinal(0)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(1)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get => GetProperty(ref _proficiencyType);
			set => SetProperty(ref _proficiencyType, value);
		}

		[Ordinal(2)] 
		[RED("proficiencyValue")] 
		public CInt32 ProficiencyValue
		{
			get => GetProperty(ref _proficiencyValue);
			set => SetProperty(ref _proficiencyValue, value);
		}

		[Ordinal(3)] 
		[RED("perkPointsAwarded")] 
		public CInt32 PerkPointsAwarded
		{
			get => GetProperty(ref _perkPointsAwarded);
			set => SetProperty(ref _perkPointsAwarded, value);
		}

		[Ordinal(4)] 
		[RED("attributePointsAwarded")] 
		public CInt32 AttributePointsAwarded
		{
			get => GetProperty(ref _attributePointsAwarded);
			set => SetProperty(ref _attributePointsAwarded, value);
		}

		[Ordinal(5)] 
		[RED("isDebugEvt")] 
		public CBool IsDebugEvt
		{
			get => GetProperty(ref _isDebugEvt);
			set => SetProperty(ref _isDebugEvt, value);
		}

		public gameTelemetryLevelGained(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
