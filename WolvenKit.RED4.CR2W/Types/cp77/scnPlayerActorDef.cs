using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnPlayerActorDef : CVariable
	{
		private scnActorId _actorId;
		private CName _specTemplate;
		private TweakDBID _specCharacterRecordId;
		private CName _specAppearance;
		private scnVoicetagId _voicetagId;
		private CArray<scnSRRefId> _animSets;
		private scnLipsyncAnimSetSRRefId _lipsyncAnimSet;
		private CArray<scnRidFacialAnimSetSRRefId> _facialAnimSets;
		private CArray<scnRidCyberwareAnimSetSRRefId> _cyberwareAnimSets;
		private CArray<scnRidDeformationAnimSetSRRefId> _deformationAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _bodyCinematicAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _facialCinematicAnimSets;
		private CArray<scnCinematicAnimSetSRRefId> _cyberwareCinematicAnimSets;
		private CArray<scnDynamicAnimSetSRRefId> _dynamicAnimSets;
		private CEnum<scnEntityAcquisitionPlan> _acquisitionPlan;
		private scnFindNetworkPlayerParams _findNetworkPlayerParams;
		private scnFindEntityInContextParams _findActorInContextParams;
		private CString _playerName;

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
		[RED("specTemplate")] 
		public CName SpecTemplate
		{
			get
			{
				if (_specTemplate == null)
				{
					_specTemplate = (CName) CR2WTypeManager.Create("CName", "specTemplate", cr2w, this);
				}
				return _specTemplate;
			}
			set
			{
				if (_specTemplate == value)
				{
					return;
				}
				_specTemplate = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
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

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
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

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("findNetworkPlayerParams")] 
		public scnFindNetworkPlayerParams FindNetworkPlayerParams
		{
			get
			{
				if (_findNetworkPlayerParams == null)
				{
					_findNetworkPlayerParams = (scnFindNetworkPlayerParams) CR2WTypeManager.Create("scnFindNetworkPlayerParams", "findNetworkPlayerParams", cr2w, this);
				}
				return _findNetworkPlayerParams;
			}
			set
			{
				if (_findNetworkPlayerParams == value)
				{
					return;
				}
				_findNetworkPlayerParams = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		[Ordinal(17)] 
		[RED("playerName")] 
		public CString PlayerName
		{
			get
			{
				if (_playerName == null)
				{
					_playerName = (CString) CR2WTypeManager.Create("String", "playerName", cr2w, this);
				}
				return _playerName;
			}
			set
			{
				if (_playerName == value)
				{
					return;
				}
				_playerName = value;
				PropertySet(this);
			}
		}

		public scnPlayerActorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
