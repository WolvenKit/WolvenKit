using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SStatPoolValue : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gamedataStatPoolType> Type { get; set; }
		[Ordinal(1)] [RED("value")] public CFloat Value { get; set; }

		public SStatPoolValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
