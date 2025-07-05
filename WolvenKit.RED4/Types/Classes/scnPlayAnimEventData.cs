using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnPlayAnimEventData : RedBaseClass
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
		[RED("stretch")] 
		public CFloat Stretch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("bodyPartMask")] 
		public CName BodyPartMask
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scnPlayAnimEventData()
		{
			Stretch = 1.000000F;
			Weight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
