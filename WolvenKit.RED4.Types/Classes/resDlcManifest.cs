using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class resDlcManifest : CResource
	{
		private CResourceAsyncReference<CResource> _tweakBlob;
		private CResourceAsyncReference<CResource> _quest;
		private CResourceAsyncReference<CResource> _journal;
		private CResourceAsyncReference<CResource> _factories;
		private CResourceAsyncReference<CResource> _weaponAppearances;
		private CResourceAsyncReference<CResource> _vehicleAppearances;
		private CResourceAsyncReference<CResource> _communitySpawnsets;

		[Ordinal(1)] 
		[RED("tweakBlob")] 
		public CResourceAsyncReference<CResource> TweakBlob
		{
			get => GetProperty(ref _tweakBlob);
			set => SetProperty(ref _tweakBlob, value);
		}

		[Ordinal(2)] 
		[RED("quest")] 
		public CResourceAsyncReference<CResource> Quest
		{
			get => GetProperty(ref _quest);
			set => SetProperty(ref _quest, value);
		}

		[Ordinal(3)] 
		[RED("journal")] 
		public CResourceAsyncReference<CResource> Journal
		{
			get => GetProperty(ref _journal);
			set => SetProperty(ref _journal, value);
		}

		[Ordinal(4)] 
		[RED("factories")] 
		public CResourceAsyncReference<CResource> Factories
		{
			get => GetProperty(ref _factories);
			set => SetProperty(ref _factories, value);
		}

		[Ordinal(5)] 
		[RED("weaponAppearances")] 
		public CResourceAsyncReference<CResource> WeaponAppearances
		{
			get => GetProperty(ref _weaponAppearances);
			set => SetProperty(ref _weaponAppearances, value);
		}

		[Ordinal(6)] 
		[RED("vehicleAppearances")] 
		public CResourceAsyncReference<CResource> VehicleAppearances
		{
			get => GetProperty(ref _vehicleAppearances);
			set => SetProperty(ref _vehicleAppearances, value);
		}

		[Ordinal(7)] 
		[RED("communitySpawnsets")] 
		public CResourceAsyncReference<CResource> CommunitySpawnsets
		{
			get => GetProperty(ref _communitySpawnsets);
			set => SetProperty(ref _communitySpawnsets, value);
		}
	}
}
