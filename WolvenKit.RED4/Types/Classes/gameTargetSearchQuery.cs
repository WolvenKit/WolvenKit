using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTargetSearchQuery : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("testedSet")] 
		public CEnum<gameTargetingSet> TestedSet
		{
			get => GetPropertyValue<CEnum<gameTargetingSet>>();
			set => SetPropertyValue<CEnum<gameTargetingSet>>(value);
		}

		[Ordinal(1)] 
		[RED("searchFilter")] 
		public gameTargetSearchFilter SearchFilter
		{
			get => GetPropertyValue<gameTargetSearchFilter>();
			set => SetPropertyValue<gameTargetSearchFilter>(value);
		}

		[Ordinal(2)] 
		[RED("includeSecondaryTargets")] 
		public CBool IncludeSecondaryTargets
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("ignoreInstigator")] 
		public CBool IgnoreInstigator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("filterObjectByDistance")] 
		public CBool FilterObjectByDistance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("queryTarget")] 
		public entEntityID QueryTarget
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public gameTargetSearchQuery()
		{
			SearchFilter = new gameTargetSearchFilter();
			IncludeSecondaryTargets = true;
			QueryTarget = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
