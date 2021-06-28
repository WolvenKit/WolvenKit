using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CSwfResource : CResource
	{
		[Ordinal(1)] [RED("linkageName")] 		public CString LinkageName { get; set;}

		[Ordinal(2)] [RED("fonts", 2,0)] 		public CArray<SSwfFontDesc> Fonts { get; set;}

		[Ordinal(3)] [RED("textures", 2,0)] 		public CArray<CHandle<CSwfTexture>> Textures { get; set;}

		[Ordinal(4)] [RED("header")] 		public SSwfHeaderInfo Header { get; set;}

		[Ordinal(5)] [RED("imageImportOptions")] 		public CString ImageImportOptions { get; set;}

		public CSwfResource(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}