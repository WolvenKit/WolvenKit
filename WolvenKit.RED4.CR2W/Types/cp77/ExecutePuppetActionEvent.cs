using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExecutePuppetActionEvent : redEvent
	{
		[Ordinal(0)] [RED("actionID")] public TweakDBID ActionID { get; set; }
		[Ordinal(1)] [RED("action")] public CHandle<PuppetAction> Action { get; set; }

		public ExecutePuppetActionEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
