using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class IModUiEditableListCallback : IModUiMenuCallback
	{
		[Ordinal(1)] [RED("listMenuRef")] 		public CHandle<CModUiEditableListView> ListMenuRef { get; set;}

		[Ordinal(2)] [RED("title")] 		public CString Title { get; set;}

		[Ordinal(3)] [RED("statsLabel")] 		public CString StatsLabel { get; set;}

		[Ordinal(4)] [RED("listData", 2,0)] 		public CArray<SModUiListItem> ListData { get; set;}

		public IModUiEditableListCallback(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}