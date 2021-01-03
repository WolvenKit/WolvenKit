using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class KerenzikovEvents : TimeDilationEventsTransitions
	{
		[Ordinal(0)]  [RED("allowMovementModifier")] public CHandle<gameStatModifierData> AllowMovementModifier { get; set; }

		public KerenzikovEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
