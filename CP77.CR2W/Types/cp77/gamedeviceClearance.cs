using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gamedeviceClearance : IScriptable
	{
		[Ordinal(0)]  [RED("max")] public CInt32 Max { get; set; }
		[Ordinal(1)]  [RED("min")] public CInt32 Min { get; set; }

		public gamedeviceClearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
