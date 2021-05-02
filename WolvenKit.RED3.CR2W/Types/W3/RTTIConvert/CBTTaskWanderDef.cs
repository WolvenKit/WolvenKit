using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskWanderDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(2)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(3)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(4)] [RED("minSpeed")] 		public CFloat MinSpeed { get; set;}

		[Ordinal(5)] [RED("maxSpeed")] 		public CFloat MaxSpeed { get; set;}

		public CBTTaskWanderDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}