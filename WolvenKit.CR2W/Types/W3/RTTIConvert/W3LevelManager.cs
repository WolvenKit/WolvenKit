using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3LevelManager : CObject
	{
		[RED("owner")] 		public CHandle<W3PlayerWitcher> Owner { get; set;}

		[RED("levelDefinitions", 2,0)] 		public CArray<SLevelDefinition> LevelDefinitions { get; set;}

		[RED("level")] 		public CInt32 Level { get; set;}

		[RED("points", 2,0)] 		public CArray<SSpendablePoints> Points { get; set;}

		[RED("lastCustomLevel")] 		public CInt32 LastCustomLevel { get; set;}

		[RED("mSSPPL")] 		public CHandle<CSSPPL> MSSPPL { get; set;}

		public W3LevelManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3LevelManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}