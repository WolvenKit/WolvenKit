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
			get => GetProperty(ref _staticMesh);
			set => SetProperty(ref _staticMesh, value);
		}

		[Ordinal(1001)] 
		[RED("staticMeshAppearance")] 
		public CName StaticMeshAppearance
		{
			get => GetProperty(ref _staticMeshAppearance);
			set => SetProperty(ref _staticMeshAppearance, value);
		}

		[Ordinal(1002)] 
		[RED("simulationType")] 
		public CEnum<physicsSimulationType> SimulationType
		{
			get => GetProperty(ref _simulationType);
			set => SetProperty(ref _simulationType, value);
		}

		[Ordinal(1003)] 
		[RED("filterDataSource")] 
		public CEnum<physicsFilterDataSource> FilterDataSource
		{
			get => GetProperty(ref _filterDataSource);
			set => SetProperty(ref _filterDataSource, value);
		}

		[Ordinal(1004)] 
		[RED("startInactive")] 
		public CBool StartInactive
		{
			get => GetProperty(ref _startInactive);
			set => SetProperty(ref _startInactive, value);
		}

		[Ordinal(1005)] 
		[RED("turnDynamicOnImpulse")] 
		public CBool TurnDynamicOnImpulse
		{
			get => GetProperty(ref _turnDynamicOnImpulse);
			set => SetProperty(ref _turnDynamicOnImpulse, value);
		}

		[Ordinal(1006)] 
		[RED("useAggregate")] 
		public CBool UseAggregate
		{
			get => GetProperty(ref _useAggregate);
			set => SetProperty(ref _useAggregate, value);
		}

		[Ordinal(1007)] 
		[RED("enableSelfCollisionInAggregate")] 
		public CBool EnableSelfCollisionInAggregate
		{
			get => GetProperty(ref _enableSelfCollisionInAggregate);
			set => SetProperty(ref _enableSelfCollisionInAggregate, value);
		}

		[Ordinal(1008)] 
		[RED("isDestructible")] 
		public CBool IsDestructible
		{
			get => GetProperty(ref _isDestructible);
			set => SetProperty(ref _isDestructible, value);
		}

		[Ordinal(1009)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(1010)] 
		[RED("damageThreshold")] 
		public CFloat DamageThreshold
		{
			get => GetProperty(ref _damageThreshold);
			set => SetProperty(ref _damageThreshold, value);
		}

		[Ordinal(1011)] 
		[RED("damageEndurance")] 
		public CFloat DamageEndurance
		{
			get => GetProperty(ref _damageEndurance);
			set => SetProperty(ref _damageEndurance, value);
		}

		[Ordinal(1012)] 
		[RED("accumulateDamage")] 
		public CBool AccumulateDamage
		{
			get => GetProperty(ref _accumulateDamage);
			set => SetProperty(ref _accumulateDamage, value);
		}

		[Ordinal(1013)] 
		[RED("impulseToDamage")] 
		public CFloat ImpulseToDamage
		{
			get => GetProperty(ref _impulseToDamage);
			set => SetProperty(ref _impulseToDamage, value);
		}

		[Ordinal(1014)] 
		[RED("fracturingEffect")] 
		public raRef<worldEffect> FracturingEffect
		{
			get => GetProperty(ref _fracturingEffect);
			set => SetProperty(ref _fracturingEffect, value);
		}

		[Ordinal(1015)] 
		[RED("idleEffect")] 
		public raRef<worldEffect> IdleEffect
		{
			get => GetProperty(ref _idleEffect);
			set => SetProperty(ref _idleEffect, value);
		}

		[Ordinal(1016)] 
		[RED("instanceTransforms")] 
		public CArray<Transform> InstanceTransforms
		{
			get => GetProperty(ref _instanceTransforms);
			set => SetProperty(ref _instanceTransforms, value);
		}

		[Ordinal(1017)] 
		[RED("cookedInstanceTransforms")] 
		public worldTransformBuffer CookedInstanceTransforms
		{
			get => GetProperty(ref _cookedInstanceTransforms);
			set => SetProperty(ref _cookedInstanceTransforms, value);
		}

		[Ordinal(1018)] 
		[RED("isPierceable")] 
		public CBool IsPierceable
		{
			get => GetProperty(ref _isPierceable);
			set => SetProperty(ref _isPierceable, value);
		}

		[Ordinal(1019)] 
		[RED("isWorkspot")] 
		public CBool IsWorkspot
		{
			get => GetProperty(ref _isWorkspot);
			set => SetProperty(ref _isWorkspot, value);
		}

		[Ordinal(1020)] 
		[RED("navigationSetting")] 
		public NavGenNavigationSetting NavigationSetting
		{
			get => GetProperty(ref _navigationSetting);
			set => SetProperty(ref _navigationSetting, value);
		}

		[Ordinal(1021)] 
		[RED("useMeshNavmeshSettings")] 
		public CBool UseMeshNavmeshSettings
		{
			get => GetProperty(ref _useMeshNavmeshSettings);
			set => SetProperty(ref _useMeshNavmeshSettings, value);
		}

		public worldInstancedDestructibleMeshNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
