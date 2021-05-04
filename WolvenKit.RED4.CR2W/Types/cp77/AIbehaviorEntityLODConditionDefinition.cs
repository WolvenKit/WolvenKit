using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEntityLODConditionDefinition : AIbehaviorConditionDefinition
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

		public AIbehaviorEntityLODConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
