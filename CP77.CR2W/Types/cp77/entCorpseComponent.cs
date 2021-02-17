using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entCorpseComponent : entISkinableComponent
	{
		[Ordinal(5)] [RED("filterData")] public CHandle<physicsFilterData> FilterData { get; set; }
		[Ordinal(6)] [RED("material")] public CName Material { get; set; }

		public entCorpseComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
