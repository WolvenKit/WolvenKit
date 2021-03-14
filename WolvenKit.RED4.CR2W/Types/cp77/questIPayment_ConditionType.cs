using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIPayment_ConditionType : questIConditionType
	{
		[Ordinal(0)] [RED("scriptCondition")] public CHandle<IScriptable> ScriptCondition { get; set; }

		public questIPayment_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
