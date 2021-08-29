using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkContainerNavigationController : inkDiscreteNavigationController
	{
		private CArray<inkNavigationOverrideEntry> _overrideEntries;
		private CBool _useGlobalInput;

		[Ordinal(4)] 
		[RED("overrideEntries")] 
		public CArray<inkNavigationOverrideEntry> OverrideEntries
		{
			get => GetProperty(ref _overrideEntries);
			set => SetProperty(ref _overrideEntries, value);
		}

		[Ordinal(5)] 
		[RED("useGlobalInput")] 
		public CBool UseGlobalInput
		{
			get => GetProperty(ref _useGlobalInput);
			set => SetProperty(ref _useGlobalInput, value);
		}
	}
}
