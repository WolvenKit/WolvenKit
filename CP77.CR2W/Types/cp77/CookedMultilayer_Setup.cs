using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CookedMultilayer_Setup : CResource
	{
		[Ordinal(1)] [RED("dependencies")] public CArray<rRef<Multilayer_Setup>> Dependencies { get; set; }

		public CookedMultilayer_Setup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
