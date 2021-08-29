using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSendAICommandNodeDefinition : questAICommandNodeBase
	{
		private gameEntityReference _puppet;
		private CHandle<questAICommandParams> _commandParams;

		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get => GetProperty(ref _puppet);
			set => SetProperty(ref _puppet, value);
		}

		[Ordinal(3)] 
		[RED("commandParams")] 
		public CHandle<questAICommandParams> CommandParams
		{
			get => GetProperty(ref _commandParams);
			set => SetProperty(ref _commandParams, value);
		}
	}
}
