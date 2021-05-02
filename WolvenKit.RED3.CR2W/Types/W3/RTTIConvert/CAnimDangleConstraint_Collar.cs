using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Collar : CAnimSkeletalDangleConstraint
	{
		[Ordinal(1)] [RED("offset")] 		public Vector Offset { get; set;}

		[Ordinal(2)] [RED("radius")] 		public CFloat Radius { get; set;}

		[Ordinal(3)] [RED("offset2")] 		public Vector Offset2 { get; set;}

		[Ordinal(4)] [RED("radius2")] 		public CFloat Radius2 { get; set;}

		public CAnimDangleConstraint_Collar(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}