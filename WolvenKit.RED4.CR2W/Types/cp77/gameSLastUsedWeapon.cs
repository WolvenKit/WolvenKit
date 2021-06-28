using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSLastUsedWeapon : CVariable
	{
		private gameItemID _lastUsedWeapon;
		private gameItemID _lastUsedRanged;
		private gameItemID _lastUsedMelee;
		private gameItemID _lastUsedHeavy;

		[Ordinal(0)] 
		[RED("lastUsedWeapon")] 
		public gameItemID LastUsedWeapon
		{
			get => GetProperty(ref _lastUsedWeapon);
			set => SetProperty(ref _lastUsedWeapon, value);
		}

		[Ordinal(1)] 
		[RED("lastUsedRanged")] 
		public gameItemID LastUsedRanged
		{
			get => GetProperty(ref _lastUsedRanged);
			set => SetProperty(ref _lastUsedRanged, value);
		}

		[Ordinal(2)] 
		[RED("lastUsedMelee")] 
		public gameItemID LastUsedMelee
		{
			get => GetProperty(ref _lastUsedMelee);
			set => SetProperty(ref _lastUsedMelee, value);
		}

		[Ordinal(3)] 
		[RED("lastUsedHeavy")] 
		public gameItemID LastUsedHeavy
		{
			get => GetProperty(ref _lastUsedHeavy);
			set => SetProperty(ref _lastUsedHeavy, value);
		}

		public gameSLastUsedWeapon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
