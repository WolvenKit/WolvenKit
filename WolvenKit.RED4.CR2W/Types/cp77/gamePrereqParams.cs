using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePrereqParams : CVariable
	{
		[Ordinal(0)] [RED("objectID")] public gameStatsObjectID ObjectID { get; set; }
		[Ordinal(1)] [RED("otherObjectID")] public gameStatsObjectID OtherObjectID { get; set; }
		[Ordinal(2)] [RED("otherData")] public CVariant OtherData { get; set; }

		public gamePrereqParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
