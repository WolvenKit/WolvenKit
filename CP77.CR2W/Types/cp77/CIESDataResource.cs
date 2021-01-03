using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CIESDataResource : CResource
	{
		[Ordinal(0)]  [RED("samples", 128)] public CArrayFixedSize<CUInt8> Samples { get; set; }

		public CIESDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
