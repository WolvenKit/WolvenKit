using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AITreeNodeRepeatDefinition : AICTreeNodeDecoratorDefinition
	{
		[Ordinal(1)] [RED("limit")] public LibTreeDefInt32 Limit { get; set; }

		public AITreeNodeRepeatDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
