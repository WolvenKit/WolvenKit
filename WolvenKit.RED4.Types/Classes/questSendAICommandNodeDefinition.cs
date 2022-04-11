using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSendAICommandNodeDefinition : questAICommandNodeBase
	{
		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("commandParams")] 
		public CHandle<questAICommandParams> CommandParams
		{
			get => GetPropertyValue<CHandle<questAICommandParams>>();
			set => SetPropertyValue<CHandle<questAICommandParams>>(value);
		}

		public questSendAICommandNodeDefinition()
		{
			Sockets = new();
			Id = 65535;
			Puppet = new() { Names = new() };
		}
	}
}
