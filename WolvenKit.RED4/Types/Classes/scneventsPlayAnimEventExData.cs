using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scneventsPlayAnimEventExData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("basic")] 
		public scneventsPlayAnimEventData Basic
		{
			get => GetPropertyValue<scneventsPlayAnimEventData>();
			set => SetPropertyValue<scneventsPlayAnimEventData>(value);
		}

		[Ordinal(1)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("bodyPartMask")] 
		public CName BodyPartMask
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public scneventsPlayAnimEventExData()
		{
			Basic = new scneventsPlayAnimEventData { Stretch = 1.000000F, BlendInCurve = Enums.scnEasingType.SinusoidalEaseInOut, BlendOutCurve = Enums.scnEasingType.SinusoidalEaseInOut };
			Weight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
