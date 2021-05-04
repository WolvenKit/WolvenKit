using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CutCone : CVariable
	{
		[Ordinal(1)] [RED("positionAndRadius1")] 		public Vector PositionAndRadius1 { get; set;}

		[Ordinal(2)] [RED("normalAndRadius2")] 		public Vector NormalAndRadius2 { get; set;}

		[Ordinal(3)] [RED("height")] 		public CFloat Height { get; set;}

		public CutCone(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}