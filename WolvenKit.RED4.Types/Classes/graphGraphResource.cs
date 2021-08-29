using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class graphGraphResource : CResource
	{
		private CHandle<graphGraphDefinition> _graph;

		[Ordinal(1)] 
		[RED("graph")] 
		public CHandle<graphGraphDefinition> Graph
		{
			get => GetProperty(ref _graph);
			set => SetProperty(ref _graph, value);
		}
	}
}
