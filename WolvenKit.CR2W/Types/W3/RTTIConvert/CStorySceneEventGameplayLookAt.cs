using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventGameplayLookAt : CStorySceneEventDuration
	{
		[RED("actor")] 		public CName Actor { get; set;}

		[RED("target")] 		public CName Target { get; set;}

		[RED("enabled")] 		public CBool Enabled { get; set;}

		[RED("instant")] 		public CBool Instant { get; set;}

		[RED("weight")] 		public CFloat Weight { get; set;}

		[RED("staticPoint")] 		public Vector StaticPoint { get; set;}

		[RED("type")] 		public CEnum<EDialogLookAtType> Type { get; set;}

		[RED("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[RED("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		[RED("behaviorVarWeight")] 		public CName BehaviorVarWeight { get; set;}

		[RED("behaviorVarTarget")] 		public CName BehaviorVarTarget { get; set;}

		public CStorySceneEventGameplayLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventGameplayLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}