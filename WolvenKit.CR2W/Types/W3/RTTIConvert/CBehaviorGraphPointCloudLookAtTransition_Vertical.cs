using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
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

		public CBehaviorGraphPointCloudLookAtTransition_Vertical(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphPointCloudLookAtTransition_Vertical(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}