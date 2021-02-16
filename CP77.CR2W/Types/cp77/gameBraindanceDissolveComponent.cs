using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameBraindanceDissolveComponent : entIComponent
	{
		[Ordinal(3)] [RED("dissolveRadius")] public CFloat DissolveRadius { get; set; }

		public gameBraindanceDissolveComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
