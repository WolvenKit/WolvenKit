using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatform : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("loopType")] public CEnum<gameMovingPlatformLoopType> LoopType { get; set; }

		public gameMovingPlatform(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
