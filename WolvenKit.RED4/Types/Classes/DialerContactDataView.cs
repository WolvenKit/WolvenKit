using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DialerContactDataView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetPropertyValue<CHandle<CompareBuilder>>();
			set => SetPropertyValue<CHandle<CompareBuilder>>(value);
		}

		[Ordinal(1)] 
		[RED("sortMethod")] 
		public CEnum<ContactsSortMethod> SortMethod
		{
			get => GetPropertyValue<CEnum<ContactsSortMethod>>();
			set => SetPropertyValue<CEnum<ContactsSortMethod>>(value);
		}

		public DialerContactDataView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
