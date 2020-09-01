using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class TextPopupData : W3PopupData
	{
		[Ordinal(1)] [RED("("m_TextContent")] 		public CString M_TextContent { get; set;}

		[Ordinal(2)] [RED("("m_TextTitle")] 		public CString M_TextTitle { get; set;}

		[Ordinal(3)] [RED("("m_ImagePath")] 		public CString M_ImagePath { get; set;}

		[Ordinal(4)] [RED("("m_DisplayGreyBackground")] 		public CBool M_DisplayGreyBackground { get; set;}

		public TextPopupData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new TextPopupData(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}