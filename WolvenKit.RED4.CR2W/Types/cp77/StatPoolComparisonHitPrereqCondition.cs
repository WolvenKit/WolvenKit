using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolComparisonHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _comparisonSource;
		private CName _comparisonTarget;
		private CEnum<EComparisonType> _comparisonType;
		private CEnum<gamedataStatPoolType> _statPoolToCompare;

		[Ordinal(1)] 
		[RED("comparisonSource")] 
		public CName ComparisonSource
		{
			get => GetProperty(ref _comparisonSource);
			set => SetProperty(ref _comparisonSource, value);
		}

		[Ordinal(2)] 
		[RED("comparisonTarget")] 
		public CName ComparisonTarget
		{
			get => GetProperty(ref _comparisonTarget);
			set => SetProperty(ref _comparisonTarget, value);
		}

		[Ordinal(3)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(4)] 
		[RED("statPoolToCompare")] 
		public CEnum<gamedataStatPoolType> StatPoolToCompare
		{
			get => GetProperty(ref _statPoolToCompare);
			set => SetProperty(ref _statPoolToCompare, value);
		}

		public StatPoolComparisonHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
