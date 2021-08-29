using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animVectorLink : RedBaseClass
	{
		private CWeakHandle<animAnimNode_VectorValue> _node;

		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_VectorValue> Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}
	}
}
