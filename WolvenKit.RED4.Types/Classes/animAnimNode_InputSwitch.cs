using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_InputSwitch : animAnimNode_BaseSwitch
	{
		private animIntLink _selectIntNode;
		private animFloatLink _selectFloatNode;

		[Ordinal(16)] 
		[RED("selectIntNode")] 
		public animIntLink SelectIntNode
		{
			get => GetProperty(ref _selectIntNode);
			set => SetProperty(ref _selectIntNode, value);
		}

		[Ordinal(17)] 
		[RED("selectFloatNode")] 
		public animFloatLink SelectFloatNode
		{
			get => GetProperty(ref _selectFloatNode);
			set => SetProperty(ref _selectFloatNode, value);
		}
	}
}
