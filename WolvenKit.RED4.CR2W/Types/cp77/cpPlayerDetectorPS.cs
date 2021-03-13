using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cpPlayerDetectorPS : gameObjectPS
	{
		[Ordinal(0)] [RED("secondsCounter")] public CInt32 SecondsCounter { get; set; }

		public cpPlayerDetectorPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
