using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class resDlcManifest : CResource
	{
		private raRef<CResource> _tweakBlob;
		private raRef<CResource> _quest;
		private raRef<CResource> _journal;
		private raRef<CResource> _factories;
		private raRef<CResource> _weaponAppearances;
		private raRef<CResource> _vehicleAppearances;
		private raRef<CResource> _communitySpawnsets;

		[Ordinal(1)] 
		[RED("tweakBlob")] 
		public raRef<CResource> TweakBlob
		{
			get => GetProperty(ref _tweakBlob);
			set => SetProperty(ref _tweakBlob, value);
		}

		[Ordinal(2)] 
		[RED("quest")] 
		public raRef<CResource> Quest
		{
			get => GetProperty(ref _quest);
			set => SetProperty(ref _quest, value);
		}

		[Ordinal(3)] 
		[RED("journal")] 
		public raRef<CResource> Journal
		{
			get => GetProperty(ref _journal);
			set => SetProperty(ref _journal, value);
		}

		[Ordinal(4)] 
		[RED("factories")] 
		public raRef<CResource> Factories
		{
			get => GetProperty(ref _factories);
			set => SetProperty(ref _factories, value);
		}

		[Ordinal(5)] 
		[RED("weaponAppearances")] 
		public raRef<CResource> WeaponAppearances
		{
			get => GetProperty(ref _weaponAppearances);
			set => SetProperty(ref _weaponAppearances, value);
		}

		[Ordinal(6)] 
		[RED("vehicleAppearances")] 
		public raRef<CResource> VehicleAppearances
		{
			get => GetProperty(ref _vehicleAppearances);
			set => SetProperty(ref _vehicleAppearances, value);
		}

		[Ordinal(7)] 
		[RED("communitySpawnsets")] 
		public raRef<CResource> CommunitySpawnsets
		{
			get => GetProperty(ref _communitySpawnsets);
			set => SetProperty(ref _communitySpawnsets, value);
		}

		public resDlcManifest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
