using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class StatusEffectPresentHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(0)]  [RED("checkType")] public CName CheckType { get; set; }
		[Ordinal(1)]  [RED("objectToCheck")] public CName ObjectToCheck { get; set; }
		[Ordinal(2)]  [RED("statusEffectParam")] public CName StatusEffectParam { get; set; }
		[Ordinal(3)]  [RED("tag")] public CName Tag { get; set; }

		public StatusEffectPresentHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
