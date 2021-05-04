using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompanionConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _spline;
		private CHandle<AIArgumentMapping> _companion;

		[Ordinal(1)] 
		[RED("spline")] 
		public CHandle<AIArgumentMapping> Spline
		{
			get => GetProperty(ref _spline);
			set => SetProperty(ref _spline, value);
		}

		[Ordinal(2)] 
		[RED("companion")] 
		public CHandle<AIArgumentMapping> Companion
		{
			get => GetProperty(ref _companion);
			set => SetProperty(ref _companion, value);
		}

		public AIbehaviorCompanionConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
