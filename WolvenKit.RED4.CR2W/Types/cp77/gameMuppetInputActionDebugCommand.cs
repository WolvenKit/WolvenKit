using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMuppetInputActionDebugCommand : gameIMuppetInputAction
	{
		private CEnum<gameMuppetDebugCommand> _debugCommand;

		[Ordinal(0)] 
		[RED("debugCommand")] 
		public CEnum<gameMuppetDebugCommand> DebugCommand
		{
			get => GetProperty(ref _debugCommand);
			set => SetProperty(ref _debugCommand, value);
		}

		public gameMuppetInputActionDebugCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
