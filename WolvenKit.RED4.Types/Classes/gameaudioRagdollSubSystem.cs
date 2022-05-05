using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameaudioRagdollSubSystem : gameaudioISoundComponentSubSystem
	{
		[Ordinal(0)] 
		[RED("defaultMaterialMetadata")] 
		public CName DefaultMaterialMetadata
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("customDismembermentSettings")] 
		public CName CustomDismembermentSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("lookupMatrixName")] 
		public CName LookupMatrixName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameaudioRagdollSubSystem()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
