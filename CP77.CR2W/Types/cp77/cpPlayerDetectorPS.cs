using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class cpPlayerDetectorPS : gameObjectPS
	{
		[Ordinal(0)]  [RED("secondsCounter")] public CInt32 SecondsCounter { get; set; }

		public cpPlayerDetectorPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
