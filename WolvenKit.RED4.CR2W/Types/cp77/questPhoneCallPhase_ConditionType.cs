using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallPhase_ConditionType : questIPhoneConditionType
	{
		[Ordinal(1)] [RED("callPhase")] public CEnum<questPhoneCallPhase> CallPhase { get; set; }

		public questPhoneCallPhase_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
