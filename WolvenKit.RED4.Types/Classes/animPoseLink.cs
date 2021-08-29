using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseLink : RedBaseClass
	{
		private CWeakHandle<animAnimNode_Base> _node;

		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_Base> Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}
	}
}
