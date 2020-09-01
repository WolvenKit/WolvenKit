using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CModUiFilteredList : CObject
	{
		[Ordinal(0)] [RED("items", 2,0)] 		public CArray<SModUiCategorizedListItem> Items { get; set;}

		[Ordinal(0)] [RED("selectedCat1")] 		public CString SelectedCat1 { get; set;}

		[Ordinal(0)] [RED("selectedCat2")] 		public CString SelectedCat2 { get; set;}

		[Ordinal(0)] [RED("selectedCat3")] 		public CString SelectedCat3 { get; set;}

		[Ordinal(0)] [RED("wildcardFilter")] 		public CString WildcardFilter { get; set;}

		[Ordinal(0)] [RED("itemsMatching")] 		public CInt32 ItemsMatching { get; set;}

		[Ordinal(0)] [RED("filteredList", 2,0)] 		public CArray<SModUiListItem> FilteredList { get; set;}

		[Ordinal(0)] [RED("selectedId")] 		public CString SelectedId { get; set;}

		public CModUiFilteredList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CModUiFilteredList(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}