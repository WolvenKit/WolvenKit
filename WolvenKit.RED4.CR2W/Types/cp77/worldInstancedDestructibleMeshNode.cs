using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldInstancedDestructibleMeshNode : worldMeshNode
	{
		private raRef<CMesh> _staticMesh;
		private CName _staticMeshAppearance;
		private CEnum<physicsSimulationType> _simulationType;
		private CEnum<physicsFilterDataSource> _filterDataSource;
		private CBool _startInactive;
		private CBool _turnDynamicOnImpulse;
		private CBool _useAggregate;
		private CBool _enableSelfCollisionInAggregate;
		private CBool _isDestructible;
		private CHandle<physicsFilterData> _filterData;
		private CFloat _damageThreshold;
		private CFloat _damageEndurance;
		private CBool _accumulateDamage;
		private CFloat _impulseToDamage;
		private raRef<worldEffect> _fracturingEffect;
		private raRef<worldEffect> _idleEffect;
		private CArray<Transform> _instanceTransforms;
		private worldTransformBuffer _cookedInstanceTransforms;
		private CBool _isPierceable;
		private CBool _isWorkspot;
		private NavGenNavigationSetting _navigationSetting;
		private CBool _useMeshNavmeshSettings;

		[Ordinal(1000)] 
		[RED("staticMesh")] 
		public raRef<CMesh> StaticMesh
		{
			get
			{
				if (_staticMesh == null)
				{
					_staticMesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "staticMesh", cr2w, this);
				}
				return _staticMesh;
			}
			set
			{
				if (_staticMesh == value)
				{
					return;
				}
				_staticMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(1001)] 
		[RED("staticMeshAppearance")] 
		public CName StaticMeshAppearance
		{
			get
			{
				if (_staticMeshAppearance == null)
				{
					_staticMeshAppearance = (CName) CR2WTypeManager.Create("CName", "staticMeshAppearance", cr2w, this);
				}
				return _staticMeshAppearance;
			}
			set
			{
				if (_staticMeshAppearance == value)
				{
					return;
				}
				_staticMeshAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1002)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get
			{
				if (_simulationType == null)
				{
					_simulationType = (CEnum<physicsSimulationType>) CR2WTypeManager.Create("physicsSimulationType", "simulationType", cr2w, this);
				}
				return _simulationType;
			}
			set
			{
				if (_simulationType == value)
				{
					return;
				}
				_simulationType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1003)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get
			{
				if (_filterDataSource == null)
				{
					_filterDataSource = (CEnum<physicsFilterDataSource>) CR2WTypeManager.Create("physicsFilterDataSource", "filterDataSource", cr2w, this);
				}
				return _filterDataSource;
			}
			set
			{
				if (_filterDataSource == value)
				{
					return;
				}
				_filterDataSource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1004)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get
			{
				if (_startInactive == null)
				{
					_startInactive = (CBool) CR2WTypeManager.Create("Bool", "startInactive", cr2w, this);
				}
				return _startInactive;
			}
			set
			{
				if (_startInactive == value)
				{
					return;
				}
				_startInactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(1005)] 
		[RED("turnDynamicOnImpulse")] 
		public CBool TurnDynamicOnImpulse
		{
			get
			{
				if (_turnDynamicOnImpulse == null)
				{
					_turnDynamicOnImpulse = (CBool) CR2WTypeManager.Create("Bool", "turnDynamicOnImpulse", cr2w, this);
				}
				return _turnDynamicOnImpulse;
			}
			set
			{
				if (_turnDynamicOnImpulse == value)
				{
					return;
				}
				_turnDynamicOnImpulse = value;
				PropertySet(this);
			}
		}

		[Ordinal(1006)] 
		[RED("useAggregate")] 
		public CBool UseAggregate
		{
			get
			{
				if (_useAggregate == null)
				{
					_useAggregate = (CBool) CR2WTypeManager.Create("Bool", "useAggregate", cr2w, this);
				}
				return _useAggregate;
			}
			set
			{
				if (_useAggregate == value)
				{
					return;
				}
				_useAggregate = value;
				PropertySet(this);
			}
		}

		[Ordinal(1007)] 
		[RED("enableSelfCollisionInAggregate")] 
		public CBool EnableSelfCollisionInAggregate
		{
			get
			{
				if (_enableSelfCollisionInAggregate == null)
				{
					_enableSelfCollisionInAggregate = (CBool) CR2WTypeManager.Create("Bool", "enableSelfCollisionInAggregate", cr2w, this);
				}
				return _enableSelfCollisionInAggregate;
			}
			set
			{
				if (_enableSelfCollisionInAggregate == value)
				{
					return;
				}
				_enableSelfCollisionInAggregate = value;
				PropertySet(this);
			}
		}

		[Ordinal(1008)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get
			{
				if (_isDestructible == null)
				{
					_isDestructible = (CBool) CR2WTypeManager.Create("Bool", "isDestructible", cr2w, this);
				}
				return _isDestructible;
			}
			set
			{
				if (_isDestructible == value)
				{
					return;
				}
				_isDestructible = value;
				PropertySet(this);
			}
		}

		[Ordinal(1009)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get
			{
				if (_filterData == null)
				{
					_filterData = (CHandle<physicsFilterData>) CR2WTypeManager.Create("handle:physicsFilterData", "filterData", cr2w, this);
				}
				return _filterData;
			}
			set
			{
				if (_filterData == value)
				{
					return;
				}
				_filterData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1010)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get
			{
				if (_damageThreshold == null)
				{
					_damageThreshold = (CFloat) CR2WTypeManager.Create("Float", "damageThreshold", cr2w, this);
				}
				return _damageThreshold;
			}
			set
			{
				if (_damageThreshold == value)
				{
					return;
				}
				_damageThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(1011)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get
			{
				if (_damageEndurance == null)
				{
					_damageEndurance = (CFloat) CR2WTypeManager.Create("Float", "damageEndurance", cr2w, this);
				}
				return _damageEndurance;
			}
			set
			{
				if (_damageEndurance == value)
				{
					return;
				}
				_damageEndurance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1012)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get
			{
				if (_accumulateDamage == null)
				{
					_accumulateDamage = (CBool) CR2WTypeManager.Create("Bool", "accumulateDamage", cr2w, this);
				}
				return _accumulateDamage;
			}
			set
			{
				if (_accumulateDamage == value)
				{
					return;
				}
				_accumulateDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(1013)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get
			{
				if (_impulseToDamage == null)
				{
					_impulseToDamage = (CFloat) CR2WTypeManager.Create("Float", "impulseToDamage", cr2w, this);
				}
				return _impulseToDamage;
			}
			set
			{
				if (_impulseToDamage == value)
				{
					return;
				}
				_impulseToDamage = value;
				PropertySet(this);
			}
		}

		[Ordinal(1014)] 
		[RED("fracturingEffect")] 
		public raRef<worldEffect> FracturingEffect
		{
			get
			{
				if (_fracturingEffect == null)
				{
					_fracturingEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "fracturingEffect", cr2w, this);
				}
				return _fracturingEffect;
			}
			set
			{
				if (_fracturingEffect == value)
				{
					return;
				}
				_fracturingEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(1015)] 
		[RED("idleEffect")] 
		public raRef<worldEffect> IdleEffect
		{
			get
			{
				if (_idleEffect == null)
				{
					_idleEffect = (raRef<worldEffect>) CR2WTypeManager.Create("raRef:worldEffect", "idleEffect", cr2w, this);
				}
				return _idleEffect;
			}
			set
			{
				if (_idleEffect == value)
				{
					return;
				}
				_idleEffect = value;
				PropertySet(this);
			}
		}

		[Ordinal(1016)] 
		[RED("instanceTransforms")] 
		public CArray<Transform> InstanceTransforms
		{
			get
			{
				if (_instanceTransforms == null)
				{
					_instanceTransforms = (CArray<Transform>) CR2WTypeManager.Create("array:Transform", "instanceTransforms", cr2w, this);
				}
				return _instanceTransforms;
			}
			set
			{
				if (_instanceTransforms == value)
				{
					return;
				}
				_instanceTransforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(1017)] 
		[RED("cookedInstanceTransforms")] 
		public worldTransformBuffer CookedInstanceTransforms
		{
			get
			{
				if (_cookedInstanceTransforms == null)
				{
					_cookedInstanceTransforms = (worldTransformBuffer) CR2WTypeManager.Create("worldTransformBuffer", "cookedInstanceTransforms", cr2w, this);
				}
				return _cookedInstanceTransforms;
			}
			set
			{
				if (_cookedInstanceTransforms == value)
				{
					return;
				}
				_cookedInstanceTransforms = value;
				PropertySet(this);
			}
		}

		[Ordinal(1018)] 
		[RED("isPierceable")] 
		public CBool IsPierceable
		{
			get
			{
				if (_isPierceable == null)
				{
					_isPierceable = (CBool) CR2WTypeManager.Create("Bool", "isPierceable", cr2w, this);
				}
				return _isPierceable;
			}
			set
			{
				if (_isPierceable == value)
				{
					return;
				}
				_isPierceable = value;
				PropertySet(this);
			}
		}

		[Ordinal(1019)] 
		[RED("isWorkspot")] 
		public CBool IsWorkspot
		{
			get
			{
				if (_isWorkspot == null)
				{
					_isWorkspot = (CBool) CR2WTypeManager.Create("Bool", "isWorkspot", cr2w, this);
				}
				return _isWorkspot;
			}
			set
			{
				if (_isWorkspot == value)
				{
					return;
				}
				_isWorkspot = value;
				PropertySet(this);
			}
		}

		[Ordinal(1020)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get
			{
				if (_navigationSetting == null)
				{
					_navigationSetting = (NavGenNavigationSetting) CR2WTypeManager.Create("NavGenNavigationSetting", "navigationSetting", cr2w, this);
				}
				return _navigationSetting;
			}
			set
			{
				if (_navigationSetting == value)
				{
					return;
				}
				_navigationSetting = value;
				PropertySet(this);
			}
		}

		[Ordinal(1021)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get
			{
				if (_useMeshNavmeshSettings == null)
				{
					_useMeshNavmeshSettings = (CBool) CR2WTypeManager.Create("Bool", "useMeshNavmeshSettings", cr2w, this);
				}
				return _useMeshNavmeshSettings;
			}
			set
			{
				if (_useMeshNavmeshSettings == value)
				{
					return;
				}
				_useMeshNavmeshSettings = value;
				PropertySet(this);
			}
		}

		public worldInstancedDestructibleMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
