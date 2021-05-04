using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMoveSTHorse : IMoveSteeringTask
	{
		[Ordinal(1)] [RED("horseSlowWalkMult")] 		public CFloat HorseSlowWalkMult { get; set;}

		[Ordinal(2)] [RED("horseWalkMult")] 		public CFloat HorseWalkMult { get; set;}

		[Ordinal(3)] [RED("horseTrotMult")] 		public CFloat HorseTrotMult { get; set;}

		[Ordinal(4)] [RED("horseGallopMult")] 		public CFloat HorseGallopMult { get; set;}

		[Ordinal(5)] [RED("horseCanterMult")] 		public CFloat HorseCanterMult { get; set;}

		public CMoveSTHorse(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}