using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_GraphSlot_Test : animAnimNode_GraphSlot
	{
		private CResourceReference<animAnimGraph> _graph_TEST;

		[Ordinal(14)] 
		[RED("graph_TEST")] 
		public CResourceReference<animAnimGraph> Graph_TEST
		{
			get => GetProperty(ref _graph_TEST);
			set => SetProperty(ref _graph_TEST, value);
		}
	}
}
