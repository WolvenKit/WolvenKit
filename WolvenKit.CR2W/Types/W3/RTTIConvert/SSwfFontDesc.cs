using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSwfFontDesc : CVariable
	{
		[RED("fontName")] 		public CString FontName { get; set;}

		[RED("numGlyphs")] 		public CUInt32 NumGlyphs { get; set;}

		[RED("italic")] 		public CBool Italic { get; set;}

		[RED("bold")] 		public CBool Bold { get; set;}

		public SSwfFontDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSwfFontDesc(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}