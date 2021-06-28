using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CStorySceneEventMimicsPose : CStorySceneEventDuration
	{
		[Ordinal(1)] [RED("actor")] 		public CName Actor { get; set;}

		[Ordinal(2)] [RED("poseName")] 		public CName PoseName { get; set;}

		[Ordinal(3)] [RED("weight")] 		public CFloat Weight { get; set;}

		[Ordinal(4)] [RED("useWeightCurve")] 		public CBool UseWeightCurve { get; set;}

		[Ordinal(5)] [RED("weightCurve")] 		public SCurveData WeightCurve { get; set;}

		public CStorySceneEventMimicsPose(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}