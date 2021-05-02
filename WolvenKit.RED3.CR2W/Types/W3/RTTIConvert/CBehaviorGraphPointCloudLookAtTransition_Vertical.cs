using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphPointCloudLookAtTransition_Vertical : IBehaviorGraphPointCloudLookAtTransition_Vector
	{
		[Ordinal(1)] [RED("maxAngleDiffDeg")] 		public CFloat MaxAngleDiffDeg { get; set;}

		[Ordinal(2)] [RED("scale")] 		public CFloat Scale { get; set;}

		[Ordinal(3)] [RED("minAngle")] 		public CFloat MinAngle { get; set;}

		[Ordinal(4)] [RED("maxAngle")] 		public CFloat MaxAngle { get; set;}

		[Ordinal(5)] [RED("curve")] 		public CPtr<CCurve> Curve { get; set;}

		public CBehaviorGraphPointCloudLookAtTransition_Vertical(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}