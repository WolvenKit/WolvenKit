using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_VectorLatch : animAnimNode_VectorValue
	{
		private animVectorLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animVectorLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}
	}
}
