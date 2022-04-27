using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DamageStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("weapon")] 
		public CWeakHandle<gameweaponObject> Weapon
		{
			get => GetPropertyValue<CWeakHandle<gameweaponObject>>();
			set => SetPropertyValue<CWeakHandle<gameweaponObject>>(value);
		}

		[Ordinal(1)] 
		[RED("updateEvt")] 
		public CHandle<UpdateDamageChangeEvent> UpdateEvt
		{
			get => GetPropertyValue<CHandle<UpdateDamageChangeEvent>>();
			set => SetPropertyValue<CHandle<UpdateDamageChangeEvent>>(value);
		}

		public DamageStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
