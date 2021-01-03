using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerStateMachinePrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("listenerInt")] public CUInt32 ListenerInt { get; set; }
		[Ordinal(1)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(2)]  [RED("prevValue")] public CInt32 PrevValue { get; set; }

		public PlayerStateMachinePrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
