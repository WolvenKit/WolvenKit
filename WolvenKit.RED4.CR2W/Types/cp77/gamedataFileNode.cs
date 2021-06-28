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
			get => GetProperty(ref _packageName);
			set => SetProperty(ref _packageName, value);
		}

		[Ordinal(4)] 
		[RED("packageDependencies", 16)] 
		public CStatic<wCHandle<gamedataPackageNode>> PackageDependencies
		{
			get => GetProperty(ref _packageDependencies);
			set => SetProperty(ref _packageDependencies, value);
		}

		[Ordinal(5)] 
		[RED("package")] 
		public wCHandle<gamedataPackageNode> Package
		{
			get => GetProperty(ref _package);
			set => SetProperty(ref _package, value);
		}

		[Ordinal(6)] 
		[RED("variables")] 
		public CArray<CHandle<gamedataVariableNode>> Variables
		{
			get => GetProperty(ref _variables);
			set => SetProperty(ref _variables, value);
		}

		[Ordinal(7)] 
		[RED("groups")] 
		public CArray<CHandle<gamedataGroupNode>> Groups
		{
			get => GetProperty(ref _groups);
			set => SetProperty(ref _groups, value);
		}

		public gamedataFileNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
