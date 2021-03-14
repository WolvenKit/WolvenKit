using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questManageCollision_NodeTypeParams : CVariable
	{
		private NodeRef _objectRef;
		private CBool _enableCollision;
		private CBool _enableQueries;
		private CArray<CName> _components;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get
			{
				if (_objectRef == null)
				{
					_objectRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "objectRef", cr2w, this);
				}
				return _objectRef;
			}
			set
			{
				if (_objectRef == value)
				{
					return;
				}
				_objectRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("enableCollision")] 
		public CBool EnableCollision
		{
			get
			{
				if (_enableCollision == null)
				{
					_enableCollision = (CBool) CR2WTypeManager.Create("Bool", "enableCollision", cr2w, this);
				}
				return _enableCollision;
			}
			set
			{
				if (_enableCollision == value)
				{
					return;
				}
				_enableCollision = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("enableQueries")] 
		public CBool EnableQueries
		{
			get
			{
				if (_enableQueries == null)
				{
					_enableQueries = (CBool) CR2WTypeManager.Create("Bool", "enableQueries", cr2w, this);
				}
				return _enableQueries;
			}
			set
			{
				if (_enableQueries == value)
				{
					return;
				}
				_enableQueries = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("components")] 
		public CArray<CName> Components
		{
			get
			{
				if (_components == null)
				{
					_components = (CArray<CName>) CR2WTypeManager.Create("array:CName", "components", cr2w, this);
				}
				return _components;
			}
			set
			{
				if (_components == value)
				{
					return;
				}
				_components = value;
				PropertySet(this);
			}
		}

		public questManageCollision_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
