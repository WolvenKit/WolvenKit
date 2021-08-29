using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimNode_TrajectoryFromMetaPose : animAnimNode_OnePoseInput
	{
		private animTransformIndex _metaPoseTrajectoryLs;

		[Ordinal(12)] 
		[RED("metaPoseTrajectoryLs")] 
		public animTransformIndex MetaPoseTrajectoryLs
		{
			get => GetProperty(ref _metaPoseTrajectoryLs);
			set => SetProperty(ref _metaPoseTrajectoryLs, value);
		}
	}
}
