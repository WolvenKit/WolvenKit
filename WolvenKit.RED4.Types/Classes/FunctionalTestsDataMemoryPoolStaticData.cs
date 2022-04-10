using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FunctionalTestsDataMemoryPoolStaticData : ISerializable
	{
		[Ordinal(0)] 
		[RED("poolName")] 
		public CString PoolName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("budget")] 
		public CInt64 Budget
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(2)] 
		[RED("childrenBudget")] 
		public CInt64 ChildrenBudget
		{
			get => GetPropertyValue<CInt64>();
			set => SetPropertyValue<CInt64>(value);
		}

		[Ordinal(3)] 
		[RED("children")] 
		public CArray<CString> Children
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		[Ordinal(4)] 
		[RED("parent")] 
		public CString Parent
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public FunctionalTestsDataMemoryPoolStaticData()
		{
			Children = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
