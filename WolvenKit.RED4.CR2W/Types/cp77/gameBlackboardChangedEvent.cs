using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBlackboardChangedEvent : redEvent
	{
		[Ordinal(0)] [RED("definition")] public CHandle<gamebbScriptDefinition> Definition { get; set; }
		[Ordinal(1)] [RED("id")] public gamebbScriptID Id { get; set; }

		public gameBlackboardChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
