using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverheatStatListener : gameScriptStatPoolsListener
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
		public CHandle<UpdateOverheatEvent> UpdateEvt
		{
			get => GetPropertyValue<CHandle<UpdateOverheatEvent>>();
			set => SetPropertyValue<CHandle<UpdateOverheatEvent>>(value);
		}

		[Ordinal(2)] 
		[RED("startEvt")] 
		public CHandle<StartOverheatEffectEvent> StartEvt
		{
			get => GetPropertyValue<CHandle<StartOverheatEffectEvent>>();
			set => SetPropertyValue<CHandle<StartOverheatEffectEvent>>(value);
		}

		public OverheatStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
