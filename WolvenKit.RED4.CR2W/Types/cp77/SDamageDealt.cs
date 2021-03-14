using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SDamageDealt : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gamedataDamageType> Type { get; set; }
		[Ordinal(1)] [RED("value")] public CFloat Value { get; set; }
		[Ordinal(2)] [RED("affectedStatPool")] public CEnum<gamedataStatPoolType> AffectedStatPool { get; set; }

		public SDamageDealt(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
