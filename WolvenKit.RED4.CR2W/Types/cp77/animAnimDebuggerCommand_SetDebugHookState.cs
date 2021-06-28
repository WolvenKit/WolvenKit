using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimDebuggerCommand_SetDebugHookState : animIAnimDebuggerCommand
	{

		public animAnimDebuggerCommand_SetDebugHookState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
