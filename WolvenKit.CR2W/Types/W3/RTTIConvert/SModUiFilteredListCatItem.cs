using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SModUiFilteredListCatItem : CVariable
	{
		[Ordinal(0)] [RED("("id")] 		public CString Id { get; set;}

		[Ordinal(0)] [RED("("item")] 		public SModUiListItem Item { get; set;}

		[Ordinal(0)] [RED("("count")] 		public CInt32 Count { get; set;}

		[Ordinal(0)] [RED("("total")] 		public CInt32 Total { get; set;}

		[Ordinal(0)] [RED("("isOpen")] 		public CBool IsOpen { get; set;}

		[Ordinal(0)] [RED("("entryPos")] 		public CInt32 EntryPos { get; set;}

		public SModUiFilteredListCatItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SModUiFilteredListCatItem(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}