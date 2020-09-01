using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAIAnimalRunWild : CAIDynamicWander
	{
		[Ordinal(1)] [RED("packRegroupEvent")] 		public CName PackRegroupEvent { get; set;}

		[Ordinal(2)] [RED("leaderRegroupEvent")] 		public CName LeaderRegroupEvent { get; set;}

		public CAIAnimalRunWild(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAIAnimalRunWild(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}