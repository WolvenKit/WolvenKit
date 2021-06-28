using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animGraphSlotCondition : CVariable
	{
		private CHandle<animIStaticCondition> _condition;
		private rRef<animAnimGraph> _graph;

		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<animIStaticCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(1)] 
		[RED("graph")] 
		public rRef<animAnimGraph> Graph
		{
			get => GetProperty(ref _graph);
			set => SetProperty(ref _graph, value);
		}

		public animGraphSlotCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
