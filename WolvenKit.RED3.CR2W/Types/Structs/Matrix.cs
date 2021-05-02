using System.IO;using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;
using FastMember;

namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta()]
	public class CMatrix : CVariable
	{
		[Ordinal(1)] [RED("X")] 		public Vector X { get; set;}

		[Ordinal(2)] [RED("Y")] 		public Vector Y { get; set;}

		[Ordinal(3)] [RED("Z")] 		public Vector Z { get; set;}

		[Ordinal(4)] [RED("W")] 		public Vector W { get; set;}

		public CMatrix(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMatrix(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}