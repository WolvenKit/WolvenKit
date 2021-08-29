using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animQuaternionLink : RedBaseClass
	{
		private CWeakHandle<animAnimNode_QuaternionValue> _node;

		[Ordinal(0)] 
		[RED("node")] 
		public CWeakHandle<animAnimNode_QuaternionValue> Node
		{
			get => GetProperty(ref _node);
			set => SetProperty(ref _node, value);
		}
	}
}
