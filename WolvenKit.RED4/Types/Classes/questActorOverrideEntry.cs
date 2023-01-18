using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questActorOverrideEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("MetadataForOverride")] 
		public CName MetadataForOverride
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("ActorName")] 
		public CName ActorName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public questActorOverrideEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
