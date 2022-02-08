using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplosiveTriggerDevice : ExplosiveDevice
	{
		[Ordinal(120)] 
		[RED("meshTrigger")] 
		public CHandle<entMeshComponent> MeshTrigger
		{
			get => GetPropertyValue<CHandle<entMeshComponent>>();
			set => SetPropertyValue<CHandle<entMeshComponent>>(value);
		}

		[Ordinal(121)] 
		[RED("trapTrigger")] 
		public CHandle<gameStaticTriggerAreaComponent> TrapTrigger
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(122)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(123)] 
		[RED("surroundingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> SurroundingArea
		{
			get => GetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>();
			set => SetPropertyValue<CHandle<gameStaticTriggerAreaComponent>>(value);
		}

		[Ordinal(124)] 
		[RED("surroundingAreaName")] 
		public CName SurroundingAreaName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(125)] 
		[RED("soundIsActive")] 
		public CBool SoundIsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(126)] 
		[RED("playerIsInSurroundingArea")] 
		public CBool PlayerIsInSurroundingArea
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(127)] 
		[RED("proximityExplosionEventID")] 
		public gameDelayID ProximityExplosionEventID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(128)] 
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
			ProximityExplosionEventID = new();
		}
	}
}
