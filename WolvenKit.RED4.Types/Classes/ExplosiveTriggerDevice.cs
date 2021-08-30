using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ExplosiveTriggerDevice : ExplosiveDevice
	{
		private CHandle<entMeshComponent> _meshTrigger;
		private CHandle<gameStaticTriggerAreaComponent> _trapTrigger;
		private CName _triggerName;
		private CHandle<gameStaticTriggerAreaComponent> _surroundingArea;
		private CName _surroundingAreaName;
		private CBool _soundIsActive;
		private CBool _playerIsInSurroundingArea;
		private gameDelayID _proximityExplosionEventID;
		private CBool _proximityExplosionEventSent;

		[Ordinal(120)] 
		[RED("meshTrigger")] 
		public CHandle<entMeshComponent> MeshTrigger
		{
			get => GetProperty(ref _meshTrigger);
			set => SetProperty(ref _meshTrigger, value);
		}

		[Ordinal(121)] 
		[RED("trapTrigger")] 
		public CHandle<gameStaticTriggerAreaComponent> TrapTrigger
		{
			get => GetProperty(ref _trapTrigger);
			set => SetProperty(ref _trapTrigger, value);
		}

		[Ordinal(122)] 
		[RED("triggerName")] 
		public CName TriggerName
		{
			get => GetProperty(ref _triggerName);
			set => SetProperty(ref _triggerName, value);
		}

		[Ordinal(123)] 
		[RED("surroundingArea")] 
		public CHandle<gameStaticTriggerAreaComponent> SurroundingArea
		{
			get => GetProperty(ref _surroundingArea);
			set => SetProperty(ref _surroundingArea, value);
		}

		[Ordinal(124)] 
		[RED("surroundingAreaName")] 
		public CName SurroundingAreaName
		{
			get => GetProperty(ref _surroundingAreaName);
			set => SetProperty(ref _surroundingAreaName, value);
		}

		[Ordinal(125)] 
		[RED("soundIsActive")] 
		public CBool SoundIsActive
		{
			get => GetProperty(ref _soundIsActive);
			set => SetProperty(ref _soundIsActive, value);
		}

		[Ordinal(126)] 
		[RED("playerIsInSurroundingArea")] 
		public CBool PlayerIsInSurroundingArea
		{
			get => GetProperty(ref _playerIsInSurroundingArea);
			set => SetProperty(ref _playerIsInSurroundingArea, value);
		}

		[Ordinal(127)] 
		[RED("proximityExplosionEventID")] 
		public gameDelayID ProximityExplosionEventID
		{
			get => GetProperty(ref _proximityExplosionEventID);
			set => SetProperty(ref _proximityExplosionEventID, value);
		}

		[Ordinal(128)] 
		[RED("proximityExplosionEventSent")] 
		public CBool ProximityExplosionEventSent
		{
			get => GetProperty(ref _proximityExplosionEventSent);
			set => SetProperty(ref _proximityExplosionEventSent, value);
		}

		public ExplosiveTriggerDevice()
		{
			_triggerName = "trapTrigger";
			_surroundingAreaName = "surroundingArea";
		}
	}
}
