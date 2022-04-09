using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animLookAtPartInfo : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("partName")] 
		public CName PartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("defaultPositionBoneName")] 
		public CName DefaultPositionBoneName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public animLookAtPartInfo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
