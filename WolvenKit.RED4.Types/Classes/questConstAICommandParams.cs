using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questConstAICommandParams : questAICommandParams
	{
		[Ordinal(0)] 
		[RED("command")] 
		public CHandle<AICommand> Command
		{
			get => GetPropertyValue<CHandle<AICommand>>();
			set => SetPropertyValue<CHandle<AICommand>>(value);
		}

		public questConstAICommandParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
