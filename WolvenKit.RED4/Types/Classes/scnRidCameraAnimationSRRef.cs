using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnRidCameraAnimationSRRef : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("resourceId")] 
		public scnRidResourceId ResourceId
		{
			get => GetPropertyValue<scnRidResourceId>();
			set => SetPropertyValue<scnRidResourceId>(value);
		}

		[Ordinal(1)] 
		[RED("animationSN")] 
		public scnRidSerialNumber AnimationSN
		{
			get => GetPropertyValue<scnRidSerialNumber>();
			set => SetPropertyValue<scnRidSerialNumber>(value);
		}

		public scnRidCameraAnimationSRRef()
		{
			ResourceId = new() { Id = 4294967295 };
			AnimationSN = new() { SerialNumber = 4294967295 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
