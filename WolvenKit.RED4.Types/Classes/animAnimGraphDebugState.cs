using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimGraphDebugState : ISerializable
	{
		private CArray<animAnimNodeDebugState> _nodes;

		[Ordinal(0)] 
		[RED("nodes")] 
		public CArray<animAnimNodeDebugState> Nodes
		{
			get => GetProperty(ref _nodes);
			set => SetProperty(ref _nodes, value);
		}
	}
}
