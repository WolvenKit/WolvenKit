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
			get
			{
				if (_selectIntNode == null)
				{
					_selectIntNode = (animIntLink) CR2WTypeManager.Create("animIntLink", "selectIntNode", cr2w, this);
				}
				return _selectIntNode;
			}
			set
			{
				if (_selectIntNode == value)
				{
					return;
				}
				_selectIntNode = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("selectFloatNode")] 
		public animFloatLink SelectFloatNode
		{
			get
			{
				if (_selectFloatNode == null)
				{
					_selectFloatNode = (animFloatLink) CR2WTypeManager.Create("animFloatLink", "selectFloatNode", cr2w, this);
				}
				return _selectFloatNode;
			}
			set
			{
				if (_selectFloatNode == value)
				{
					return;
				}
				_selectFloatNode = value;
				PropertySet(this);
			}
		}

		public animAnimNode_InputSwitch(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
