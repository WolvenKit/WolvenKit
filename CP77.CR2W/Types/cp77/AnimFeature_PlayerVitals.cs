using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_PlayerVitals : animAnimFeature
	{
		[Ordinal(0)] [RED("state")] public CInt32 State { get; set; }
		[Ordinal(1)] [RED("stateDuration")] public CFloat StateDuration { get; set; }

		public AnimFeature_PlayerVitals(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
