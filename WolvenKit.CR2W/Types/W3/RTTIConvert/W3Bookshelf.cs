using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3Bookshelf : W3SmartObject
	{
		[Ordinal(1)] [RED("m_booksRange")] 		public CInt32 M_booksRange { get; set;}

		[Ordinal(2)] [RED("m_appearances", 2,0)] 		public CArray<CName> M_appearances { get; set;}

		public W3Bookshelf(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3Bookshelf(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}