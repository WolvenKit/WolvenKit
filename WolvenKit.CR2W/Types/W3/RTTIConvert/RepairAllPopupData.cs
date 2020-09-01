using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class RepairAllPopupData : ConfirmationPopupData
	{
		[Ordinal(0)] [RED("m_Price")] 		public CFloat M_Price { get; set;}

		[Ordinal(0)] [RED("menuRef")] 		public CHandle<CR4BlacksmithMenu> MenuRef { get; set;}

		public RepairAllPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new RepairAllPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}