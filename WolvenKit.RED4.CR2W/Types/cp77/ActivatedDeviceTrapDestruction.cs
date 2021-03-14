using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ActivatedDeviceTrapDestruction : ActivatedDeviceTrap
	{
		private CArray<CName> _physicalMeshNames;
		private CArray<CHandle<entPhysicalMeshComponent>> _physicalMeshes;
		private CArray<CName> _hideMeshNames;
		private CArray<CHandle<entIPlacedComponent>> _hideMeshes;
		private CArray<CName> _hitColliderNames;
		private CArray<CHandle<entIPlacedComponent>> _hitColliders;
		private Vector4 _impulseVector;
		private CArray<gameFxResource> _physicalMeshImpactVFX;
		private CArray<CName> _componentsToEnableNames;
		private CArray<CHandle<entIPlacedComponent>> _componentsToEnable;
		private CInt32 _hitCount;
		private CBool _wasAttackPerformed;
		private CArray<CName> _alreadyPlayedVFXComponents;
		private CBool _shouldCheckPhysicalCollisions;
		private wCHandle<IScriptable> _lastEntityHit;
		private CFloat _timeToActivatePhysics;

		[Ordinal(95)] 
		[RED("physicalMeshNames")] 
		public CArray<CName> PhysicalMeshNames
		{
			get
			{
				if (_physicalMeshNames == null)
				{
					_physicalMeshNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "physicalMeshNames", cr2w, this);
				}
				return _physicalMeshNames;
			}
			set
			{
				if (_physicalMeshNames == value)
				{
					return;
				}
				_physicalMeshNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("physicalMeshes")] 
		public CArray<CHandle<entPhysicalMeshComponent>> PhysicalMeshes
		{
			get
			{
				if (_physicalMeshes == null)
				{
					_physicalMeshes = (CArray<CHandle<entPhysicalMeshComponent>>) CR2WTypeManager.Create("array:handle:entPhysicalMeshComponent", "physicalMeshes", cr2w, this);
				}
				return _physicalMeshes;
			}
			set
			{
				if (_physicalMeshes == value)
				{
					return;
				}
				_physicalMeshes = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("hideMeshNames")] 
		public CArray<CName> HideMeshNames
		{
			get
			{
				if (_hideMeshNames == null)
				{
					_hideMeshNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "hideMeshNames", cr2w, this);
				}
				return _hideMeshNames;
			}
			set
			{
				if (_hideMeshNames == value)
				{
					return;
				}
				_hideMeshNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("hideMeshes")] 
		public CArray<CHandle<entIPlacedComponent>> HideMeshes
		{
			get
			{
				if (_hideMeshes == null)
				{
					_hideMeshes = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "hideMeshes", cr2w, this);
				}
				return _hideMeshes;
			}
			set
			{
				if (_hideMeshes == value)
				{
					return;
				}
				_hideMeshes = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("hitColliderNames")] 
		public CArray<CName> HitColliderNames
		{
			get
			{
				if (_hitColliderNames == null)
				{
					_hitColliderNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "hitColliderNames", cr2w, this);
				}
				return _hitColliderNames;
			}
			set
			{
				if (_hitColliderNames == value)
				{
					return;
				}
				_hitColliderNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("hitColliders")] 
		public CArray<CHandle<entIPlacedComponent>> HitColliders
		{
			get
			{
				if (_hitColliders == null)
				{
					_hitColliders = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "hitColliders", cr2w, this);
				}
				return _hitColliders;
			}
			set
			{
				if (_hitColliders == value)
				{
					return;
				}
				_hitColliders = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("impulseVector")] 
		public Vector4 ImpulseVector
		{
			get
			{
				if (_impulseVector == null)
				{
					_impulseVector = (Vector4) CR2WTypeManager.Create("Vector4", "impulseVector", cr2w, this);
				}
				return _impulseVector;
			}
			set
			{
				if (_impulseVector == value)
				{
					return;
				}
				_impulseVector = value;
				PropertySet(this);
			}
		}

		[Ordinal(102)] 
		[RED("physicalMeshImpactVFX")] 
		public CArray<gameFxResource> PhysicalMeshImpactVFX
		{
			get
			{
				if (_physicalMeshImpactVFX == null)
				{
					_physicalMeshImpactVFX = (CArray<gameFxResource>) CR2WTypeManager.Create("array:gameFxResource", "physicalMeshImpactVFX", cr2w, this);
				}
				return _physicalMeshImpactVFX;
			}
			set
			{
				if (_physicalMeshImpactVFX == value)
				{
					return;
				}
				_physicalMeshImpactVFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(103)] 
		[RED("componentsToEnableNames")] 
		public CArray<CName> ComponentsToEnableNames
		{
			get
			{
				if (_componentsToEnableNames == null)
				{
					_componentsToEnableNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "componentsToEnableNames", cr2w, this);
				}
				return _componentsToEnableNames;
			}
			set
			{
				if (_componentsToEnableNames == value)
				{
					return;
				}
				_componentsToEnableNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(104)] 
		[RED("componentsToEnable")] 
		public CArray<CHandle<entIPlacedComponent>> ComponentsToEnable
		{
			get
			{
				if (_componentsToEnable == null)
				{
					_componentsToEnable = (CArray<CHandle<entIPlacedComponent>>) CR2WTypeManager.Create("array:handle:entIPlacedComponent", "componentsToEnable", cr2w, this);
				}
				return _componentsToEnable;
			}
			set
			{
				if (_componentsToEnable == value)
				{
					return;
				}
				_componentsToEnable = value;
				PropertySet(this);
			}
		}

		[Ordinal(105)] 
		[RED("hitCount")] 
		public CInt32 HitCount
		{
			get
			{
				if (_hitCount == null)
				{
					_hitCount = (CInt32) CR2WTypeManager.Create("Int32", "hitCount", cr2w, this);
				}
				return _hitCount;
			}
			set
			{
				if (_hitCount == value)
				{
					return;
				}
				_hitCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(106)] 
		[RED("wasAttackPerformed")] 
		public CBool WasAttackPerformed
		{
			get
			{
				if (_wasAttackPerformed == null)
				{
					_wasAttackPerformed = (CBool) CR2WTypeManager.Create("Bool", "wasAttackPerformed", cr2w, this);
				}
				return _wasAttackPerformed;
			}
			set
			{
				if (_wasAttackPerformed == value)
				{
					return;
				}
				_wasAttackPerformed = value;
				PropertySet(this);
			}
		}

		[Ordinal(107)] 
		[RED("alreadyPlayedVFXComponents")] 
		public CArray<CName> AlreadyPlayedVFXComponents
		{
			get
			{
				if (_alreadyPlayedVFXComponents == null)
				{
					_alreadyPlayedVFXComponents = (CArray<CName>) CR2WTypeManager.Create("array:CName", "alreadyPlayedVFXComponents", cr2w, this);
				}
				return _alreadyPlayedVFXComponents;
			}
			set
			{
				if (_alreadyPlayedVFXComponents == value)
				{
					return;
				}
				_alreadyPlayedVFXComponents = value;
				PropertySet(this);
			}
		}

		[Ordinal(108)] 
		[RED("shouldCheckPhysicalCollisions")] 
		public CBool ShouldCheckPhysicalCollisions
		{
			get
			{
				if (_shouldCheckPhysicalCollisions == null)
				{
					_shouldCheckPhysicalCollisions = (CBool) CR2WTypeManager.Create("Bool", "shouldCheckPhysicalCollisions", cr2w, this);
				}
				return _shouldCheckPhysicalCollisions;
			}
			set
			{
				if (_shouldCheckPhysicalCollisions == value)
				{
					return;
				}
				_shouldCheckPhysicalCollisions = value;
				PropertySet(this);
			}
		}

		[Ordinal(109)] 
		[RED("lastEntityHit")] 
		public wCHandle<IScriptable> LastEntityHit
		{
			get
			{
				if (_lastEntityHit == null)
				{
					_lastEntityHit = (wCHandle<IScriptable>) CR2WTypeManager.Create("whandle:IScriptable", "lastEntityHit", cr2w, this);
				}
				return _lastEntityHit;
			}
			set
			{
				if (_lastEntityHit == value)
				{
					return;
				}
				_lastEntityHit = value;
				PropertySet(this);
			}
		}

		[Ordinal(110)] 
		[RED("timeToActivatePhysics")] 
		public CFloat TimeToActivatePhysics
		{
			get
			{
				if (_timeToActivatePhysics == null)
				{
					_timeToActivatePhysics = (CFloat) CR2WTypeManager.Create("Float", "timeToActivatePhysics", cr2w, this);
				}
				return _timeToActivatePhysics;
			}
			set
			{
				if (_timeToActivatePhysics == value)
				{
					return;
				}
				_timeToActivatePhysics = value;
				PropertySet(this);
			}
		}

		public ActivatedDeviceTrapDestruction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
