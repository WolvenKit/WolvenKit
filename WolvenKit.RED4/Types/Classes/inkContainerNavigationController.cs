using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkContainerNavigationController : inkDiscreteNavigationController
	{
		[Ordinal(4)] 
		[RED("overrideEntries")] 
		public CArray<inkNavigationOverrideEntry> OverrideEntries
		{
			get => GetPropertyValue<CArray<inkNavigationOverrideEntry>>();
			set => SetPropertyValue<CArray<inkNavigationOverrideEntry>>(value);
		}

		[Ordinal(5)] 
		[RED("useGlobalInput")] 
		public CBool UseGlobalInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public inkContainerNavigationController()
		{
			OverrideEntries = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
