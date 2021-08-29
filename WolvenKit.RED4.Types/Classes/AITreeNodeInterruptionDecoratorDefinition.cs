using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITreeNodeInterruptionDecoratorDefinition : AICTreeNodeDecoratorDefinition
	{
		private CArray<CHandle<AIInterruptionHandlerDefinition>> _interruptions;

		[Ordinal(1)] 
		[RED("interruptions")] 
		public CArray<CHandle<AIInterruptionHandlerDefinition>> Interruptions
		{
			get => GetProperty(ref _interruptions);
			set => SetProperty(ref _interruptions, value);
		}
	}
}
