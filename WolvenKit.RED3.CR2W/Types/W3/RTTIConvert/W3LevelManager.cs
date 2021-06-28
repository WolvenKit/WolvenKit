using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LevelManager : CObject
	{
		[Ordinal(1)] [RED("owner")] 		public CHandle<W3PlayerWitcher> Owner { get; set;}

		[Ordinal(2)] [RED("levelDefinitions", 2,0)] 		public CArray<SLevelDefinition> LevelDefinitions { get; set;}

		[Ordinal(3)] [RED("level")] 		public CInt32 Level { get; set;}

		[Ordinal(4)] [RED("points", 2,0)] 		public CArray<SSpendablePoints> Points { get; set;}

		[Ordinal(5)] [RED("lastCustomLevel")] 		public CInt32 LastCustomLevel { get; set;}

		[Ordinal(6)] [RED("mSSPPL")] 		public CHandle<CSSPPL> MSSPPL { get; set;}

		public W3LevelManager(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}