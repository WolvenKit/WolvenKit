using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AINPCCommandEvent : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("command")] 
		public CHandle<AICommand> Command
		{
			get => GetPropertyValue<CHandle<AICommand>>();
			set => SetPropertyValue<CHandle<AICommand>>(value);
		}
	}
}
