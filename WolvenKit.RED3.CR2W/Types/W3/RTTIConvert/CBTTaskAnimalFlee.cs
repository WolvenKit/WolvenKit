using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskAnimalFlee : IBehTreeTask
	{
		[Ordinal(1)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(2)] [RED("heading")] 		public CFloat Heading { get; set;}

		[Ordinal(3)] [RED("initialPosCheck")] 		public CBool InitialPosCheck { get; set;}

		[Ordinal(4)] [RED("isMoving")] 		public CBool IsMoving { get; set;}

		[Ordinal(5)] [RED("alertRadius")] 		public CFloat AlertRadius { get; set;}

		[Ordinal(6)] [RED("ignoreEntitiesWithTag")] 		public CName IgnoreEntitiesWithTag { get; set;}

		[Ordinal(7)] [RED("moveType")] 		public CEnum<EMoveType> MoveType { get; set;}

		[Ordinal(8)] [RED("initialPos")] 		public Vector InitialPos { get; set;}

		[Ordinal(9)] [RED("checkPos")] 		public Vector CheckPos { get; set;}

		public CBTTaskAnimalFlee(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskAnimalFlee(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}