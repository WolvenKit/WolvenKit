using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AISharedVarTableDefinition : CVariable
	{
		[Ordinal(0)] [RED("table")] public CArray<AISharedVarDefinition> Table { get; set; }

		public AISharedVarTableDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
