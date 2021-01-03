using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldStreamingSectorInplaceContent : CResource
	{
		[Ordinal(0)]  [RED("inplaceResources")] public CArray<rRef<CResource>> InplaceResources { get; set; }

		public worldStreamingSectorInplaceContent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
