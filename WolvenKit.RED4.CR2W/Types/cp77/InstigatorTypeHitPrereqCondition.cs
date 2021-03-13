using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InstigatorTypeHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] [RED("instigatorType")] public CName InstigatorType { get; set; }

		public InstigatorTypeHitPrereqCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
