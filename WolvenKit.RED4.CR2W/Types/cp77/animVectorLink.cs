using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animVectorLink : CVariable
	{
		private wCHandle<animAnimNode_VectorValue> _node;

		[Ordinal(0)] 
		[RED("node")] 
		public wCHandle<animAnimNode_VectorValue> Node
		{
			get
			{
				if (_node == null)
				{
					_node = (wCHandle<animAnimNode_VectorValue>) CR2WTypeManager.Create("whandle:animAnimNode_VectorValue", "node", cr2w, this);
				}
				return _node;
			}
			set
			{
				if (_node == value)
				{
					return;
				}
				_node = value;
				PropertySet(this);
			}
		}

		public animVectorLink(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
