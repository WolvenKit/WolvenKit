using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyDisplayData : IDisplayData
	{
		private TweakDBID _attributeId;
		private CEnum<gamedataProficiencyType> _proficiency;
		private CInt32 _index;
		private CArray<CHandle<AreaDisplayData>> _areas;
		private CArray<CHandle<LevelRewardDisplayData>> _passiveBonusesData;
		private CHandle<TraitDisplayData> _traitData;
		private CString _localizedName;
		private CString _localizedDescription;
		private CInt32 _level;
		private CInt32 _maxLevel;
		private CInt32 _expPoints;
		private CInt32 _maxExpPoints;
		private CInt32 _unlockedLevel;

		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get => GetProperty(ref _attributeId);
			set => SetProperty(ref _attributeId, value);
		}

		[Ordinal(1)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get => GetProperty(ref _proficiency);
			set => SetProperty(ref _proficiency, value);
		}

		[Ordinal(2)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(3)] 
		[RED("areas")] 
		public CArray<CHandle<AreaDisplayData>> Areas
		{
			get => GetProperty(ref _areas);
			set => SetProperty(ref _areas, value);
		}

		[Ordinal(4)] 
		[RED("passiveBonusesData")] 
		public CArray<CHandle<LevelRewardDisplayData>> PassiveBonusesData
		{
			get => GetProperty(ref _passiveBonusesData);
			set => SetProperty(ref _passiveBonusesData, value);
		}

		[Ordinal(5)] 
		[RED("traitData")] 
		public CHandle<TraitDisplayData> TraitData
		{
			get => GetProperty(ref _traitData);
			set => SetProperty(ref _traitData, value);
		}

		[Ordinal(6)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(7)] 
		[RED("localizedDescription")] 
		public CString LocalizedDescription
		{
			get => GetProperty(ref _localizedDescription);
			set => SetProperty(ref _localizedDescription, value);
		}

		[Ordinal(8)] 
		[RED("level")] 
		public CInt32 Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(9)] 
		[RED("maxLevel")] 
		public CInt32 MaxLevel
		{
			get => GetProperty(ref _maxLevel);
			set => SetProperty(ref _maxLevel, value);
		}

		[Ordinal(10)] 
		[RED("expPoints")] 
		public CInt32 ExpPoints
		{
			get => GetProperty(ref _expPoints);
			set => SetProperty(ref _expPoints, value);
		}

		[Ordinal(11)] 
		[RED("maxExpPoints")] 
		public CInt32 MaxExpPoints
		{
			get => GetProperty(ref _maxExpPoints);
			set => SetProperty(ref _maxExpPoints, value);
		}

		[Ordinal(12)] 
		[RED("unlockedLevel")] 
		public CInt32 UnlockedLevel
		{
			get => GetProperty(ref _unlockedLevel);
			set => SetProperty(ref _unlockedLevel, value);
		}

		public ProficiencyDisplayData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
