using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animTransformLink : RedBaseClass
	{
		private CWeakHandle<animAnimNode_TransformValue> _node;

		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_TransformValue> Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}
	}
}
