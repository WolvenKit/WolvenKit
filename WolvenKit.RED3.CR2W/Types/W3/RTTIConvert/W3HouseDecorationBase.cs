using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3HouseDecorationBase : W3Container
	{
		[Ordinal(1)] [RED("m_popupData")] 		public CHandle<W3ItemSelectionPopupData> M_popupData { get; set;}

		[Ordinal(2)] [RED("m_itemSelectionTagList", 2,0)] 		public CArray<CName> M_itemSelectionTagList { get; set;}

		[Ordinal(3)] [RED("m_itemSelectionForbiddenTagList", 2,0)] 		public CArray<CName> M_itemSelectionForbiddenTagList { get; set;}

		[Ordinal(4)] [RED("m_itemSelectionMode")] 		public CEnum<EItemSelectionPopupMode> M_itemSelectionMode { get; set;}

		[Ordinal(5)] [RED("m_itemSelectionCategories", 2,0)] 		public CArray<CName> M_itemSelectionCategories { get; set;}

		[Ordinal(6)] [RED("m_acceptQuestItems")] 		public CBool M_acceptQuestItems { get; set;}

		[Ordinal(7)] [RED("m_decorationEnabled")] 		public CBool M_decorationEnabled { get; set;}

		[Ordinal(8)] [RED("m_noItemMessageStringKey")] 		public CName M_noItemMessageStringKey { get; set;}

		public W3HouseDecorationBase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3HouseDecorationBase(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}