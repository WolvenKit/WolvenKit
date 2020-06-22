using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventAnimation : CStorySceneEventAnimClip
	{
		[RED("animationName")] 		public CName AnimationName { get; set;}

		[RED("useMotionExtraction")] 		public CBool UseMotionExtraction { get; set;}

		[RED("useFakeMotion")] 		public CBool UseFakeMotion { get; set;}

		[RED("gatherSyncTokens")] 		public CBool GatherSyncTokens { get; set;}

		[RED("muteSoundEvents")] 		public CBool MuteSoundEvents { get; set;}

		[RED("disableLookAt")] 		public CBool DisableLookAt { get; set;}

		[RED("disableLookAtSpeed")] 		public CFloat DisableLookAtSpeed { get; set;}

		[RED("useLowerBodyPartsForLookAt")] 		public CBool UseLowerBodyPartsForLookAt { get; set;}

		[RED("bonesGroupName")] 		public CString BonesGroupName { get; set;}

		[RED("bones", 2,0)] 		public CArray<SBehaviorGraphBoneInfo> Bones { get; set;}

		[RED("bonesIdx", 2,0)] 		public CArray<CInt32> BonesIdx { get; set;}

		[RED("bonesWeight", 2,0)] 		public CArray<CFloat> BonesWeight { get; set;}

		[RED("status")] 		public CName Status { get; set;}

		[RED("emotionalState")] 		public CName EmotionalState { get; set;}

		[RED("poseName")] 		public CName PoseName { get; set;}

		[RED("typeName")] 		public CName TypeName { get; set;}

		[RED("friendlyName")] 		public CString FriendlyName { get; set;}

		[RED("animationType")] 		public CEnum<EStorySceneAnimationType> AnimationType { get; set;}

		[RED("addConvertToAdditive")] 		public CBool AddConvertToAdditive { get; set;}

		[RED("addAdditiveType")] 		public CEnum<EAdditiveType> AddAdditiveType { get; set;}

		[RED("recacheWeightCurve")] 		public CBool RecacheWeightCurve { get; set;}

		[RED("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[RED("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		[RED("weightCurveChanged")] 		public CBool WeightCurveChanged { get; set;}

		[RED("supportsMotionExClipFront")] 		public CBool SupportsMotionExClipFront { get; set;}

		public CStorySceneEventAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}