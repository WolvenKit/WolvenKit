using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionCondition : TweakAIActionConditionAbstract
	{
		[Ordinal(2)] [RED("record")] public TweakDBID Record { get; set; }

		public TweakAIActionCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
