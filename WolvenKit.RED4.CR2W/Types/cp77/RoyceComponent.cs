using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RoyceComponent : gameScriptableComponent
	{
		private wCHandle<NPCPuppet> _owner;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<RoyceHealthChangeListener> _healthListener;
		private CHandle<entSimpleColliderComponent> _npcCollisionComponent;
		private CHandle<entIComponent> _npcHitRepresentationComponent;
		private CHandle<animAnimFeature_HitReactionsData> _hitData;

		[Ordinal(5)] 
		[RED("owner")] 
		public wCHandle<NPCPuppet> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(6)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		[Ordinal(7)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(8)] 
		[RED("healthListener")] 
		public CHandle<RoyceHealthChangeListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		[Ordinal(9)] 
		[RED("npcCollisionComponent")] 
		public CHandle<entSimpleColliderComponent> NpcCollisionComponent
		{
			get => GetProperty(ref _npcCollisionComponent);
			set => SetProperty(ref _npcCollisionComponent, value);
		}

		[Ordinal(10)] 
		[RED("npcHitRepresentationComponent")] 
		public CHandle<entIComponent> NpcHitRepresentationComponent
		{
			get => GetProperty(ref _npcHitRepresentationComponent);
			set => SetProperty(ref _npcHitRepresentationComponent, value);
		}

		[Ordinal(11)] 
		[RED("hitData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitData
		{
			get => GetProperty(ref _hitData);
			set => SetProperty(ref _hitData, value);
		}

		public RoyceComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
