using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventMimics : CStorySceneEventAnimClip
	{
		[Ordinal(0)] [RED("stateName")] 		public CName StateName { get; set;}

		[Ordinal(0)] [RED("mimicsEmotionalState")] 		public CName MimicsEmotionalState { get; set;}

		[Ordinal(0)] [RED("mimicsLayer_Eyes")] 		public CName MimicsLayer_Eyes { get; set;}

		[Ordinal(0)] [RED("mimicsLayer_Pose")] 		public CName MimicsLayer_Pose { get; set;}

		[Ordinal(0)] [RED("mimicsLayer_Animation")] 		public CName MimicsLayer_Animation { get; set;}

		[Ordinal(0)] [RED("mimicsPoseWeight")] 		public CFloat MimicsPoseWeight { get; set;}

		[Ordinal(0)] [RED("transitionAnimation")] 		public CName TransitionAnimation { get; set;}

		[Ordinal(0)] [RED("forceMimicsIdleAnimation_Eyes")] 		public CName ForceMimicsIdleAnimation_Eyes { get; set;}

		[Ordinal(0)] [RED("forceMimicsIdleAnimation_Pose")] 		public CName ForceMimicsIdleAnimation_Pose { get; set;}

		[Ordinal(0)] [RED("forceMimicsIdleAnimation_Animation")] 		public CName ForceMimicsIdleAnimation_Animation { get; set;}

		[Ordinal(0)] [RED("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[Ordinal(0)] [RED("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		public CStorySceneEventMimics(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventMimics(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}