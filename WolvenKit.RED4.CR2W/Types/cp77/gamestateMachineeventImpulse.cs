using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineeventImpulse : gamestateMachineeventBaseEvent
	{
		[Ordinal(1)] [RED("impulse")] public Vector4 Impulse { get; set; }

		public gamestateMachineeventImpulse(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
