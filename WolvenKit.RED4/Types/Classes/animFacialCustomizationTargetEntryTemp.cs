using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animFacialCustomizationTargetEntryTemp : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("setup")] 
		public CResourceAsyncReference<animFacialSetup> Setup
		{
			get => GetPropertyValue<CResourceAsyncReference<animFacialSetup>>();
			set => SetPropertyValue<CResourceAsyncReference<animFacialSetup>>(value);
		}

		[Ordinal(1)] 
		[RED("targetNames")] 
		public CArray<CName> TargetNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		public animFacialCustomizationTargetEntryTemp()
		{
			TargetNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
