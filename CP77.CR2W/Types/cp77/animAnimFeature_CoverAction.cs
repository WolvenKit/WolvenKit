using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_CoverAction : animAnimFeature_AIAction
	{
		[Ordinal(0)]  [RED("direction")] public CFloat Direction { get; set; }
		[Ordinal(1)]  [RED("coverStance")] public CInt32 CoverStance { get; set; }
		[Ordinal(2)]  [RED("coverActionType")] public CInt32 CoverActionType { get; set; }
		[Ordinal(3)]  [RED("coverShootType")] public CInt32 CoverShootType { get; set; }
		[Ordinal(4)]  [RED("movementType")] public CInt32 MovementType { get; set; }

		public animAnimFeature_CoverAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
