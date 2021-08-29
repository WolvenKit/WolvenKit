using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FunctionalTestsDataMemoryPoolStaticData : ISerializable
	{
		private CString _poolName;
		private CInt64 _budget;
		private CInt64 _childrenBudget;
		private CArray<CString> _children;
		private CString _parent;

		[Ordinal(0)] 
		[RED("poolName")] 
		public CString PoolName
		{
			get => GetProperty(ref _poolName);
			set => SetProperty(ref _poolName, value);
		}

		[Ordinal(1)] 
		[RED("budget")] 
		public CInt64 Budget
		{
			get => GetProperty(ref _budget);
			set => SetProperty(ref _budget, value);
		}

		[Ordinal(2)] 
		[RED("childrenBudget")] 
		public CInt64 ChildrenBudget
		{
			get => GetProperty(ref _childrenBudget);
			set => SetProperty(ref _childrenBudget, value);
		}

		[Ordinal(3)] 
		[RED("children")] 
		public CArray<CString> Children
		{
			get => GetProperty(ref _children);
			set => SetProperty(ref _children, value);
		}

		[Ordinal(4)] 
		[RED("parent")] 
		public CString Parent
		{
			get => GetProperty(ref _parent);
			set => SetProperty(ref _parent, value);
		}
	}
}
