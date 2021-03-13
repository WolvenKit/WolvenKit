using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnRidResourceHandler : CVariable
	{
		[Ordinal(0)] [RED("id")] public scnRidResourceId Id { get; set; }
		[Ordinal(1)] [RED("ridResource")] public rRef<scnRidResource> RidResource { get; set; }

		public scnRidResourceHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
