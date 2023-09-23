using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VirtualNestedListDataView : inkScriptableDataViewWrapper
	{
		[Ordinal(0)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetPropertyValue<CHandle<CompareBuilder>>();
			set => SetPropertyValue<CHandle<CompareBuilder>>(value);
		}

		[Ordinal(1)] 
		[RED("defaultCollapsed")] 
		public CBool DefaultCollapsed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("toggledLevels")] 
		public CArray<CInt32> ToggledLevels
		{
			get => GetPropertyValue<CArray<CInt32>>();
			set => SetPropertyValue<CArray<CInt32>>(value);
		}

		public VirtualNestedListDataView()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
