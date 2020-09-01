using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventGameplayLookAt : CStorySceneEventDuration
	{
		[Ordinal(1)] [RED("("actor")] 		public CName Actor { get; set;}

		[Ordinal(2)] [RED("("target")] 		public CName Target { get; set;}

		[Ordinal(3)] [RED("("enabled")] 		public CBool Enabled { get; set;}

		[Ordinal(4)] [RED("("instant")] 		public CBool Instant { get; set;}

		[Ordinal(5)] [RED("("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(6)] [RED("("staticPoint")] 		public Vector StaticPoint { get; set;}

		[Ordinal(7)] [RED("("type")] 		public CEnum<EDialogLookAtType> Type { get; set;}

		[Ordinal(8)] [RED("("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[Ordinal(9)] [RED("("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		[Ordinal(10)] [RED("("behaviorVarWeight")] 		public CName BehaviorVarWeight { get; set;}

		[Ordinal(11)] [RED("("behaviorVarTarget")] 		public CName BehaviorVarTarget { get; set;}

		public CStorySceneEventGameplayLookAt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CStorySceneEventGameplayLookAt(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}