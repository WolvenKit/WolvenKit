using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataFileNode : gamedataDataNode
	{
		private CString _packageName;
		private CStatic<wCHandle<gamedataPackageNode>> _packageDependencies;
		private wCHandle<gamedataPackageNode> _package;
		private CArray<CHandle<gamedataVariableNode>> _variables;
		private CArray<CHandle<gamedataGroupNode>> _groups;

		[Ordinal(3)] 
		[RED("packageName")] 
		public CString PackageName
		{
			get
			{
				if (_packageName == null)
				{
					_packageName = (CString) CR2WTypeManager.Create("String", "packageName", cr2w, this);
				}
				return _packageName;
			}
			set
			{
				if (_packageName == value)
				{
					return;
				}
				_packageName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("packageDependencies", 16)] 
		public CStatic<wCHandle<gamedataPackageNode>> PackageDependencies
		{
			get
			{
				if (_packageDependencies == null)
				{
					_packageDependencies = (CStatic<wCHandle<gamedataPackageNode>>) CR2WTypeManager.Create("static:16,whandle:gamedataPackageNode", "packageDependencies", cr2w, this);
				}
				return _packageDependencies;
			}
			set
			{
				if (_packageDependencies == value)
				{
					return;
				}
				_packageDependencies = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("package")] 
		public wCHandle<gamedataPackageNode> Package
		{
			get
			{
				if (_package == null)
				{
					_package = (wCHandle<gamedataPackageNode>) CR2WTypeManager.Create("whandle:gamedataPackageNode", "package", cr2w, this);
				}
				return _package;
			}
			set
			{
				if (_package == value)
				{
					return;
				}
				_package = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("variables")] 
		public CArray<CHandle<gamedataVariableNode>> Variables
		{
			get
			{
				if (_variables == null)
				{
					_variables = (CArray<CHandle<gamedataVariableNode>>) CR2WTypeManager.Create("array:handle:gamedataVariableNode", "variables", cr2w, this);
				}
				return _variables;
			}
			set
			{
				if (_variables == value)
				{
					return;
				}
				_variables = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("groups")] 
		public CArray<CHandle<gamedataGroupNode>> Groups
		{
			get
			{
				if (_groups == null)
				{
					_groups = (CArray<CHandle<gamedataGroupNode>>) CR2WTypeManager.Create("array:handle:gamedataGroupNode", "groups", cr2w, this);
				}
				return _groups;
			}
			set
			{
				if (_groups == value)
				{
					return;
				}
				_groups = value;
				PropertySet(this);
			}
		}

		public gamedataFileNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
