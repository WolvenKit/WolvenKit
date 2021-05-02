using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SModUiCategorizedListItem : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public CString Id { get; set;}

		[Ordinal(2)] [RED("caption")] 		public CString Caption { get; set;}

		[Ordinal(3)] [RED("cat1")] 		public CString Cat1 { get; set;}

		[Ordinal(4)] [RED("cat2")] 		public CString Cat2 { get; set;}

		[Ordinal(5)] [RED("cat3")] 		public CString Cat3 { get; set;}

		[Ordinal(6)] [RED("isWildcardMiss")] 		public CBool IsWildcardMiss { get; set;}

		public SModUiCategorizedListItem(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SModUiCategorizedListItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}