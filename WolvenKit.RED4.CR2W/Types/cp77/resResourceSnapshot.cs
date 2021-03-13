using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class resResourceSnapshot : CResource
	{
		[Ordinal(1)] [RED("resources")] public CArray<raRef<CResource>> Resources { get; set; }

		public resResourceSnapshot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
