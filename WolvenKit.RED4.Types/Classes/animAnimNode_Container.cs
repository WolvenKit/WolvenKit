using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Container : animAnimNode_Base
	{
		private CArray<CHandle<animAnimNode_Base>> _nodes;

		[Ordinal(11)] 
		[RED("nodes")] 
		public CArray<CHandle<animAnimNode_Base>> Nodes
		{
			get => GetProperty(ref _nodes);
			set => SetProperty(ref _nodes, value);
		}
	}
}
