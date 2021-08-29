using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AINPCCommandEvent : AIAIEvent
	{
		private CHandle<AICommand> _command;

		[Ordinal(2)] 
		[RED("command")] 
		public CHandle<AICommand> Command
		{
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}
	}
}
