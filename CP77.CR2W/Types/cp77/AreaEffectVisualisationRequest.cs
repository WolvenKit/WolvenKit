using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AreaEffectVisualisationRequest : redEvent
	{
		[Ordinal(0)] [RED("areaEffectID")] public CName AreaEffectID { get; set; }
		[Ordinal(1)] [RED("show")] public CBool Show { get; set; }

		public AreaEffectVisualisationRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
