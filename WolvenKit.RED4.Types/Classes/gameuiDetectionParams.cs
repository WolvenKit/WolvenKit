using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiDetectionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("detectionProgress")] 
		public CFloat DetectionProgress
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
