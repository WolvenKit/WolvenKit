using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questConstAICommandParams : questAICommandParams
	{
		private CHandle<AICommand> _command;

		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AICommand> Command
		{
			get => GetProperty(ref _command);
			set => SetProperty(ref _command, value);
		}
	}
}
