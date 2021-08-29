using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnRidCameraAnimationSRRef : RedBaseClass
	{
		private scnRidResourceId _resourceId;
		private scnRidSerialNumber _animationSN;

		[Ordinal(0)] 
		[RED("resourceId")] 
		public scnRidResourceId ResourceId
		{
			get => GetProperty(ref _resourceId);
			set => SetProperty(ref _resourceId, value);
		}

		[Ordinal(1)] 
		[RED("animationSN")] 
		public scnRidSerialNumber AnimationSN
		{
			get => GetProperty(ref _animationSN);
			set => SetProperty(ref _animationSN, value);
		}
	}
}
