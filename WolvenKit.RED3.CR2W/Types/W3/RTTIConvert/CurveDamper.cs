using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CurveDamper : CObject
	{
		[Ordinal(1)] [RED("curve")] 		public CHandle<CCurve> Curve { get; set;}

		[Ordinal(2)] [RED("time")] 		public CFloat Time { get; set;}

		[Ordinal(3)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(4)] [RED("startValue")] 		public CFloat StartValue { get; set;}

		[Ordinal(5)] [RED("currValue")] 		public CFloat CurrValue { get; set;}

		[Ordinal(6)] [RED("destValue")] 		public CFloat DestValue { get; set;}

		public CurveDamper(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CurveDamper(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}