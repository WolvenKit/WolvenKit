using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICTreeNodeActionTeleportToNodeDefinition : AICTreeNodeActionDefinition
	{
		private LibTreeDefNodeRef _nodeRef;
		private LibTreeDefVector _offset;
		private CBool _doNavTest;

		[Ordinal(1)] 
		[RED("nodeRef")] 
		public LibTreeDefNodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (LibTreeDefNodeRef) CR2WTypeManager.Create("LibTreeDefNodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public LibTreeDefVector Offset
		{
			get
			{
				if (_offset == null)
				{
					_offset = (LibTreeDefVector) CR2WTypeManager.Create("LibTreeDefVector", "offset", cr2w, this);
				}
				return _offset;
			}
			set
			{
				if (_offset == value)
				{
					return;
				}
				_offset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("doNavTest")] 
		public CBool DoNavTest
		{
			get
			{
				if (_doNavTest == null)
				{
					_doNavTest = (CBool) CR2WTypeManager.Create("Bool", "doNavTest", cr2w, this);
				}
				return _doNavTest;
			}
			set
			{
				if (_doNavTest == value)
				{
					return;
				}
				_doNavTest = value;
				PropertySet(this);
			}
		}

		public AICTreeNodeActionTeleportToNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
