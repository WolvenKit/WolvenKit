using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimNode_ForegroundSegmentEnd : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] 
		[RED("isAlwaysEnabledForHighEndHardware")] 
		public CBool IsAlwaysEnabledForHighEndHardware
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public animAnimNode_ForegroundSegmentEnd()
		{
			Id = uint.MaxValue;
			InputLink = new animPoseLink();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
