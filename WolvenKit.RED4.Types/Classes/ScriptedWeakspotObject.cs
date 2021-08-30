using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScriptedWeakspotObject : gameWeakspotObject
	{
		private WeakspotOnDestroyProperties _weakspotOnDestroyProperties;
		private CHandle<entMeshComponent> _mesh;
		private CHandle<gameinteractionsComponent> _interaction;
		private CHandle<entIPlacedComponent> _collider;
		private CWeakHandle<gameObject> _instigator;
		private WeakspotRecordData _weakspotRecordData;
		private CBool _alive;
		private CBool _hasBeenScanned;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CHandle<WeakspotHealthChangeListener> _healthListener;

		[Ordinal(40)] 
		[RED("weakspotOnDestroyProperties")] 
		public WeakspotOnDestroyProperties WeakspotOnDestroyProperties
		{
			get => GetProperty(ref _weakspotOnDestroyProperties);
			set => SetProperty(ref _weakspotOnDestroyProperties, value);
		}

		[Ordinal(41)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(42)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetProperty(ref _interaction);
			set => SetProperty(ref _interaction, value);
		}

		[Ordinal(43)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get => GetProperty(ref _collider);
			set => SetProperty(ref _collider, value);
		}

		[Ordinal(44)] 
		[RED("instigator")] 
		public CWeakHandle<gameObject> Instigator
		{
			get => GetProperty(ref _instigator);
			set => SetProperty(ref _instigator, value);
		}

		[Ordinal(45)] 
		[RED("weakspotRecordData")] 
		public WeakspotRecordData WeakspotRecordData
		{
			get => GetProperty(ref _weakspotRecordData);
			set => SetProperty(ref _weakspotRecordData, value);
		}

		[Ordinal(46)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		[Ordinal(47)] 
		[RED("hasBeenScanned")] 
		public CBool HasBeenScanned
		{
			get => GetProperty(ref _hasBeenScanned);
			set => SetProperty(ref _hasBeenScanned, value);
		}

		[Ordinal(48)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		[Ordinal(49)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(50)] 
		[RED("healthListener")] 
		public CHandle<WeakspotHealthChangeListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		public ScriptedWeakspotObject()
		{
			_alive = true;
		}
	}
}
