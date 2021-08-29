using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class graphGraphDefinition : graphIGraphObjectDefinition
	{
		private CArray<CHandle<graphGraphNodeDefinition>> _nodes;

		[Ordinal(0)] 
		[RED("nodes")] 
		public CArray<CHandle<graphGraphNodeDefinition>> Nodes
		{
			get => GetProperty(ref _nodes);
			set => SetProperty(ref _nodes, value);
		}
	}
}
