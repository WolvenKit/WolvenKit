using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExplosiveTriggerDevice : ExplosiveDevice
	{
		[Ordinal(126)] 
		[RED("meshTrigger")] 
		public CHandle<entMeshComponent> MeshTrigger
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(127)] 
		[RED("trapTrigger")] 
		public CHandle<gameStaticTriggerAreaComponent> TrapTrigger
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(128)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(129)] 
		[RED("surroundingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> SurroundingArea
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(130)] 
		[RED("surroundingAreaName")] 
		public CName SurroundingAreaName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(131)] 
		[RED("soundIsActive")] 
		public CBool SoundIsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(132)] 
		[RED("playerIsInSurroundingArea")] 
		public CBool PlayerIsInSurroundingArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(133)] 
		[RED("proximityExplosionEventID")] 
		public gameDelayID ProximityExplosionEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(134)] 
		[RED("proximityExplosionEventSent")] 
		public CBool ProximityExplosionEventSent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ExplosiveTriggerDevice()
		{
			TriggerName = "trapTrigger";
			SurroundingAreaName = "surroundingArea";
			ProximityExplosionEventID = new gameDelayID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
