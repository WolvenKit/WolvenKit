using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForceModule_NodeTypeParams : CVariable
	{
		private NodeRef _objectRef;
		private CString _module;
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
		[RED("module")] 
		public CString Module
		{
			get
			{
				if (_module == null)
				{
					_module = (CString) CR2WTypeManager.Create("String", "module", cr2w, this);
				}
				return _module;
			}
			set
			{
				if (_module == value)
				{
					return;
				}
				_module = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		public questForceModule_NodeTypeParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
