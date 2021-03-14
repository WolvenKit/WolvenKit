using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnFindEntityInNodeParams : CVariable
	{
		private NodeRef _nodeRef;
		private CBool _forceMaxVisibility;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
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

		[Ordinal(1)] 
		[RED("forceMaxVisibility")] 
		public CBool ForceMaxVisibility
		{
			get
			{
				if (_forceMaxVisibility == null)
				{
					_forceMaxVisibility = (CBool) CR2WTypeManager.Create("Bool", "forceMaxVisibility", cr2w, this);
				}
				return _forceMaxVisibility;
			}
			set
			{
				if (_forceMaxVisibility == value)
				{
					return;
				}
				_forceMaxVisibility = value;
				PropertySet(this);
			}
		}

		public scnFindEntityInNodeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
