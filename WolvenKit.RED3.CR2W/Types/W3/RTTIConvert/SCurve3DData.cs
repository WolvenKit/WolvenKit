using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCurve3DData : CVariable
	{
		[Ordinal(1)] [RED("curveX")] 		public SCurveData CurveX { get; set;}

		[Ordinal(2)] [RED("curveY")] 		public SCurveData CurveY { get; set;}

		[Ordinal(3)] [RED("curveZ")] 		public SCurveData CurveZ { get; set;}

		public SCurve3DData(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCurve3DData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}