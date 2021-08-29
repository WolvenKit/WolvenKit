using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Output : animAnimNode_Base
	{
		private animPoseLink _node;

		[Ordinal(11)] 
		[RED("node")] 
		public animPoseLink Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}
	}
}
