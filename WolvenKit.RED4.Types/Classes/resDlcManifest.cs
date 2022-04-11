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

		public resDlcManifest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
