using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class EnchantingConfirmationPopupData : ConfirmationPopupData
	{
		[Ordinal(1)] [RED("removingEnchantment")] 		public CBool RemovingEnchantment { get; set;}

		[Ordinal(2)] [RED("menuRef")] 		public CHandle<CR4EnchantingMenu> MenuRef { get; set;}

		[Ordinal(3)] [RED("m_Price")] 		public CFloat M_Price { get; set;}

		public EnchantingConfirmationPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new EnchantingConfirmationPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}