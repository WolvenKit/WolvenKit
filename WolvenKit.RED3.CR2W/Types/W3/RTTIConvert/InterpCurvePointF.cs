using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class InterpCurvePointF : InterpCurvePoint
	{
		[Ordinal(1)] [RED("outVal")] 		public CFloat OutVal { get; set;}

		[Ordinal(2)] [RED("arriveTangent")] 		public CFloat ArriveTangent { get; set;}

		[Ordinal(3)] [RED("leaveTangent")] 		public CFloat LeaveTangent { get; set;}

		public InterpCurvePointF(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new InterpCurvePointF(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}