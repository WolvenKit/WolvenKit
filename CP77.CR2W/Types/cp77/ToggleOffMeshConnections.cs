using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ToggleOffMeshConnections : redEvent
	{
		[Ordinal(0)] [RED("enable")] public CBool Enable { get; set; }
		[Ordinal(1)] [RED("affectsPlayer")] public CBool AffectsPlayer { get; set; }
		[Ordinal(2)] [RED("affectsNPCs")] public CBool AffectsNPCs { get; set; }

		public ToggleOffMeshConnections(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
