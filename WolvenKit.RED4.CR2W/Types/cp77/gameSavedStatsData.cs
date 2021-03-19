using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSavedStatsData : CVariable
	{
		private CArray<CHandle<gameStatModifierData>> _statModifiers;
		private CArray<CEnum<gamedataStatType>> _inactiveStats;
		private TweakDBID _recordID;
		private CUInt32 _seed;

		[Ordinal(0)] 
		[RED("statModifiers")] 
		public CArray<CHandle<gameStatModifierData>> StatModifiers
		{
			get => GetProperty(ref _statModifiers);
			set => SetProperty(ref _statModifiers, value);
		}

		[Ordinal(1)] 
		[RED("inactiveStats")] 
		public CArray<CEnum<gamedataStatType>> InactiveStats
		{
			get => GetProperty(ref _inactiveStats);
			set => SetProperty(ref _inactiveStats, value);
		}

		[Ordinal(2)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(3)] 
		[RED("seed")] 
		public CUInt32 Seed
		{
			get => GetProperty(ref _seed);
			set => SetProperty(ref _seed, value);
		}

		public gameSavedStatsData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
