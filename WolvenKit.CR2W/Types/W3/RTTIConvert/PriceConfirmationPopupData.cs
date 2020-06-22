using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class PriceConfirmationPopupData : ConfirmationPopupData
	{
		[RED("m_Price")] 		public CFloat M_Price { get; set;}

		[RED("itemId")] 		public SItemUniqueId ItemId { get; set;}

		[RED("isStandaloneDismantle")] 		public CBool IsStandaloneDismantle { get; set;}

		[RED("menuRef")] 		public CHandle<CR4BlacksmithMenu> MenuRef { get; set;}

		public PriceConfirmationPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new PriceConfirmationPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}