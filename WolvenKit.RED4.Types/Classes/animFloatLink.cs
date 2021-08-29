using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animFloatLink : RedBaseClass
	{
		private CWeakHandle<animAnimNode_FloatValue> _node;

		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_FloatValue> Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}
	}
}
