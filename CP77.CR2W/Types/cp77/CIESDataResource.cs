using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CIESDataResource : CResource
	{
		[Ordinal(0)]  [RED("samples", 128)] public CArrayFixedSize<CUInt8> Samples { get; set; }

		public CIESDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
