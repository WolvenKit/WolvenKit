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
			ResourceId = new scnRidResourceId { Id = uint.MaxValue };
			AnimationSN = new scnRidSerialNumber { SerialNumber = uint.MaxValue };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
