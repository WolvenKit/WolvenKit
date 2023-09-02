using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ExplosiveTriggerDevice : ExplosiveDevice
	{
		[Ordinal(117)] 
		[RED("meshTrigger")] 
		public CHandle<entMeshComponent> MeshTrigger
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(118)] 
		[RED("trapTrigger")] 
		public CHandle<gameStaticTriggerAreaComponent> TrapTrigger
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(119)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(120)] 
		[RED("surroundingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> SurroundingArea
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(121)] 
		[RED("surroundingAreaName")] 
		public CName SurroundingAreaName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(122)] 
		[RED("soundIsActive")] 
		public CBool SoundIsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(123)] 
		[RED("playerIsInSurroundingArea")] 
		public CBool PlayerIsInSurroundingArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(124)] 
		[RED("proximityExplosionEventID")] 
		public gameDelayID ProximityExplosionEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(125)] 
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
