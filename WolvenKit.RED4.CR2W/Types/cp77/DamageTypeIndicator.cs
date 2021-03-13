using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageTypeIndicator : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("DamageIconRef")] public inkImageWidgetReference DamageIconRef { get; set; }
		[Ordinal(2)] [RED("DamageTypeLabelRef")] public inkTextWidgetReference DamageTypeLabelRef { get; set; }

		public DamageTypeIndicator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
