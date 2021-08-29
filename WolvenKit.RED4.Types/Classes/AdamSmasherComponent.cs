using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AdamSmasherComponent : gameScriptableComponent
	{
		private CWeakHandle<NPCPuppet> _owner;
		private entEntityID _owner_id;
		private TweakDBID _statusEffect_armor1_id;
		private TweakDBID _statusEffect_armor2_id;
		private TweakDBID _statusEffect_armor3_id;
		private TweakDBID _statusEffect_smashed_id;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<AdamSmasherHealthChangeListener> _healthListener;
		private CFloat _phase2Threshold;
		private CFloat _phase3Threshold;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
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
		[RED("statusEffect_armor1_id")] 
		public TweakDBID StatusEffect_armor1_id
		{
			get => GetProperty(ref _statusEffect_armor1_id);
			set => SetProperty(ref _statusEffect_armor1_id, value);
		}

		[Ordinal(8)] 
		[RED("statusEffect_armor2_id")] 
		public TweakDBID StatusEffect_armor2_id
		{
			get => GetProperty(ref _statusEffect_armor2_id);
			set => SetProperty(ref _statusEffect_armor2_id, value);
		}

		[Ordinal(9)] 
		[RED("statusEffect_armor3_id")] 
		public TweakDBID StatusEffect_armor3_id
		{
			get => GetProperty(ref _statusEffect_armor3_id);
			set => SetProperty(ref _statusEffect_armor3_id, value);
		}

		[Ordinal(10)] 
		[RED("statusEffect_smashed_id")] 
		public TweakDBID StatusEffect_smashed_id
		{
			get => GetProperty(ref _statusEffect_smashed_id);
			set => SetProperty(ref _statusEffect_smashed_id, value);
		}

		[Ordinal(11)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		[Ordinal(12)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(13)] 
		[RED("healthListener")] 
		public CHandle<AdamSmasherHealthChangeListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		[Ordinal(14)] 
		[RED("phase2Threshold")] 
		public CFloat Phase2Threshold
		{
			get => GetProperty(ref _phase2Threshold);
			set => SetProperty(ref _phase2Threshold, value);
		}

		[Ordinal(15)] 
		[RED("phase3Threshold")] 
		public CFloat Phase3Threshold
		{
			get => GetProperty(ref _phase3Threshold);
			set => SetProperty(ref _phase3Threshold, value);
		}

		[Ordinal(16)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetProperty(ref _npcCollisionComponent);
			set => SetProperty(ref _npcCollisionComponent, value);
		}

		[Ordinal(17)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetProperty(ref _targetTrackerComponent);
			set => SetProperty(ref _targetTrackerComponent, value);
		}
	}
}
