using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CheckCurrentWoundedState : AIStatusEffectCondition
	{
		[Ordinal(0)] [RED("woundedTypeToCompare")] public CEnum<EWoundedBodyPart> WoundedTypeToCompare { get; set; }

		public CheckCurrentWoundedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
