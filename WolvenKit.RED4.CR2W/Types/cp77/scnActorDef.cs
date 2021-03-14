using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnActorDef : CVariable
	{
		private scnActorId _actorId;
		private scnVoicetagId _voicetagId;
		private CEnum<scnEntityAcquisitionPlan> _acquisitionPlan;
		private scnFindEntityInContextParams _findActorInContextParams;
		private scnFindEntityInWorldParams _findActorInWorldParams;
		private scnSpawnDespawnEntityParams _spawnDespawnParams;
		private scnSpawnSetParams _spawnSetParams;
		private scnCommunityParams _communityParams;
		private scnSpawnerParams _spawnerParams;
		private CArray<scnSRRefId> _animSets;
		private scnLipsyncAnimSetSRRefId _lipsyncAnimSet;
		private CArray<scnRidFacialAnimSetSRRefId> _facialAnimSets;
		private CArray<scnRidCyberwareAnimSetSRRefId> _cyberwareAnimSets;
		private CArray<scnRidDeformationAnimSetSRRefId> _deformationAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _bodyCinematicAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _facialCinematicAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _cyberwareCinematicAnimSets;
		private CArray<scnDynamicAnimSetSRRefId> _dynamicAnimSets;
		private CString _actorName;
		private TweakDBID _specCharacterRecordId;
		private CName _specAppearance;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get
			{
				if (_actorId == null)
				{
					_actorId = (scnActorId) CR2WTypeManager.Create("scnActorId", "actorId", cr2w, this);
				}
				return _actorId;
			}
			set
			{
				if (_actorId == value)
				{
					return;
				}
				_actorId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("voicetagId")] 
		public scnVoicetagId VoicetagId
		{
			get
			{
				if (_voicetagId == null)
				{
					_voicetagId = (scnVoicetagId) CR2WTypeManager.Create("scnVoicetagId", "voicetagId", cr2w, this);
				}
				return _voicetagId;
			}
			set
			{
				if (_voicetagId == value)
				{
					return;
				}
				_voicetagId = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("acquisitionPlan")] 
		public CEnum<scnEntityAcquisitionPlan> AcquisitionPlan
		{
			get
			{
				if (_acquisitionPlan == null)
				{
					_acquisitionPlan = (CEnum<scnEntityAcquisitionPlan>) CR2WTypeManager.Create("scnEntityAcquisitionPlan", "acquisitionPlan", cr2w, this);
				}
				return _acquisitionPlan;
			}
			set
			{
				if (_acquisitionPlan == value)
				{
					return;
				}
				_acquisitionPlan = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("findActorInContextParams")] 
		public scnFindEntityInContextParams FindActorInContextParams
		{
			get
			{
				if (_findActorInContextParams == null)
				{
					_findActorInContextParams = (scnFindEntityInContextParams) CR2WTypeManager.Create("scnFindEntityInContextParams", "findActorInContextParams", cr2w, this);
				}
				return _findActorInContextParams;
			}
			set
			{
				if (_findActorInContextParams == value)
				{
					return;
				}
				_findActorInContextParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("findActorInWorldParams")] 
		public scnFindEntityInWorldParams FindActorInWorldParams
		{
			get
			{
				if (_findActorInWorldParams == null)
				{
					_findActorInWorldParams = (scnFindEntityInWorldParams) CR2WTypeManager.Create("scnFindEntityInWorldParams", "findActorInWorldParams", cr2w, this);
				}
				return _findActorInWorldParams;
			}
			set
			{
				if (_findActorInWorldParams == value)
				{
					return;
				}
				_findActorInWorldParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
		[RED("animSets")] 
		public CArray<scnSRRefId> AnimSets
		{
			get
			{
				if (_animSets == null)
				{
					_animSets = (CArray<scnSRRefId>) CR2WTypeManager.Create("array:scnSRRefId", "animSets", cr2w, this);
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

		[Ordinal(10)] 
		[RED("lipsyncAnimSet")] 
		public scnLipsyncAnimSetSRRefId LipsyncAnimSet
		{
			get
			{
				if (_lipsyncAnimSet == null)
				{
					_lipsyncAnimSet = (scnLipsyncAnimSetSRRefId) CR2WTypeManager.Create("scnLipsyncAnimSetSRRefId", "lipsyncAnimSet", cr2w, this);
				}
				return _lipsyncAnimSet;
			}
			set
			{
				if (_lipsyncAnimSet == value)
				{
					return;
				}
				_lipsyncAnimSet = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("facialAnimSets")] 
		public CArray<scnRidFacialAnimSetSRRefId> FacialAnimSets
		{
			get
			{
				if (_facialAnimSets == null)
				{
					_facialAnimSets = (CArray<scnRidFacialAnimSetSRRefId>) CR2WTypeManager.Create("array:scnRidFacialAnimSetSRRefId", "facialAnimSets", cr2w, this);
				}
				return _facialAnimSets;
			}
			set
			{
				if (_facialAnimSets == value)
				{
					return;
				}
				_facialAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("cyberwareAnimSets")] 
		public CArray<scnRidCyberwareAnimSetSRRefId> CyberwareAnimSets
		{
			get
			{
				if (_cyberwareAnimSets == null)
				{
					_cyberwareAnimSets = (CArray<scnRidCyberwareAnimSetSRRefId>) CR2WTypeManager.Create("array:scnRidCyberwareAnimSetSRRefId", "cyberwareAnimSets", cr2w, this);
				}
				return _cyberwareAnimSets;
			}
			set
			{
				if (_cyberwareAnimSets == value)
				{
					return;
				}
				_cyberwareAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("deformationAnimSets")] 
		public CArray<scnRidDeformationAnimSetSRRefId> DeformationAnimSets
		{
			get
			{
				if (_deformationAnimSets == null)
				{
					_deformationAnimSets = (CArray<scnRidDeformationAnimSetSRRefId>) CR2WTypeManager.Create("array:scnRidDeformationAnimSetSRRefId", "deformationAnimSets", cr2w, this);
				}
				return _deformationAnimSets;
			}
			set
			{
				if (_deformationAnimSets == value)
				{
					return;
				}
				_deformationAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("bodyCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> BodyCinematicAnimSets
		{
			get
			{
				if (_bodyCinematicAnimSets == null)
				{
					_bodyCinematicAnimSets = (CArray<scnCinematicAnimSetSRRefId>) CR2WTypeManager.Create("array:scnCinematicAnimSetSRRefId", "bodyCinematicAnimSets", cr2w, this);
				}
				return _bodyCinematicAnimSets;
			}
			set
			{
				if (_bodyCinematicAnimSets == value)
				{
					return;
				}
				_bodyCinematicAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("facialCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> FacialCinematicAnimSets
		{
			get
			{
				if (_facialCinematicAnimSets == null)
				{
					_facialCinematicAnimSets = (CArray<scnCinematicAnimSetSRRefId>) CR2WTypeManager.Create("array:scnCinematicAnimSetSRRefId", "facialCinematicAnimSets", cr2w, this);
				}
				return _facialCinematicAnimSets;
			}
			set
			{
				if (_facialCinematicAnimSets == value)
				{
					return;
				}
				_facialCinematicAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("cyberwareCinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRefId> CyberwareCinematicAnimSets
		{
			get
			{
				if (_cyberwareCinematicAnimSets == null)
				{
					_cyberwareCinematicAnimSets = (CArray<scnCinematicAnimSetSRRefId>) CR2WTypeManager.Create("array:scnCinematicAnimSetSRRefId", "cyberwareCinematicAnimSets", cr2w, this);
				}
				return _cyberwareCinematicAnimSets;
			}
			set
			{
				if (_cyberwareCinematicAnimSets == value)
				{
					return;
				}
				_cyberwareCinematicAnimSets = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
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

		[Ordinal(18)] 
		[RED("actorName")] 
		public CString ActorName
		{
			get
			{
				if (_actorName == null)
				{
					_actorName = (CString) CR2WTypeManager.Create("String", "actorName", cr2w, this);
				}
				return _actorName;
			}
			set
			{
				if (_actorName == value)
				{
					return;
				}
				_actorName = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("specCharacterRecordId")] 
		public TweakDBID SpecCharacterRecordId
		{
			get
			{
				if (_specCharacterRecordId == null)
				{
					_specCharacterRecordId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "specCharacterRecordId", cr2w, this);
				}
				return _specCharacterRecordId;
			}
			set
			{
				if (_specCharacterRecordId == value)
				{
					return;
				}
				_specCharacterRecordId = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("specAppearance")] 
		public CName SpecAppearance
		{
			get
			{
				if (_specAppearance == null)
				{
					_specAppearance = (CName) CR2WTypeManager.Create("CName", "specAppearance", cr2w, this);
				}
				return _specAppearance;
			}
			set
			{
				if (_specAppearance == value)
				{
					return;
				}
				_specAppearance = value;
				PropertySet(this);
			}
		}

		public scnActorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
