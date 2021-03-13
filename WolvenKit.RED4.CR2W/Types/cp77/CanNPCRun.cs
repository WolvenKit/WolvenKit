using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CanNPCRun : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("maxRunners")] public CInt32 MaxRunners { get; set; }

		public CanNPCRun(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
