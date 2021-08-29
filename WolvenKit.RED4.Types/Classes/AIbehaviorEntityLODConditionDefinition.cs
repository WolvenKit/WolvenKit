using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorEntityLODConditionDefinition : AIbehaviorConditionDefinition
	{
		private CArray<CEnum<AIbehaviorEntityLODConditions>> _any;
		private CArray<CEnum<AIbehaviorEntityLODConditions>> _all;
		private CArray<CEnum<AIbehaviorEntityLODConditions>> _none;

		[Ordinal(1)] 
		[RED("any")] 
		public CArray<CEnum<AIbehaviorEntityLODConditions>> Any
		{
			get => GetProperty(ref _any);
			set => SetProperty(ref _any, value);
		}

		[Ordinal(2)] 
		[RED("all")] 
		public CArray<CEnum<AIbehaviorEntityLODConditions>> All
		{
			get => GetProperty(ref _all);
			set => SetProperty(ref _all, value);
		}

		[Ordinal(3)] 
		[RED("none")] 
		public CArray<CEnum<AIbehaviorEntityLODConditions>> None
		{
			get => GetProperty(ref _none);
			set => SetProperty(ref _none, value);
		}
	}
}
