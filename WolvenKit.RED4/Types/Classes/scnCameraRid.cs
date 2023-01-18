using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCameraRid : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public scnRidTag Tag
		{
			get => GetPropertyValue<scnRidTag>();
			set => SetPropertyValue<scnRidTag>(value);
		}

		[Ordinal(1)] 
		[RED("animations")] 
		public CArray<scnCameraAnimationRid> Animations
		{
			get => GetPropertyValue<CArray<scnCameraAnimationRid>>();
			set => SetPropertyValue<CArray<scnCameraAnimationRid>>(value);
		}

		public scnCameraRid()
		{
			Tag = new() { SerialNumber = new() { SerialNumber = 4294967295 } };
			Animations = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
