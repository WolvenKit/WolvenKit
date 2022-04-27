using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_TrajectoryFromMetaPose : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("metaPoseTrajectoryLs")] 
		public animTransformIndex MetaPoseTrajectoryLs
		{
			get => GetPropertyValue<animTransformIndex>();
			set => SetPropertyValue<animTransformIndex>(value);
		}

		public animAnimNode_TrajectoryFromMetaPose()
		{
			Id = 4294967295;
			InputLink = new();
			MetaPoseTrajectoryLs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
