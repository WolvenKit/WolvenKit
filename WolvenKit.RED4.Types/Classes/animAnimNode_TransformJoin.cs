using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TransformJoin : animAnimNode_TransformValue
	{
		private animTransformLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animTransformLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}
	}
}
