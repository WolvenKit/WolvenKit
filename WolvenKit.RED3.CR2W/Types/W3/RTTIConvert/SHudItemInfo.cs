using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SHudItemInfo : CVariable
	{
		[Ordinal(1)] [RED("m_icon")] 		public CString M_icon { get; set;}

		[Ordinal(2)] [RED("m_category")] 		public CString M_category { get; set;}

		[Ordinal(3)] [RED("m_itemName")] 		public CString M_itemName { get; set;}

		[Ordinal(4)] [RED("m_ammoStr")] 		public CString M_ammoStr { get; set;}

		[Ordinal(5)] [RED("m_btn")] 		public CInt32 M_btn { get; set;}

		[Ordinal(6)] [RED("m_pcBtn")] 		public CInt32 M_pcBtn { get; set;}

		public SHudItemInfo(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SHudItemInfo(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}