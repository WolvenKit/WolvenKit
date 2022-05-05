using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ThrowingKnifeResourcePoolListener : gameScriptStatPoolsListener
	{
		[Ordinal(0)] 
		[RED("Crosshair")] 
		public CWeakHandle<Crosshair_Melee_Knife> Crosshair
		{
			get => GetPropertyValue<CWeakHandle<Crosshair_Melee_Knife>>();
			set => SetPropertyValue<CWeakHandle<Crosshair_Melee_Knife>>(value);
		}

		[Ordinal(1)] 
		[RED("shouldDisplayBar")] 
		public CBool ShouldDisplayBar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("evt")] 
		public CHandle<ThrowingKnifeReloadFinishedCrosshairEvent> Evt
		{
			get => GetPropertyValue<CHandle<ThrowingKnifeReloadFinishedCrosshairEvent>>();
			set => SetPropertyValue<CHandle<ThrowingKnifeReloadFinishedCrosshairEvent>>(value);
		}

		public ThrowingKnifeResourcePoolListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
