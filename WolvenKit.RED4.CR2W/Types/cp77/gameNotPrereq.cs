using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameNotPrereq : gameIPrereq
	{
		[Ordinal(0)] [RED("negatedPrereq")] public CHandle<gameIPrereq> NegatedPrereq { get; set; }

		public gameNotPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
