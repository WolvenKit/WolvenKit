using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animPoseCorrectionGroup : RedBaseClass
	{
		private CStatic<animPoseCorrection> _poseCorrections;

		[Ordinal(0)] 
		[RED("poseCorrections", 2)] 
		public CStatic<animPoseCorrection> PoseCorrections
		{
			get => GetProperty(ref _poseCorrections);
			set => SetProperty(ref _poseCorrections, value);
		}
	}
}
