using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MountCommandHandlerTask : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("command")] public CHandle<AIArgumentMapping> Command { get; set; }
		[Ordinal(1)] [RED("mountEventData")] public CHandle<AIArgumentMapping> MountEventData { get; set; }
		[Ordinal(2)] [RED("callbackName")] public CName CallbackName { get; set; }

		public MountCommandHandlerTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
