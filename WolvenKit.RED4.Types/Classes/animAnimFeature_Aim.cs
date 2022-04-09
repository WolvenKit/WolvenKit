using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_Aim : animAnimFeature_BasicAim
	{
		[Ordinal(2)] 
		[RED("aimPoint")] 
		public Vector4 AimPoint
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimFeature_Aim()
		{
			AimPoint = new() { Y = 1.000000F, W = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
