using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPropDef : CVariable
	{
		private scnPropId _propId;
		private CString _propName;
		private TweakDBID _specPropRecordId;
		private CArray<scnRidAnimSetSRRefId> _animSets;
		private CArray<scnCinematicAnimSetSRRefId> _cinematicAnimSets;
		private CArray<scnDynamicAnimSetSRRefId> _dynamicAnimSets;
		private CEnum<scnEntityAcquisitionPlan> _entityAcquisitionPlan;
		private scnFindEntityInEntityParams _findEntityInEntityParams;
		private scnSpawnDespawnEntityParams _spawnDespawnParams;
		private scnSpawnSetParams _spawnSetParams;
		private scnCommunityParams _communityParams;
		private scnSpawnerParams _spawnerParams;
		private scnFindEntityInNodeParams _findEntityInNodeParams;
		private scnFindEntityInWorldParams _findEntityInWorldParams;

		[Ordinal(0)] 
		[RED("propId")] 
		public scnPropId PropId
		{
			get
			{
				if (_propId == null)
				{
					_propId = (scnPropId) CR2WTypeManager.Create("scnPropId", "propId", cr2w, this);
				}
				return _propId;
			}
			set
			{
				if (_propId == value)
				{
					return;
				}
				_propId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("propName")] 
		public CString PropName
		{
			get
			{
				if (_propName == null)
				{
					_propName = (CString) CR2WTypeManager.Create("String", "propName", cr2w, this);
				}
				return _propName;
			}
			set
			{
				if (_propName == value)
				{
					return;
				}
				_propName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("specPropRecordId")] 
		public TweakDBID SpecPropRecordId
		{
			get
			{
				if (_specPropRecordId == null)
				{
					_specPropRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "specPropRecordId", cr2w, this);
				}
				return _specPropRecordId;
			}
			set
			{
				if (_specPropRecordId == value)
				{
					return;
				}
				_specPropRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("animSets")] 
		public CArray<scnRidAnimSetSRRefId> AnimSets
		{
			get
			{
				if (_animSets == null)
				{
					_animSets = (CArray<scnRidAnimSetSRRefId>) CR2WTypeManager.Create("array:scnRidAnimSetSRRefId", "animSets", cr2w, this);
				}
				return _animSets;
			}
			set
			{
				if (_animSets == value)
				{
					return;
				}
				_animSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("cinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> CinematicAnimSets
		{
			get
			{
				if (_cinematicAnimSets == null)
				{
					_cinematicAnimSets = (CArray<scnCinematicAnimSetSRRefId>) CR2WTypeManager.Create("array:scnCinematicAnimSetSRRefId", "cinematicAnimSets", cr2w, this);
				}
				return _cinematicAnimSets;
			}
			set
			{
				if (_cinematicAnimSets == value)
				{
					return;
				}
				_cinematicAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRefId> DynamicAnimSets
		{
			get
			{
				if (_dynamicAnimSets == null)
				{
					_dynamicAnimSets = (CArray<scnDynamicAnimSetSRRefId>) CR2WTypeManager.Create("array:scnDynamicAnimSetSRRefId", "dynamicAnimSets", cr2w, this);
				}
				return _dynamicAnimSets;
			}
			set
			{
				if (_dynamicAnimSets == value)
				{
					return;
				}
				_dynamicAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("entityAcquisitionPlan")] 
		public CEnum<scnEntityAcquisitionPlan> EntityAcquisitionPlan
		{
			get
			{
				if (_entityAcquisitionPlan == null)
				{
					_entityAcquisitionPlan = (CEnum<scnEntityAcquisitionPlan>) CR2WTypeManager.Create("scnEntityAcquisitionPlan", "entityAcquisitionPlan", cr2w, this);
				}
				return _entityAcquisitionPlan;
			}
			set
			{
				if (_entityAcquisitionPlan == value)
				{
					return;
				}
				_entityAcquisitionPlan = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("findEntityInEntityParams")] 
		public scnFindEntityInEntityParams FindEntityInEntityParams
		{
			get
			{
				if (_findEntityInEntityParams == null)
				{
					_findEntityInEntityParams = (scnFindEntityInEntityParams) CR2WTypeManager.Create("scnFindEntityInEntityParams", "findEntityInEntityParams", cr2w, this);
				}
				return _findEntityInEntityParams;
			}
			set
			{
				if (_findEntityInEntityParams == value)
				{
					return;
				}
				_findEntityInEntityParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("spawnDespawnParams")] 
		public scnSpawnDespawnEntityParams SpawnDespawnParams
		{
			get
			{
				if (_spawnDespawnParams == null)
				{
					_spawnDespawnParams = (scnSpawnDespawnEntityParams) CR2WTypeManager.Create("scnSpawnDespawnEntityParams", "spawnDespawnParams", cr2w, this);
				}
				return _spawnDespawnParams;
			}
			set
			{
				if (_spawnDespawnParams == value)
				{
					return;
				}
				_spawnDespawnParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("spawnSetParams")] 
		public scnSpawnSetParams SpawnSetParams
		{
			get
			{
				if (_spawnSetParams == null)
				{
					_spawnSetParams = (scnSpawnSetParams) CR2WTypeManager.Create("scnSpawnSetParams", "spawnSetParams", cr2w, this);
				}
				return _spawnSetParams;
			}
			set
			{
				if (_spawnSetParams == value)
				{
					return;
				}
				_spawnSetParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("communityParams")] 
		public scnCommunityParams CommunityParams
		{
			get
			{
				if (_communityParams == null)
				{
					_communityParams = (scnCommunityParams) CR2WTypeManager.Create("scnCommunityParams", "communityParams", cr2w, this);
				}
				return _communityParams;
			}
			set
			{
				if (_communityParams == value)
				{
					return;
				}
				_communityParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("spawnerParams")] 
		public scnSpawnerParams SpawnerParams
		{
			get
			{
				if (_spawnerParams == null)
				{
					_spawnerParams = (scnSpawnerParams) CR2WTypeManager.Create("scnSpawnerParams", "spawnerParams", cr2w, this);
				}
				return _spawnerParams;
			}
			set
			{
				if (_spawnerParams == value)
				{
					return;
				}
				_spawnerParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("findEntityInNodeParams")] 
		public scnFindEntityInNodeParams FindEntityInNodeParams
		{
			get
			{
				if (_findEntityInNodeParams == null)
				{
					_findEntityInNodeParams = (scnFindEntityInNodeParams) CR2WTypeManager.Create("scnFindEntityInNodeParams", "findEntityInNodeParams", cr2w, this);
				}
				return _findEntityInNodeParams;
			}
			set
			{
				if (_findEntityInNodeParams == value)
				{
					return;
				}
				_findEntityInNodeParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("findEntityInWorldParams")] 
		public scnFindEntityInWorldParams FindEntityInWorldParams
		{
			get
			{
				if (_findEntityInWorldParams == null)
				{
					_findEntityInWorldParams = (scnFindEntityInWorldParams) CR2WTypeManager.Create("scnFindEntityInWorldParams", "findEntityInWorldParams", cr2w, this);
				}
				return _findEntityInWorldParams;
			}
			set
			{
				if (_findEntityInWorldParams == value)
				{
					return;
				}
				_findEntityInWorldParams = value;
				PropertySet(this);
			}
		}

		public scnPropDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
