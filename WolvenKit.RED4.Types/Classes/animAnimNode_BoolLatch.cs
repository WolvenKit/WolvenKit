using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_BoolLatch : animAnimNode_BoolValue
	{
		private animBoolLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animBoolLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}
	}
}
