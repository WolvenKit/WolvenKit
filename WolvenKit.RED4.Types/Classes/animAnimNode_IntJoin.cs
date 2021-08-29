using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_IntJoin : animAnimNode_IntValue
	{
		private animIntLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animIntLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}
	}
}
