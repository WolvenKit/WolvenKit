using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3HouseDecorationBase : W3Container
	{
		[RED("m_popupData")] 		public CHandle<W3ItemSelectionPopupData> M_popupData { get; set;}

		[RED("m_itemSelectionTagList", 2,0)] 		public CArray<CName> M_itemSelectionTagList { get; set;}

		[RED("m_itemSelectionForbiddenTagList", 2,0)] 		public CArray<CName> M_itemSelectionForbiddenTagList { get; set;}

		[RED("m_itemSelectionMode")] 		public CEnum<EItemSelectionPopupMode> M_itemSelectionMode { get; set;}

		[RED("m_itemSelectionCategories", 2,0)] 		public CArray<CName> M_itemSelectionCategories { get; set;}

		[RED("m_acceptQuestItems")] 		public CBool M_acceptQuestItems { get; set;}

		[RED("m_decorationEnabled")] 		public CBool M_decorationEnabled { get; set;}

		[RED("m_noItemMessageStringKey")] 		public CName M_noItemMessageStringKey { get; set;}

		public W3HouseDecorationBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HouseDecorationBase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}