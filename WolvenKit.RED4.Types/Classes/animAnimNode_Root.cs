using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_Root : animAnimNode_Container
	{
		private animPoseLink _outputNode;

		[Ordinal(12)] 
		[RED("outputNode")] 
		public animPoseLink OutputNode
		{
			get => GetProperty(ref _outputNode);
			set => SetProperty(ref _outputNode, value);
		}
	}
}
