using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DebugDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("WeaponSpread_EvenDistributionRowCount")] 
		public gamebbScriptID_Int32 WeaponSpread_EvenDistributionRowCount
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(1)] 
		[RED("WeaponSpread_ProjectilesPerShot")] 
		public gamebbScriptID_Int32 WeaponSpread_ProjectilesPerShot
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(2)] 
		[RED("WeaponSpread_UseCircularSpread")] 
		public gamebbScriptID_Bool WeaponSpread_UseCircularSpread
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("WeaponSpread_UseEvenDistribution")] 
		public gamebbScriptID_Bool WeaponSpread_UseEvenDistribution
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("Vehicle_BlockSwitchSeats")] 
		public gamebbScriptID_Bool Vehicle_BlockSwitchSeats
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public DebugDataDef()
		{
			WeaponSpread_EvenDistributionRowCount = new();
			WeaponSpread_ProjectilesPerShot = new();
			WeaponSpread_UseCircularSpread = new();
			WeaponSpread_UseEvenDistribution = new();
			Vehicle_BlockSwitchSeats = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
