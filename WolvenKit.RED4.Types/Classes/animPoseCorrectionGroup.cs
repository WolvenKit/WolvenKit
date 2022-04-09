using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animPoseCorrectionGroup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("poseCorrections", 2)] 
		public CStatic<animPoseCorrection> PoseCorrections
		{
			get => GetPropertyValue<CStatic<animPoseCorrection>>();
			set => SetPropertyValue<CStatic<animPoseCorrection>>(value);
		}

		public animPoseCorrectionGroup()
		{
			PoseCorrections = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
