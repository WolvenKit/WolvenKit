using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatPoolSpentPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)]  [RED("statPoolType")] public CEnum<gamedataStatPoolType> StatPoolType { get; set; }
		[Ordinal(1)]  [RED("valueToCheck")] public CFloat ValueToCheck { get; set; }

		public StatPoolSpentPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
