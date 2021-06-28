using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTargetSearchQuery : CVariable
	{
		private CEnum<gameTargetingSet> _testedSet;
		private gameTargetSearchFilter _searchFilter;
		private CBool _includeSecondaryTargets;
		private CBool _ignoreInstigator;
		private CFloat _maxDistance;
		private entEntityID _queryTarget;

		[Ordinal(0)] 
		[RED("testedSet")] 
		public CEnum<gameTargetingSet> TestedSet
		{
			get => GetProperty(ref _testedSet);
			set => SetProperty(ref _testedSet, value);
		}

		[Ordinal(1)] 
		[RED("searchFilter")] 
		public gameTargetSearchFilter SearchFilter
		{
			get => GetProperty(ref _searchFilter);
			set => SetProperty(ref _searchFilter, value);
		}

		[Ordinal(2)] 
		[RED("includeSecondaryTargets")] 
		public CBool IncludeSecondaryTargets
		{
			get => GetProperty(ref _includeSecondaryTargets);
			set => SetProperty(ref _includeSecondaryTargets, value);
		}

		[Ordinal(3)] 
		[RED("ignoreInstigator")] 
		public CBool IgnoreInstigator
		{
			get => GetProperty(ref _ignoreInstigator);
			set => SetProperty(ref _ignoreInstigator, value);
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(5)] 
		[RED("queryTarget")] 
		public entEntityID QueryTarget
		{
			get => GetProperty(ref _queryTarget);
			set => SetProperty(ref _queryTarget, value);
		}

		public gameTargetSearchQuery(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
