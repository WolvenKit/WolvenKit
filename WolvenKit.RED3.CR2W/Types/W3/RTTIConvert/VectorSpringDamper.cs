using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class VectorSpringDamper : CObject
	{
		[Ordinal(1)] [RED("destValue")] 		public Vector DestValue { get; set;}

		[Ordinal(2)] [RED("currValue")] 		public Vector CurrValue { get; set;}

		[Ordinal(3)] [RED("velValue")] 		public Vector VelValue { get; set;}

		[Ordinal(4)] [RED("smoothTime")] 		public CFloat SmoothTime { get; set;}

		public VectorSpringDamper(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new VectorSpringDamper(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}