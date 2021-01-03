using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class redResourceListResource : CResource
	{
		[Ordinal(0)]  [RED("descriptions")] public CArray<CString> Descriptions { get; set; }
		[Ordinal(1)]  [RED("resources")] public CArray<raRef<CResource>> Resources { get; set; }

		public redResourceListResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
