using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectSet : CResource
	{
		[Ordinal(1)] [RED("effects")] public CArray<gameEffectDefinition> Effects { get; set; }

		public gameEffectSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
