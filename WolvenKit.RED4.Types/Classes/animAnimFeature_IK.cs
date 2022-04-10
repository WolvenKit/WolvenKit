using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_IK : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("point")] 
		public Vector4 Point
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("normal")] 
		public Vector4 Normal
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(2)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public animAnimFeature_IK()
		{
			Point = new() { W = 1.000000F };
			Normal = new() { Z = 1.000000F };
			Weight = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
