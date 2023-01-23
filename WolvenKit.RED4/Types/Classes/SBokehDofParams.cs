using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SBokehDofParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("enabled")] 
		public CBool Enabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("hexToCircleScale")] 
		public CFloat HexToCircleScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("usePhysicalSetup")] 
		public CBool UsePhysicalSetup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("planeInFocus")] 
		public CFloat PlaneInFocus
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("fStops")] 
		public CEnum<EApertureValue> FStops
		{
			get => GetPropertyValue<CEnum<EApertureValue>>();
			set => SetPropertyValue<CEnum<EApertureValue>>(value);
		}

		[Ordinal(5)] 
		[RED("bokehSizeMuliplier")] 
		public CFloat BokehSizeMuliplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SBokehDofParams()
		{
			HexToCircleScale = 1.000000F;
			PlaneInFocus = 3.000000F;
			FStops = Enums.EApertureValue.f_4_0;
			BokehSizeMuliplier = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
