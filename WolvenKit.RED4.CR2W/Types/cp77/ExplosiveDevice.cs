using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExplosiveDevice : BasicDistractionDevice
	{
		private CInt32 _numberOfComponentsToON;
		private CInt32 _numberOfComponentsToOFF;
		private CArray<CInt32> _indexesOfComponentsToOFF;
		private CBool _shouldDistractionEnableCollider;
		private CBool _shouldDistractionVFXstay;
		private CName _loopAudioEvent;
		private CArray<CHandle<gameFxInstance>> _spawnedFxInstancesToKill;
		private CHandle<entMeshComponent> _mesh;
		private CHandle<entIPlacedComponent> _collider;
		private CHandle<entIPlacedComponent> _distractionCollider;
		private CInt32 _numberOfReceivedHits;
		private CFloat _devicePenetrationHealth;
		private CBool _killedByExplosion;
		private CFloat _distractionTimeStart;
		private CBool _isBroadcastingEnvironmentalHazardStim;
		private CArray<CHandle<entIPlacedComponent>> _componentsON;
		private CArray<CHandle<entIPlacedComponent>> _componentsOFF;

		[Ordinal(99)] 
		[RED("numberOfComponentsToON")] 
		public CInt32 NumberOfComponentsToON
		{
			get
			{
				if (_numberOfComponentsToON == null)
				{
					_numberOfComponentsToON = (CInt32) CR2WTypeManager.Create("Int32", "numberOfComponentsToON", cr2w, this);
				}
				return _numberOfComponentsToON;
			}
			set
			{
				if (_numberOfComponentsToON == value)
				{
					return;
				}
				_numberOfComponentsToON = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("numberOfComponentsToOFF")] 
		public CInt32 NumberOfComponentsToOFF
		{
			get
			{
				if (_numberOfComponentsToOFF == null)
				{
					_numberOfComponentsToOFF = (CInt32) CR2WTypeManager.Create("Int32", "numberOfComponentsToOFF", cr2w, this);
				}
				return _numberOfComponentsToOFF;
			}
			set
			{
				if (_numberOfComponentsToOFF == value)
				{
					return;
				}
				_numberOfComponentsToOFF = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("indexesOfComponentsToOFF")] 
		public CArray<CInt32> IndexesOfComponentsToOFF
		{
			get
			{
				if (_indexesOfComponentsToOFF == null)
				{
					_indexesOfComponentsToOFF = (CArray<CInt32>) CR2WTypeManager.Create("array:Int32", "indexesOfComponentsToOFF", cr2w, this);
				}
				return _indexesOfComponentsToOFF;
			}
			set
			{
				if (_indexesOfComponentsToOFF == value)
				{
					return;
				}
				_indexesOfComponentsToOFF = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("shouldDistractionEnableCollider")] 
		public CBool ShouldDistractionEnableCollider
		{
			get
			{
				if (_shouldDistractionEnableCollider == null)
				{
					_shouldDistractionEnableCollider = (CBool) CR2WTypeManager.Create("Bool", "shouldDistractionEnableCollider", cr2w, this);
				}
				return _shouldDistractionEnableCollider;
			}
			set
			{
				if (_shouldDistractionEnableCollider == value)
				{
					return;
				}
				_shouldDistractionEnableCollider = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("shouldDistractionVFXstay")] 
		public CBool ShouldDistractionVFXstay
		{
			get
			{
				if (_shouldDistractionVFXstay == null)
				{
					_shouldDistractionVFXstay = (CBool) CR2WTypeManager.Create("Bool", "shouldDistractionVFXstay", cr2w, this);
				}
				return _shouldDistractionVFXstay;
			}
			set
			{
				if (_shouldDistractionVFXstay == value)
				{
					return;
				}
				_shouldDistractionVFXstay = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("loopAudioEvent")] 
		public CName LoopAudioEvent
		{
			get
			{
				if (_loopAudioEvent == null)
				{
					_loopAudioEvent = (CName) CR2WTypeManager.Create("CName", "loopAudioEvent", cr2w, this);
				}
				return _loopAudioEvent;
			}
			set
			{
				if (_loopAudioEvent == value)
				{
					return;
				}
				_loopAudioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("spawnedFxInstancesToKill")] 
		public CArray<CHandle<gameFxInstance>> SpawnedFxInstancesToKill
		{
			get
			{
				if (_spawnedFxInstancesToKill == null)
				{
					_spawnedFxInstancesToKill = (CArray<CHandle<gameFxInstance>>) CR2WTypeManager.Create("array:handle:gameFxInstance", "spawnedFxInstancesToKill", cr2w, this);
				}
				return _spawnedFxInstancesToKill;
			}
			set
			{
				if (_spawnedFxInstancesToKill == value)
				{
					return;
				}
				_spawnedFxInstancesToKill = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get
			{
				if (_mesh == null)
				{
					_mesh = (CHandle<entMeshComponent>) CR2WTypeManager.Create("handle:entMeshComponent", "mesh", cr2w, this);
				}
				return _mesh;
			}
			set
			{
				if (_mesh == value)
				{
					return;
				}
				_mesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("collider")] 
		public CHandle<entIPlacedComponent> Collider
		{
			get
			{
				if (_collider == null)
				{
					_collider = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "collider", cr2w, this);
				}
				return _collider;
			}
			set
			{
				if (_collider == value)
				{
					return;
				}
				_collider = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("distractionCollider")] 
		public CHandle<entIPlacedComponent> DistractionCollider
		{
			get
			{
				if (_distractionCollider == null)
				{
					_distractionCollider = (CHandle<entIPlacedComponent>) CR2WTypeManager.Create("handle:entIPlacedComponent", "distractionCollider", cr2w, this);
				}
				return _distractionCollider;
			}
			set
			{
				if (_distractionCollider == value)
				{
					return;
				}
				_distractionCollider = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("numberOfReceivedHits")] 
		public CInt32 NumberOfReceivedHits
		{
			get
			{
				if (_numberOfReceivedHits == null)
				{
					_numberOfReceivedHits = (CInt32) CR2WTypeManager.Create("Int32", "numberOfReceivedHits", cr2w, this);
				}
				return _numberOfReceivedHits;
			}
			set
			{
				if (_numberOfReceivedHits == value)
				{
					return;
				}
				_numberOfReceivedHits = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("devicePenetrationHealth")] 
		public CFloat DevicePenetrationHealth
		{
			get
			{
				if (_devicePenetrationHealth == null)
				{
					_devicePenetrationHealth = (CFloat) CR2WTypeManager.Create("Float", "devicePenetrationHealth", cr2w, this);
				}
				return _devicePenetrationHealth;
			}
			set
			{
				if (_devicePenetrationHealth == value)
				{
					return;
				}
				_devicePenetrationHealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(111)] 
		[RED("killedByExplosion")] 
		public CBool KilledByExplosion
		{
			get
			{
				if (_killedByExplosion == null)
				{
					_killedByExplosion = (CBool) CR2WTypeManager.Create("Bool", "killedByExplosion", cr2w, this);
				}
				return _killedByExplosion;
			}
			set
			{
				if (_killedByExplosion == value)
				{
					return;
				}
				_killedByExplosion = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("distractionTimeStart")] 
		public CFloat DistractionTimeStart
		{
			get
			{
				if (_distractionTimeStart == null)
				{
					_distractionTimeStart = (CFloat) CR2WTypeManager.Create("Float", "distractionTimeStart", cr2w, this);
				}
				return _distractionTimeStart;
			}
			set
			{
				if (_distractionTimeStart == value)
				{
					return;
				}
				_distractionTimeStart = value;
				PropertySet(this);
			}
		}

		[Ordinal(113)] 
		[RED("isBroadcastingEnvironmentalHazardStim")] 
		public CBool IsBroadcastingEnvironmentalHazardStim
		{
			get
			{
				if (_isBroadcastingEnvironmentalHazardStim == null)
				{
					_isBroadcastingEnvironmentalHazardStim = (CBool) CR2WTypeManager.Create("Bool", "isBroadcastingEnvironmentalHazardStim", cr2w, this);
				}
				return _isBroadcastingEnvironmentalHazardStim;
			}
			set
			{
				if (_isBroadcastingEnvironmentalHazardStim == value)
				{
					return;
				}
				_isBroadcastingEnvironmentalHazardStim = value;
				PropertySet(this);
			}
		}

		[Ordinal(114)] 
		[RED("componentsON")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsON
		{
			get
			{
				if (_componentsON == null)
				{
					_componentsON = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "componentsON", cr2w, this);
				}
				return _componentsON;
			}
			set
			{
				if (_componentsON == value)
				{
					return;
				}
				_componentsON = value;
				PropertySet(this);
			}
		}

		[Ordinal(115)] 
		[RED("componentsOFF")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsOFF
		{
			get
			{
				if (_componentsOFF == null)
				{
					_componentsOFF = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "componentsOFF", cr2w, this);
				}
				return _componentsOFF;
			}
			set
			{
				if (_componentsOFF == value)
				{
					return;
				}
				_componentsOFF = value;
				PropertySet(this);
			}
		}

		public ExplosiveDevice(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
