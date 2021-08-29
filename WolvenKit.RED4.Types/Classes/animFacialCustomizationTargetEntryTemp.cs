using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animFacialCustomizationTargetEntryTemp : RedBaseClass
	{
		private CResourceAsyncReference<animFacialSetup> _setup;
		private CArray<CName> _targetNames;

		[Ordinal(0)] 
		[RED("setup")] 
		public CResourceAsyncReference<animFacialSetup> Setup
		{
			get => GetProperty(ref _setup);
			set => SetProperty(ref _setup, value);
		}

		[Ordinal(1)] 
		[RED("targetNames")] 
		public CArray<CName> TargetNames
		{
			get => GetProperty(ref _targetNames);
			set => SetProperty(ref _targetNames, value);
		}
	}
}
