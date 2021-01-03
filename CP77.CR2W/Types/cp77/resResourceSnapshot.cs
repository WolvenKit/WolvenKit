using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class resResourceSnapshot : CResource
	{
		[Ordinal(0)]  [RED("resources")] public CArray<raRef<CResource>> Resources { get; set; }

		public resResourceSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
