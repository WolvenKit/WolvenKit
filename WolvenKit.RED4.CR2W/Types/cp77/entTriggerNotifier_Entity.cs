using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entTriggerNotifier_Entity : worldITriggerAreaNotifer
	{
		[Ordinal(3)] [RED("entityRef")] public NodeRef EntityRef { get; set; }

		public entTriggerNotifier_Entity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
