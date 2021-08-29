using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamedataFileNode : gamedataDataNode
	{
		private CString _packageName;
		private CStatic<CWeakHandle<gamedataPackageNode>> _packageDependencies;
		private CWeakHandle<gamedataPackageNode> _package;
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
		public CStatic<CWeakHandle<gamedataPackageNode>> PackageDependencies
		{
			get => GetProperty(ref _packageDependencies);
			set => SetProperty(ref _packageDependencies, value);
		}

		[Ordinal(5)] 
		[RED("package")] 
		public CWeakHandle<gamedataPackageNode> Package
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
	}
}
