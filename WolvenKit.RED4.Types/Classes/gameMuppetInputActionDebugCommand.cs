using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputActionDebugCommand : gameIMuppetInputAction
	{
		private CEnum<gameMuppetDebugCommand> _debugCommand;

		[Ordinal(0)] 
		[RED("debugCommand")] 
		public CEnum<gameMuppetDebugCommand> DebugCommand
		{
			get => GetProperty(ref _debugCommand);
			set => SetProperty(ref _debugCommand, value);
		}
	}
}
