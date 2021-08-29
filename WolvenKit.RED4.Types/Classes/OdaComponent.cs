using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class OdaComponent : gameScriptableComponent
	{
		private CWeakHandle<NPCPuppet> _owner;
		private entEntityID _owner_id;
		private CHandle<AIHumanComponent> _odaAIComponent;
		private CWeakHandle<gameIBlackboard> _actionBlackBoard;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<OdaEmergencyListener> _healthListener;
		private TweakDBID _statusEffect_emergency;
		private CHandle<AITargetTrackerComponent> _targetTrackerComponent;

		[Ordinal(5)] 
		[RED("owner")] 
		public CWeakHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(6)] 
		[RED("owner_id")] 
		public entEntityID Owner_id
		{
			get => GetProperty(ref _owner_id);
			set => SetProperty(ref _owner_id, value);
		}

		[Ordinal(7)] 
		[RED("odaAIComponent")] 
		public CHandle<AIHumanComponent> OdaAIComponent
		{
			get => GetProperty(ref _odaAIComponent);
			set => SetProperty(ref _odaAIComponent, value);
		}

		[Ordinal(8)] 
		[RED("actionBlackBoard")] 
		public CWeakHandle<gameIBlackboard> ActionBlackBoard
		{
			get => GetProperty(ref _actionBlackBoard);
			set => SetProperty(ref _actionBlackBoard, value);
		}

		[Ordinal(9)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		[Ordinal(10)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(11)] 
		[RED("healthListener")] 
		public CHandle<OdaEmergencyListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		[Ordinal(12)] 
		[RED("statusEffect_emergency")] 
		public TweakDBID StatusEffect_emergency
		{
			get => GetProperty(ref _statusEffect_emergency);
			set => SetProperty(ref _statusEffect_emergency, value);
		}

		[Ordinal(13)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetProperty(ref _targetTrackerComponent);
			set => SetProperty(ref _targetTrackerComponent, value);
		}
	}
}
