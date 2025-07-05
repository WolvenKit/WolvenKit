using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnLookAtBodyPartPropertiesAdvanced : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("bodyPartName")] 
		public CName BodyPartName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scnLookAtBodyPartPropertiesAdvanced()
		{
			BodyPartName = "Head";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
