using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animRig_ : CResource
	{
		private CArray<CName> _boneNames;
		private CArray<CName> _trackNames;
		private CArray<animFloatTrackInfo> _rigExtraTracks;
		private CArray<CInt16> _levelOfDetailStartIndices;
		private CArray<CInt16> _distanceCategoryToLodMap;
		private CInt32 _turnOffLOD;
		private CBool _turningOffUpdateAndSample;
		private CArray<CFloat> _referenceTracks;
		private CArray<QsTransform> _referencePoseMS;
		private CArray<QsTransform> _aPoseLS;
		private CArray<QsTransform> _aPoseMS;
		private redTagList _tags;
		private CArray<animRigPart> _parts;
		private CArray<animRigRetarget> _retargets;
		private CArray<CHandle<animIRigIkSetup>> _ikSetups;
		private CArray<physicsRagdollBodyInfo> _ragdollDesc;
		private CArray<physicsRagdollBodyNames> _ragdollNames;

		[Ordinal(1)] 
		[RED("boneNames")] 
		public CArray<CName> BoneNames
		{
			get
			{
				if (_boneNames == null)
				{
					_boneNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "boneNames", cr2w, this);
				}
				return _boneNames;
			}
			set
			{
				if (_boneNames == value)
				{
					return;
				}
				_boneNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("trackNames")] 
		public CArray<CName> TrackNames
		{
			get
			{
				if (_trackNames == null)
				{
					_trackNames = (CArray<CName>) CR2WTypeManager.Create("array:CName", "trackNames", cr2w, this);
				}
				return _trackNames;
			}
			set
			{
				if (_trackNames == value)
				{
					return;
				}
				_trackNames = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rigExtraTracks")] 
		public CArray<animFloatTrackInfo> RigExtraTracks
		{
			get
			{
				if (_rigExtraTracks == null)
				{
					_rigExtraTracks = (CArray<animFloatTrackInfo>) CR2WTypeManager.Create("array:animFloatTrackInfo", "rigExtraTracks", cr2w, this);
				}
				return _rigExtraTracks;
			}
			set
			{
				if (_rigExtraTracks == value)
				{
					return;
				}
				_rigExtraTracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("levelOfDetailStartIndices")] 
		public CArray<CInt16> LevelOfDetailStartIndices
		{
			get
			{
				if (_levelOfDetailStartIndices == null)
				{
					_levelOfDetailStartIndices = (CArray<CInt16>) CR2WTypeManager.Create("array:Int16", "levelOfDetailStartIndices", cr2w, this);
				}
				return _levelOfDetailStartIndices;
			}
			set
			{
				if (_levelOfDetailStartIndices == value)
				{
					return;
				}
				_levelOfDetailStartIndices = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("distanceCategoryToLodMap")] 
		public CArray<CInt16> DistanceCategoryToLodMap
		{
			get
			{
				if (_distanceCategoryToLodMap == null)
				{
					_distanceCategoryToLodMap = (CArray<CInt16>) CR2WTypeManager.Create("array:Int16", "distanceCategoryToLodMap", cr2w, this);
				}
				return _distanceCategoryToLodMap;
			}
			set
			{
				if (_distanceCategoryToLodMap == value)
				{
					return;
				}
				_distanceCategoryToLodMap = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("turnOffLOD")] 
		public CInt32 TurnOffLOD
		{
			get
			{
				if (_turnOffLOD == null)
				{
					_turnOffLOD = (CInt32) CR2WTypeManager.Create("Int32", "turnOffLOD", cr2w, this);
				}
				return _turnOffLOD;
			}
			set
			{
				if (_turnOffLOD == value)
				{
					return;
				}
				_turnOffLOD = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("turningOffUpdateAndSample")] 
		public CBool TurningOffUpdateAndSample
		{
			get
			{
				if (_turningOffUpdateAndSample == null)
				{
					_turningOffUpdateAndSample = (CBool) CR2WTypeManager.Create("Bool", "turningOffUpdateAndSample", cr2w, this);
				}
				return _turningOffUpdateAndSample;
			}
			set
			{
				if (_turningOffUpdateAndSample == value)
				{
					return;
				}
				_turningOffUpdateAndSample = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("referenceTracks")] 
		public CArray<CFloat> ReferenceTracks
		{
			get
			{
				if (_referenceTracks == null)
				{
					_referenceTracks = (CArray<CFloat>) CR2WTypeManager.Create("array:Float", "referenceTracks", cr2w, this);
				}
				return _referenceTracks;
			}
			set
			{
				if (_referenceTracks == value)
				{
					return;
				}
				_referenceTracks = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("referencePoseMS")] 
		public CArray<QsTransform> ReferencePoseMS
		{
			get
			{
				if (_referencePoseMS == null)
				{
					_referencePoseMS = (CArray<QsTransform>) CR2WTypeManager.Create("array:QsTransform", "referencePoseMS", cr2w, this);
				}
				return _referencePoseMS;
			}
			set
			{
				if (_referencePoseMS == value)
				{
					return;
				}
				_referencePoseMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("aPoseLS")] 
		public CArray<QsTransform> APoseLS
		{
			get
			{
				if (_aPoseLS == null)
				{
					_aPoseLS = (CArray<QsTransform>) CR2WTypeManager.Create("array:QsTransform", "aPoseLS", cr2w, this);
				}
				return _aPoseLS;
			}
			set
			{
				if (_aPoseLS == value)
				{
					return;
				}
				_aPoseLS = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("aPoseMS")] 
		public CArray<QsTransform> APoseMS
		{
			get
			{
				if (_aPoseMS == null)
				{
					_aPoseMS = (CArray<QsTransform>) CR2WTypeManager.Create("array:QsTransform", "aPoseMS", cr2w, this);
				}
				return _aPoseMS;
			}
			set
			{
				if (_aPoseMS == value)
				{
					return;
				}
				_aPoseMS = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get
			{
				if (_tags == null)
				{
					_tags = (redTagList) CR2WTypeManager.Create("redTagList", "tags", cr2w, this);
				}
				return _tags;
			}
			set
			{
				if (_tags == value)
				{
					return;
				}
				_tags = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("parts")] 
		public CArray<animRigPart> Parts
		{
			get
			{
				if (_parts == null)
				{
					_parts = (CArray<animRigPart>) CR2WTypeManager.Create("array:animRigPart", "parts", cr2w, this);
				}
				return _parts;
			}
			set
			{
				if (_parts == value)
				{
					return;
				}
				_parts = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("retargets")] 
		public CArray<animRigRetarget> Retargets
		{
			get
			{
				if (_retargets == null)
				{
					_retargets = (CArray<animRigRetarget>) CR2WTypeManager.Create("array:animRigRetarget", "retargets", cr2w, this);
				}
				return _retargets;
			}
			set
			{
				if (_retargets == value)
				{
					return;
				}
				_retargets = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("ikSetups")] 
		public CArray<CHandle<animIRigIkSetup>> IkSetups
		{
			get
			{
				if (_ikSetups == null)
				{
					_ikSetups = (CArray<CHandle<animIRigIkSetup>>) CR2WTypeManager.Create("array:handle:animIRigIkSetup", "ikSetups", cr2w, this);
				}
				return _ikSetups;
			}
			set
			{
				if (_ikSetups == value)
				{
					return;
				}
				_ikSetups = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("ragdollDesc")] 
		public CArray<physicsRagdollBodyInfo> RagdollDesc
		{
			get
			{
				if (_ragdollDesc == null)
				{
					_ragdollDesc = (CArray<physicsRagdollBodyInfo>) CR2WTypeManager.Create("array:physicsRagdollBodyInfo", "ragdollDesc", cr2w, this);
				}
				return _ragdollDesc;
			}
			set
			{
				if (_ragdollDesc == value)
				{
					return;
				}
				_ragdollDesc = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("ragdollNames")] 
		public CArray<physicsRagdollBodyNames> RagdollNames
		{
			get
			{
				if (_ragdollNames == null)
				{
					_ragdollNames = (CArray<physicsRagdollBodyNames>) CR2WTypeManager.Create("array:physicsRagdollBodyNames", "ragdollNames", cr2w, this);
				}
				return _ragdollNames;
			}
			set
			{
				if (_ragdollNames == value)
				{
					return;
				}
				_ragdollNames = value;
				PropertySet(this);
			}
		}

		public animRig_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
