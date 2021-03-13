using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeLeapEvents : MeleeEventsTransition
	{
		[Ordinal(0)] [RED("textLayerId")] public CUInt32 TextLayerId { get; set; }

		public MeleeLeapEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
