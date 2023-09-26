using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class resDlcManifest : CResource
	{
		[Ordinal(1)] 
		[RED("tweakBlob")] 
		public CResourceAsyncReference<CResource> TweakBlob
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(2)] 
		[RED("quest")] 
		public CResourceAsyncReference<CResource> Quest
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(3)] 
		[RED("journal")] 
		public CResourceAsyncReference<CResource> Journal
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(4)] 
		[RED("factories")] 
		public CResourceAsyncReference<CResource> Factories
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(5)] 
		[RED("weaponAppearances")] 
		public CResourceAsyncReference<CResource> WeaponAppearances
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(6)] 
		[RED("vehicleAppearances")] 
		public CResourceAsyncReference<CResource> VehicleAppearances
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(7)] 
		[RED("communitySpawnsets")] 
		public CResourceAsyncReference<CResource> CommunitySpawnsets
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(8)] 
		[RED("archetypeSet")] 
		public CResourceAsyncReference<CResource> ArchetypeSet
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(9)] 
		[RED("vehicleCovers")] 
		public CResourceAsyncReference<CResource> VehicleCovers
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(10)] 
		[RED("cookedAudioMetadata")] 
		public CResourceAsyncReference<CResource> CookedAudioMetadata
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(11)] 
		[RED("voiceTags")] 
		public CResourceAsyncReference<CResource> VoiceTags
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(12)] 
		[RED("widgetsLibrariesOverrides")] 
		public CResourceAsyncReference<CResource> WidgetsLibrariesOverrides
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(13)] 
		[RED("gameDefsList")] 
		public CResourceAsyncReference<CResource> GameDefsList
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(14)] 
		[RED("cookedMultilayerSetup")] 
		public CResourceAsyncReference<CResource> CookedMultilayerSetup
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(15)] 
		[RED("visualTagsToAppearanceNames")] 
		public CResourceAsyncReference<CResource> VisualTagsToAppearanceNames
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(16)] 
		[RED("appearanceNameToVisualTags")] 
		public CResourceAsyncReference<CResource> AppearanceNameToVisualTags
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(17)] 
		[RED("defaultAppearances")] 
		public CResourceAsyncReference<CResource> DefaultAppearances
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(18)] 
		[RED("colorVariantsMap")] 
		public CResourceAsyncReference<CResource> ColorVariantsMap
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		public resDlcManifest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
