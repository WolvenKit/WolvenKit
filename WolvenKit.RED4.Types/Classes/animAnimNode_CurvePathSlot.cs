using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_CurvePathSlot : animAnimNode_Base
	{
		private animPoseLink _input;

		[Ordinal(11)] 
		[RED("input")] 
		public animPoseLink Input
		{
			get => GetProperty(ref _input);
			set => SetProperty(ref _input, value);
		}
	}
}
