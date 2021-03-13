using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventAnimation : CStorySceneEventAnimClip
	{
		[Ordinal(1)] [RED("animationName")] 		public CName AnimationName { get; set;}

		[Ordinal(2)] [RED("useMotionExtraction")] 		public CBool UseMotionExtraction { get; set;}

		[Ordinal(3)] [RED("useFakeMotion")] 		public CBool UseFakeMotion { get; set;}

		[Ordinal(4)] [RED("gatherSyncTokens")] 		public CBool GatherSyncTokens { get; set;}

		[Ordinal(5)] [RED("muteSoundEvents")] 		public CBool MuteSoundEvents { get; set;}

		[Ordinal(6)] [RED("disableLookAt")] 		public CBool DisableLookAt { get; set;}

		[Ordinal(7)] [RED("disableLookAtSpeed")] 		public CFloat DisableLookAtSpeed { get; set;}

		[Ordinal(8)] [RED("useLowerBodyPartsForLookAt")] 		public CBool UseLowerBodyPartsForLookAt { get; set;}

		[Ordinal(9)] [RED("bonesGroupName")] 		public CString BonesGroupName { get; set;}

		[Ordinal(10)] [RED("bones", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Bones { get; set;}

		[Ordinal(11)] [RED("bonesIdx", 2,0)] 		public CArray<CInt32> BonesIdx { get; set;}

		[Ordinal(12)] [RED("bonesWeight", 2,0)] 		public CArray<CFloat> BonesWeight { get; set;}

		[Ordinal(13)] [RED("status")] 		public CName Status { get; set;}

		[Ordinal(14)] [RED("emotionalState")] 		public CName EmotionalState { get; set;}

		[Ordinal(15)] [RED("poseName")] 		public CName PoseName { get; set;}

		[Ordinal(16)] [RED("typeName")] 		public CName TypeName { get; set;}

		[Ordinal(17)] [RED("friendlyName")] 		public CString FriendlyName { get; set;}

		[Ordinal(18)] [RED("animationType")] 		public CEnum<EStorySceneAnimationType> AnimationType { get; set;}

		[Ordinal(19)] [RED("addConvertToAdditive")] 		public CBool AddConvertToAdditive { get; set;}

		[Ordinal(20)] [RED("addAdditiveType")] 		public CEnum<EAdditiveType> AddAdditiveType { get; set;}

		[Ordinal(21)] [RED("recacheWeightCurve")] 		public CBool RecacheWeightCurve { get; set;}

		[Ordinal(22)] [RED("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[Ordinal(23)] [RED("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		[Ordinal(24)] [RED("weightCurveChanged")] 		public CBool WeightCurveChanged { get; set;}

		[Ordinal(25)] [RED("supportsMotionExClipFront")] 		public CBool SupportsMotionExClipFront { get; set;}

		public CStorySceneEventAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}