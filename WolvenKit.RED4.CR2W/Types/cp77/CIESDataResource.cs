using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CIESDataResource : CResource
	{
		[Ordinal(1)] [RED("samples", 128)] public CArrayFixedSize<CUInt8> Samples { get; set; }

		public CIESDataResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
