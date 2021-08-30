using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animRig : CResource
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
			get => GetProperty(ref _boneNames);
			set => SetProperty(ref _boneNames, value);
		}

		[Ordinal(2)] 
		[RED("trackNames")] 
		public CArray<CName> TrackNames
		{
			get => GetProperty(ref _trackNames);
			set => SetProperty(ref _trackNames, value);
		}

		[Ordinal(3)] 
		[RED("rigExtraTracks")] 
		public CArray<animFloatTrackInfo> RigExtraTracks
		{
			get => GetProperty(ref _rigExtraTracks);
			set => SetProperty(ref _rigExtraTracks, value);
		}

		[Ordinal(4)] 
		[RED("levelOfDetailStartIndices")] 
		public CArray<CInt16> LevelOfDetailStartIndices
		{
			get => GetProperty(ref _levelOfDetailStartIndices);
			set => SetProperty(ref _levelOfDetailStartIndices, value);
		}

		[Ordinal(5)] 
		[RED("distanceCategoryToLodMap")] 
		public CArray<CInt16> DistanceCategoryToLodMap
		{
			get => GetProperty(ref _distanceCategoryToLodMap);
			set => SetProperty(ref _distanceCategoryToLodMap, value);
		}

		[Ordinal(6)] 
		[RED("turnOffLOD")] 
		public CInt32 TurnOffLOD
		{
			get => GetProperty(ref _turnOffLOD);
			set => SetProperty(ref _turnOffLOD, value);
		}

		[Ordinal(7)] 
		[RED("turningOffUpdateAndSample")] 
		public CBool TurningOffUpdateAndSample
		{
			get => GetProperty(ref _turningOffUpdateAndSample);
			set => SetProperty(ref _turningOffUpdateAndSample, value);
		}

		[Ordinal(8)] 
		[RED("referenceTracks")] 
		public CArray<CFloat> ReferenceTracks
		{
			get => GetProperty(ref _referenceTracks);
			set => SetProperty(ref _referenceTracks, value);
		}

		[Ordinal(9)] 
		[RED("referencePoseMS")] 
		public CArray<QsTransform> ReferencePoseMS
		{
			get => GetProperty(ref _referencePoseMS);
			set => SetProperty(ref _referencePoseMS, value);
		}

		[Ordinal(10)] 
		[RED("aPoseLS")] 
		public CArray<QsTransform> APoseLS
		{
			get => GetProperty(ref _aPoseLS);
			set => SetProperty(ref _aPoseLS, value);
		}

		[Ordinal(11)] 
		[RED("aPoseMS")] 
		public CArray<QsTransform> APoseMS
		{
			get => GetProperty(ref _aPoseMS);
			set => SetProperty(ref _aPoseMS, value);
		}

		[Ordinal(12)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(13)] 
		[RED("parts")] 
		public CArray<animRigPart> Parts
		{
			get => GetProperty(ref _parts);
			set => SetProperty(ref _parts, value);
		}

		[Ordinal(14)] 
		[RED("retargets")] 
		public CArray<animRigRetarget> Retargets
		{
			get => GetProperty(ref _retargets);
			set => SetProperty(ref _retargets, value);
		}

		[Ordinal(15)] 
		[RED("ikSetups")] 
		public CArray<CHandle<animIRigIkSetup>> IkSetups
		{
			get => GetProperty(ref _ikSetups);
			set => SetProperty(ref _ikSetups, value);
		}

		[Ordinal(16)] 
		[RED("ragdollDesc")] 
		public CArray<physicsRagdollBodyInfo> RagdollDesc
		{
			get => GetProperty(ref _ragdollDesc);
			set => SetProperty(ref _ragdollDesc, value);
		}

		[Ordinal(17)] 
		[RED("ragdollNames")] 
		public CArray<physicsRagdollBodyNames> RagdollNames
		{
			get => GetProperty(ref _ragdollNames);
			set => SetProperty(ref _ragdollNames, value);
		}

		public animRig()
		{
			_turnOffLOD = -1;
		}
	}
}
