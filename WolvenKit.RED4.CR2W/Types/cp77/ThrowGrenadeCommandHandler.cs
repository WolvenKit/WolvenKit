using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowGrenadeCommandHandler : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("inCommand")] public CHandle<AIArgumentMapping> InCommand { get; set; }
		[Ordinal(1)] [RED("currentCommand")] public wCHandle<AIThrowGrenadeCommand> CurrentCommand { get; set; }

		public ThrowGrenadeCommandHandler(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
