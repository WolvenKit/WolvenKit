using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class TraitDisplayData : BasePerkDisplayData
	{
		[Ordinal(10)]  [RED("type")] public CEnum<gamedataTraitType> Type { get; set; }

		public TraitDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
