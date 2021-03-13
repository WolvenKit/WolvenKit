using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SCraftsman : CVariable
	{
		[Ordinal(1)] [RED("type")] 		public CEnum<ECraftsmanType> Type { get; set;}

		[Ordinal(2)] [RED("level")] 		public CEnum<ECraftsmanLevel> Level { get; set;}

		[Ordinal(3)] [RED("noCraftingCost")] 		public CBool NoCraftingCost { get; set;}

		public SCraftsman(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SCraftsman(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}