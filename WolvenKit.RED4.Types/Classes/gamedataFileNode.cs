using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamedataFileNode : gamedataDataNode
	{
		[Ordinal(3)] 
		[RED("packageName")] 
		public CString PackageName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("packageDependencies", 16)] 
		public CStatic<CWeakHandle<gamedataPackageNode>> PackageDependencies
		{
			get => GetPropertyValue<CStatic<CWeakHandle<gamedataPackageNode>>>();
			set => SetPropertyValue<CStatic<CWeakHandle<gamedataPackageNode>>>(value);
		}

		[Ordinal(5)] 
		[RED("package")] 
		public CWeakHandle<gamedataPackageNode> Package
		{
			get => GetPropertyValue<CWeakHandle<gamedataPackageNode>>();
			set => SetPropertyValue<CWeakHandle<gamedataPackageNode>>(value);
		}

		[Ordinal(6)] 
		[RED("variables")] 
		public CArray<CHandle<gamedataVariableNode>> Variables
		{
			get => GetPropertyValue<CArray<CHandle<gamedataVariableNode>>>();
			set => SetPropertyValue<CArray<CHandle<gamedataVariableNode>>>(value);
		}

		[Ordinal(7)] 
		[RED("groups")] 
		public CArray<CHandle<gamedataGroupNode>> Groups
		{
			get => GetPropertyValue<CArray<CHandle<gamedataGroupNode>>>();
			set => SetPropertyValue<CArray<CHandle<gamedataGroupNode>>>(value);
		}

		public gamedataFileNode()
		{
			PackageDependencies = new(0);
			Variables = new();
			Groups = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
