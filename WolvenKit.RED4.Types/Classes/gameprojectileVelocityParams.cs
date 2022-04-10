using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameprojectileVelocityParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("xFactor")] 
		public CFloat XFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("yFactor")] 
		public CFloat YFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("zFactor")] 
		public CFloat ZFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameprojectileVelocityParams()
		{
			XFactor = 1.000000F;
			YFactor = 1.000000F;
			ZFactor = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
