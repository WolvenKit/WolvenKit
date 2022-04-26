using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsPlayAnimEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("blendIn")] 
		public CFloat BlendIn
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("blendOut")] 
		public CFloat BlendOut
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("clipFront")] 
		public CFloat ClipFront
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("clipEnd")] 
		public CFloat ClipEnd
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("stretch")] 
		public CFloat Stretch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("blendInCurve")] 
		public CEnum<scnEasingType> BlendInCurve
		{
			get => GetPropertyValue<CEnum<scnEasingType>>();
			set => SetPropertyValue<CEnum<scnEasingType>>(value);
		}

		[Ordinal(6)] 
		[RED("blendOutCurve")] 
		public CEnum<scnEasingType> BlendOutCurve
		{
			get => GetPropertyValue<CEnum<scnEasingType>>();
			set => SetPropertyValue<CEnum<scnEasingType>>(value);
		}

		public scneventsPlayAnimEventData()
		{
			Stretch = 1.000000F;
			BlendInCurve = Enums.scnEasingType.SinusoidalEaseInOut;
			BlendOutCurve = Enums.scnEasingType.SinusoidalEaseInOut;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
