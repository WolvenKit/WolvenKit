using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questPhoneCallMode_ConditionType : questIPhoneConditionType
	{
		[Ordinal(0)]  [RED("callMode")] public CEnum<questPhoneCallMode> CallMode { get; set; }

		public questPhoneCallMode_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
