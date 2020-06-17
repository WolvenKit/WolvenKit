using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventChangePose : CStorySceneEventAnimClip
	{
		[RED("stateName")] 		public CName StateName { get; set;}

		[RED("status")] 		public CName Status { get; set;}

		[RED("emotionalState")] 		public CName EmotionalState { get; set;}

		[RED("poseName")] 		public CName PoseName { get; set;}

		[RED("transitionAnimation")] 		public CName TransitionAnimation { get; set;}

		[RED("useMotionExtraction")] 		public CBool UseMotionExtraction { get; set;}

		[RED("forceBodyIdleAnimation")] 		public CName ForceBodyIdleAnimation { get; set;}

		[RED("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[RED("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		[RED("resetCloth")] 		public EDialogResetClothAndDanglesType ResetCloth { get; set;}

		public CStorySceneEventChangePose(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CStorySceneEventChangePose(cr2w);

	}
}