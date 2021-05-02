using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorRandomConditionDefinition : AIbehaviorConditionDefinition
	{
		private CFloat _chance;

		[Ordinal(1)] 
		[RED("chance")] 
		public CFloat Chance
		{
			get => GetProperty(ref _chance);
			set => SetProperty(ref _chance, value);
		}

		public AIbehaviorRandomConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
