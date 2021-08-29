using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AITreeArgumentsDefinition : RedBaseClass
	{
		private CArray<CHandle<AIArgumentDefinition>> _args;

		[Ordinal(0)] 
		[RED("args")] 
		public CArray<CHandle<AIArgumentDefinition>> Args
		{
			get => GetProperty(ref _args);
			set => SetProperty(ref _args, value);
		}
	}
}
