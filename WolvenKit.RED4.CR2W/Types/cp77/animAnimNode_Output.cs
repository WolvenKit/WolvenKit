using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_Output : animAnimNode_Base
	{
		private animPoseLink _node;

		[Ordinal(11)] 
		[RED("node")] 
		public animPoseLink Node
		{
			get
			{
				if (_node == null)
				{
					_node = (animPoseLink) CR2WTypeManager.Create("animPoseLink", "node", cr2w, this);
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

		public animAnimNode_Output(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
