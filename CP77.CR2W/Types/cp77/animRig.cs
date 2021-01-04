using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animRig : CResource
	{
		[Ordinal(0)]  [RED("aPoseLS")] public CArray<QsTransform> APoseLS { get; set; }
		[Ordinal(1)]  [RED("aPoseMS")] public CArray<QsTransform> APoseMS { get; set; }
		[Ordinal(2)]  [RED("boneNames")] public CArray<CName> BoneNames { get; set; }
		[Ordinal(3)]  [RED("distanceCategoryToLodMap")] public CArray<CInt16> DistanceCategoryToLodMap { get; set; }
		[Ordinal(4)]  [RED("ikSetups")] public CArray<CHandle<animIRigIkSetup>> IkSetups { get; set; }
		[Ordinal(5)]  [RED("levelOfDetailStartIndices")] public CArray<CInt16> LevelOfDetailStartIndices { get; set; }
		[Ordinal(6)]  [RED("parts")] public CArray<animRigPart> Parts { get; set; }
		[Ordinal(7)]  [RED("ragdollDesc")] public CArray<physicsRagdollBodyInfo> RagdollDesc { get; set; }
		[Ordinal(8)]  [RED("ragdollNames")] public CArray<physicsRagdollBodyNames> RagdollNames { get; set; }
		[Ordinal(9)]  [RED("referencePoseMS")] public CArray<QsTransform> ReferencePoseMS { get; set; }
		[Ordinal(10)]  [RED("referenceTracks")] public CArray<CFloat> ReferenceTracks { get; set; }
		[Ordinal(11)]  [RED("retargets")] public CArray<animRigRetarget> Retargets { get; set; }
		[Ordinal(12)]  [RED("rigExtraTracks")] public CArray<animFloatTrackInfo> RigExtraTracks { get; set; }
		[Ordinal(13)]  [RED("tags")] public redTagList Tags { get; set; }
		[Ordinal(14)]  [RED("trackNames")] public CArray<CName> TrackNames { get; set; }
		[Ordinal(15)]  [RED("turnOffLOD")] public CInt32 TurnOffLOD { get; set; }
		[Ordinal(16)]  [RED("turningOffUpdateAndSample")] public CBool TurningOffUpdateAndSample { get; set; }

		public animRig(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
