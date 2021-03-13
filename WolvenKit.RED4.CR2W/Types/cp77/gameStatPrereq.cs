using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatPrereq : gameIRPGPrereq
	{
		[Ordinal(1)] [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(2)] [RED("valueToCheck")] public CFloat ValueToCheck { get; set; }

		public gameStatPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
