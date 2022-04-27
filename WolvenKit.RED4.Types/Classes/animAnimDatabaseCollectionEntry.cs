using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimDatabaseCollectionEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("animDatabase")] 
		public CResourceReference<C2dArray> AnimDatabase
		{
			get => GetPropertyValue<CResourceReference<C2dArray>>();
			set => SetPropertyValue<CResourceReference<C2dArray>>(value);
		}

		[Ordinal(2)] 
		[RED("overrideAnimDatabase")] 
		public CResourceReference<animGenericAnimDatabase> OverrideAnimDatabase
		{
			get => GetPropertyValue<CResourceReference<animGenericAnimDatabase>>();
			set => SetPropertyValue<CResourceReference<animGenericAnimDatabase>>(value);
		}

		public animAnimDatabaseCollectionEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
