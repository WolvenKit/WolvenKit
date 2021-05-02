using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SModUiFilteredListCatItem : CVariable
	{
		[Ordinal(1)] [RED("id")] 		public CString Id { get; set;}

		[Ordinal(2)] [RED("item")] 		public SModUiListItem Item { get; set;}

		[Ordinal(3)] [RED("count")] 		public CInt32 Count { get; set;}

		[Ordinal(4)] [RED("total")] 		public CInt32 Total { get; set;}

		[Ordinal(5)] [RED("isOpen")] 		public CBool IsOpen { get; set;}

		[Ordinal(6)] [RED("entryPos")] 		public CInt32 EntryPos { get; set;}

		public SModUiFilteredListCatItem(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SModUiFilteredListCatItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}