using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class C2dArray : CResource
	{
		[RED("headers", 12,0)] 		public CArray<CString> Headers { get; set;}

		[RED("data", 12,0)] 		public CArray<CArray<CString>> Data { get; set;}

		public C2dArray(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new C2dArray(cr2w);

	}
}