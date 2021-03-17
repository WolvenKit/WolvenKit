using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communitySpawnPhase : ISerializable
	{
		private CName _phaseName;
		private CArray<CName> _appearances;
		private CArray<communityPhaseTimePeriod> _timePeriods;
		private CEnum<gameAlwaysSpawnedState> _alwaysSpawned;
		private CBool _prefetchAppearance;

		[Ordinal(0)] 
		[RED("phaseName")] 
		public CName PhaseName
		{
			get => GetProperty(ref _phaseName);
			set => SetProperty(ref _phaseName, value);
		}

		[Ordinal(1)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(2)] 
		[RED("timePeriods")] 
		public CArray<communityPhaseTimePeriod> TimePeriods
		{
			get => GetProperty(ref _timePeriods);
			set => SetProperty(ref _timePeriods, value);
		}

		[Ordinal(3)] 
		[RED("alwaysSpawned")] 
		public CEnum<gameAlwaysSpawnedState> AlwaysSpawned
		{
			get => GetProperty(ref _alwaysSpawned);
			set => SetProperty(ref _alwaysSpawned, value);
		}

		[Ordinal(4)] 
		[RED("prefetchAppearance")] 
		public CBool PrefetchAppearance
		{
			get => GetProperty(ref _prefetchAppearance);
			set => SetProperty(ref _prefetchAppearance, value);
		}

		public communitySpawnPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
