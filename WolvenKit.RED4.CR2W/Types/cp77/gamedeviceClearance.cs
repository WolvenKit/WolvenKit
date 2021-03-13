using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedeviceClearance : IScriptable
	{
		[Ordinal(0)] [RED("min")] public CInt32 Min { get; set; }
		[Ordinal(1)] [RED("max")] public CInt32 Max { get; set; }

		public gamedeviceClearance(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
