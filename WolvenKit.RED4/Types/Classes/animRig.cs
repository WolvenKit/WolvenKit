using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animRig : CResource
	{
		[Ordinal(1)] 
		[RED("boneNames")] 
		public CArray<CName> BoneNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("trackNames")] 
		public CArray<CName> TrackNames
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("rigExtraTracks")] 
		public CArray<animFloatTrackInfo> RigExtraTracks
		{
			get => GetPropertyValue<CArray<animFloatTrackInfo>>();
			set => SetPropertyValue<CArray<animFloatTrackInfo>>(value);
		}

		[Ordinal(4)] 
		[RED("levelOfDetailStartIndices")] 
		public CArray<CInt16> LevelOfDetailStartIndices
		{
			get => GetPropertyValue<CArray<CInt16>>();
			set => SetPropertyValue<CArray<CInt16>>(value);
		}

		[Ordinal(5)] 
		[RED("distanceCategoryToLodMap")] 
		public CArray<CInt16> DistanceCategoryToLodMap
		{
			get => GetPropertyValue<CArray<CInt16>>();
			set => SetPropertyValue<CArray<CInt16>>(value);
		}

		[Ordinal(6)] 
		[RED("turnOffLOD")] 
		public CInt32 TurnOffLOD
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("turningOffUpdateAndSample")] 
		public CBool TurningOffUpdateAndSample
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("referenceTracks")] 
		public CArray<CFloat> ReferenceTracks
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(9)] 
		[RED("referencePoseMS")] 
		public CArray<QsTransform> ReferencePoseMS
		{
			get => GetPropertyValue<CArray<QsTransform>>();
			set => SetPropertyValue<CArray<QsTransform>>(value);
		}

		[Ordinal(10)] 
		[RED("aPoseLS")] 
		public CArray<QsTransform> APoseLS
		{
			get => GetPropertyValue<CArray<QsTransform>>();
			set => SetPropertyValue<CArray<QsTransform>>(value);
		}

		[Ordinal(11)] 
		[RED("aPoseMS")] 
		public CArray<QsTransform> APoseMS
		{
			get => GetPropertyValue<CArray<QsTransform>>();
			set => SetPropertyValue<CArray<QsTransform>>(value);
		}

		[Ordinal(12)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(13)] 
		[RED("parts")] 
		public CArray<animRigPart> Parts
		{
			get => GetPropertyValue<CArray<animRigPart>>();
			set => SetPropertyValue<CArray<animRigPart>>(value);
		}

		[Ordinal(14)] 
		[RED("retargets")] 
		public CArray<animRigRetarget> Retargets
		{
			get => GetPropertyValue<CArray<animRigRetarget>>();
			set => SetPropertyValue<CArray<animRigRetarget>>(value);
		}

		[Ordinal(15)] 
		[RED("ikSetups")] 
		public CArray<CHandle<animIRigIkSetup>> IkSetups
		{
			get => GetPropertyValue<CArray<CHandle<animIRigIkSetup>>>();
			set => SetPropertyValue<CArray<CHandle<animIRigIkSetup>>>(value);
		}

		[Ordinal(16)] 
		[RED("ragdollDesc")] 
		public CArray<physicsRagdollBodyInfo> RagdollDesc
		{
			get => GetPropertyValue<CArray<physicsRagdollBodyInfo>>();
			set => SetPropertyValue<CArray<physicsRagdollBodyInfo>>(value);
		}

		[Ordinal(17)] 
		[RED("ragdollNames")] 
		public CArray<physicsRagdollBodyNames> RagdollNames
		{
			get => GetPropertyValue<CArray<physicsRagdollBodyNames>>();
			set => SetPropertyValue<CArray<physicsRagdollBodyNames>>(value);
		}

		public animRig()
		{
			BoneNames = new();
			TrackNames = new();
			RigExtraTracks = new();
			LevelOfDetailStartIndices = new();
			DistanceCategoryToLodMap = new();
			TurnOffLOD = -1;
			ReferenceTracks = new();
			ReferencePoseMS = new();
			APoseLS = new();
			APoseMS = new();
			Tags = new() { Tags = new() };
			Parts = new();
			Retargets = new();
			IkSetups = new();
			RagdollDesc = new();
			RagdollNames = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
