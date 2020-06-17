using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SHudItemInfo : CVariable
	{
		[RED("m_icon")] 		public CString M_icon { get; set;}

		[RED("m_category")] 		public CString M_category { get; set;}

		[RED("m_itemName")] 		public CString M_itemName { get; set;}

		[RED("m_ammoStr")] 		public CString M_ammoStr { get; set;}

		[RED("m_btn")] 		public CInt32 M_btn { get; set;}

		[RED("m_pcBtn")] 		public CInt32 M_pcBtn { get; set;}

		public SHudItemInfo(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SHudItemInfo(cr2w);

	}
}