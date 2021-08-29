using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAvailableExposureMethodResult : RedBaseClass
	{
		private CFloat _distanceToTarget;
		private CEnum<AICoverExposureMethod> _method;

		[Ordinal(0)] 
		[RED("distanceToTarget")] 
		public CFloat DistanceToTarget
		{
			get => GetProperty(ref _distanceToTarget);
			set => SetProperty(ref _distanceToTarget, value);
		}

		[Ordinal(1)] 
		[RED("method")] 
		public CEnum<AICoverExposureMethod> Method
		{
			get => GetProperty(ref _method);
			set => SetProperty(ref _method, value);
		}
	}
}
