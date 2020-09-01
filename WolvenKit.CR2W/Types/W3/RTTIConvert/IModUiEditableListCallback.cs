using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IModUiEditableListCallback : IModUiMenuCallback
	{
		[Ordinal(0)] [RED("("listMenuRef")] 		public CHandle<CModUiEditableListView> ListMenuRef { get; set;}

		[Ordinal(0)] [RED("("title")] 		public CString Title { get; set;}

		[Ordinal(0)] [RED("("statsLabel")] 		public CString StatsLabel { get; set;}

		[Ordinal(0)] [RED("("listData", 2,0)] 		public CArray<SModUiListItem> ListData { get; set;}

		public IModUiEditableListCallback(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new IModUiEditableListCallback(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}