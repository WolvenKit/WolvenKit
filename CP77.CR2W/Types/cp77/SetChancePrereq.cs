using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SetChancePrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("setChance")] public CFloat SetChance { get; set; }

		public SetChancePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
