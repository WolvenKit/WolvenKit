using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ActionWeightCondition : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("selectedActionIndex")] public CHandle<AIArgumentMapping> SelectedActionIndex { get; set; }
		[Ordinal(1)]  [RED("thisIndex")] public CInt32 ThisIndex { get; set; }

		public ActionWeightCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
