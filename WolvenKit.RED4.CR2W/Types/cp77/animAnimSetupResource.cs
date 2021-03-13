using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetupResource : CResource
	{
		[Ordinal(1)] [RED("dependencies")] public CArray<rRef<animAnimSet>> Dependencies { get; set; }

		public animAnimSetupResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
