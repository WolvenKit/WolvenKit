using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
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

		public CMoveSTHorse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMoveSTHorse(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}