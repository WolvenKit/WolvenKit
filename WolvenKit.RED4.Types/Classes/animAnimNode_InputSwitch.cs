using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_InputSwitch : animAnimNode_BaseSwitch
	{
		[Ordinal(16)] 
		[RED("selectIntNode")] 
		public animIntLink SelectIntNode
		{
			get => GetPropertyValue<animIntLink>();
			set => SetPropertyValue<animIntLink>(value);
		}

		[Ordinal(17)] 
		[RED("selectFloatNode")] 
		public animFloatLink SelectFloatNode
		{
			get => GetPropertyValue<animFloatLink>();
			set => SetPropertyValue<animFloatLink>(value);
		}

		public animAnimNode_InputSwitch()
		{
			SelectIntNode = new();
			SelectFloatNode = new();
		}
	}
}
