using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SUISavedData : CVariable
	{
		[RED("panelName")] 		public CName PanelName { get; set;}

		[RED("selectedTag")] 		public CName SelectedTag { get; set;}

		[RED("openedCategories", 2,0)] 		public CArray<CName> OpenedCategories { get; set;}

		[RED("gridItem")] 		public SItemUniqueId GridItem { get; set;}

		[RED("slotID")] 		public CInt32 SlotID { get; set;}

		[RED("selectedModule")] 		public CInt32 SelectedModule { get; set;}

		public SUISavedData(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SUISavedData(cr2w);

	}
}