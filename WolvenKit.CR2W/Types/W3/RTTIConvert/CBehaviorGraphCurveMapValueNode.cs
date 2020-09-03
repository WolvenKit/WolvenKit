using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphCurveMapValueNode : CBehaviorGraphValueBaseNode
	{
		[Ordinal(1)] [RED("curve")] 		public CPtr<CCurve> Curve { get; set;}

		[Ordinal(2)] [RED("axisXScale")] 		public CFloat AxisXScale { get; set;}

		[Ordinal(3)] [RED("valueScale")] 		public CFloat ValueScale { get; set;}

		[Ordinal(4)] [RED("valueOffet")] 		public CFloat ValueOffet { get; set;}

		[Ordinal(5)] [RED("mirrorY")] 		public CBool MirrorY { get; set;}

		public CBehaviorGraphCurveMapValueNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphCurveMapValueNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}