using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DebugDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _weaponSpread_EvenDistributionRowCount;
		private gamebbScriptID_Int32 _weaponSpread_ProjectilesPerShot;
		private gamebbScriptID_Bool _weaponSpread_UseCircularSpread;
		private gamebbScriptID_Bool _weaponSpread_UseEvenDistribution;
		private gamebbScriptID_Bool _vehicle_BlockSwitchSeats;

		[Ordinal(0)] 
		[RED("WeaponSpread_EvenDistributionRowCount")] 
		public gamebbScriptID_Int32 WeaponSpread_EvenDistributionRowCount
		{
			get => GetProperty(ref _weaponSpread_EvenDistributionRowCount);
			set => SetProperty(ref _weaponSpread_EvenDistributionRowCount, value);
		}

		[Ordinal(1)] 
		[RED("WeaponSpread_ProjectilesPerShot")] 
		public gamebbScriptID_Int32 WeaponSpread_ProjectilesPerShot
		{
			get => GetProperty(ref _weaponSpread_ProjectilesPerShot);
			set => SetProperty(ref _weaponSpread_ProjectilesPerShot, value);
		}

		[Ordinal(2)] 
		[RED("WeaponSpread_UseCircularSpread")] 
		public gamebbScriptID_Bool WeaponSpread_UseCircularSpread
		{
			get => GetProperty(ref _weaponSpread_UseCircularSpread);
			set => SetProperty(ref _weaponSpread_UseCircularSpread, value);
		}

		[Ordinal(3)] 
		[RED("WeaponSpread_UseEvenDistribution")] 
		public gamebbScriptID_Bool WeaponSpread_UseEvenDistribution
		{
			get => GetProperty(ref _weaponSpread_UseEvenDistribution);
			set => SetProperty(ref _weaponSpread_UseEvenDistribution, value);
		}

		[Ordinal(4)] 
		[RED("Vehicle_BlockSwitchSeats")] 
		public gamebbScriptID_Bool Vehicle_BlockSwitchSeats
		{
			get => GetProperty(ref _vehicle_BlockSwitchSeats);
			set => SetProperty(ref _vehicle_BlockSwitchSeats, value);
		}

		public DebugDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
