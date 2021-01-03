using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AINPCCommandStateEvent : redEvent
	{
		[Ordinal(0)]  [RED("command")] public CHandle<AICommand> Command { get; set; }
		[Ordinal(1)]  [RED("newState")] public CEnum<AICommandState> NewState { get; set; }

		public AINPCCommandStateEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
