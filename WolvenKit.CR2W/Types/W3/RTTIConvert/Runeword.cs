using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class Runeword : CVariable
	{
		[Ordinal(0)] [RED("wordName")] 		public CName WordName { get; set;}

		[Ordinal(0)] [RED("runes", 2,0)] 		public CArray<CName> Runes { get; set;}

		[Ordinal(0)] [RED("abilities", 2,0)] 		public CArray<CName> Abilities { get; set;}

		public Runeword(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new Runeword(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}