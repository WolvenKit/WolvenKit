using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiDetectionParams : RedBaseClass
	{
		private CFloat _detectionProgress;

		[Ordinal(0)] 
		[RED("detectionProgress")] 
		public CFloat DetectionProgress
		{
			get => GetProperty(ref _detectionProgress);
			set => SetProperty(ref _detectionProgress, value);
		}
	}
}
