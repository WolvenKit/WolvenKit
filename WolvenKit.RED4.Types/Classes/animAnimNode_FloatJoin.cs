using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_FloatJoin : animAnimNode_FloatValue
	{
		private animFloatLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animFloatLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}
	}
}
