using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameMuppetInputActionDebugCommand : gameIMuppetInputAction
	{
		[Ordinal(0)] 
		[RED("debugCommand")] 
		public CEnum<gameMuppetDebugCommand> DebugCommand
		{
			get => GetPropertyValue<CEnum<gameMuppetDebugCommand>>();
			set => SetPropertyValue<CEnum<gameMuppetDebugCommand>>(value);
		}
	}
}
