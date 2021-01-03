using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questEntityAppearance_ConditionType : questIEntityConditionType
	{
		[Ordinal(0)]  [RED("appearance")] public CName Appearance { get; set; }
		[Ordinal(1)]  [RED("entityRef")] public gameEntityReference EntityRef { get; set; }

		public questEntityAppearance_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
