using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatform : entIPlacedComponent
	{
		[Ordinal(5)] [RED("loopType")] public CEnum<gameMovingPlatformLoopType> LoopType { get; set; }

		public gameMovingPlatform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
