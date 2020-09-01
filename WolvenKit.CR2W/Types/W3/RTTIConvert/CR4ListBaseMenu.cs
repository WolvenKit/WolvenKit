using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CR4ListBaseMenu : CR4MenuBase
	{
		[Ordinal(1)] [RED("("DATA_BINDING_NAME")] 		public CString DATA_BINDING_NAME { get; set;}

		[Ordinal(2)] [RED("("DATA_BINDING_NAME_SUBLIST")] 		public CString DATA_BINDING_NAME_SUBLIST { get; set;}

		[Ordinal(3)] [RED("("DATA_BINDING_NAME_DESCRIPTION")] 		public CString DATA_BINDING_NAME_DESCRIPTION { get; set;}

		[Ordinal(4)] [RED("("ITEMS_SIZE")] 		public CInt32 ITEMS_SIZE { get; set;}

		[Ordinal(5)] [RED("("m_journalManager")] 		public CHandle<CWitcherJournalManager> M_journalManager { get; set;}

		[Ordinal(6)] [RED("("currentTag")] 		public CName CurrentTag { get; set;}

		[Ordinal(7)] [RED("("lastSentTag")] 		public CName LastSentTag { get; set;}

		[Ordinal(8)] [RED("("openedTabs", 2,0)] 		public CArray<CName> OpenedTabs { get; set;}

		[Ordinal(9)] [RED("("itemsNames", 2,0)] 		public CArray<CName> ItemsNames { get; set;}

		public CR4ListBaseMenu(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CR4ListBaseMenu(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}