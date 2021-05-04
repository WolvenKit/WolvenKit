using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_InputSwitch : animAnimNode_BaseSwitch
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

		public animAnimNode_InputSwitch(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
