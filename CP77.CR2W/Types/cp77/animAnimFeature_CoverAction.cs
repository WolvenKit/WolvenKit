using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_CoverAction : animAnimFeature_AIAction
	{
		[Ordinal(0)]  [RED("coverActionType")] public CInt32 CoverActionType { get; set; }
		[Ordinal(1)]  [RED("coverShootType")] public CInt32 CoverShootType { get; set; }
		[Ordinal(2)]  [RED("coverStance")] public CInt32 CoverStance { get; set; }
		[Ordinal(3)]  [RED("movementType")] public CInt32 MovementType { get; set; }

		public animAnimFeature_CoverAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
