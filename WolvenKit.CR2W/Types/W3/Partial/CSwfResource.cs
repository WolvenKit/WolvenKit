using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CSwfResource : CResource
	{
		[RED("linkageName")] 		public CString LinkageName { get; set;}

		[RED("fonts", 2,0)] 		public CArray<SSwfFontDesc> Fonts { get; set;}

		[RED("textures", 2,0)] 		public CArray<CHandle<CSwfTexture>> Textures { get; set;}

		[RED("header")] 		public SSwfHeaderInfo Header { get; set;}

		[RED("imageImportOptions")] 		public CString ImageImportOptions { get; set;}

		public CSwfResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSwfResource(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}