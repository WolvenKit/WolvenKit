using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animGraphSlotCondition : RedBaseClass
	{
		private CHandle<animIStaticCondition> _condition;
		private CResourceReference<animAnimGraph> _graph;

		[Ordinal(0)] 
		[RED("condition")] 
		public CHandle<animIStaticCondition> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(1)] 
		[RED("graph")] 
		public CResourceReference<animAnimGraph> Graph
		{
			get => GetProperty(ref _graph);
			set => SetProperty(ref _graph, value);
		}
	}
}
