using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_MuzzleData : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("muzzleOffset")] 
		public Vector4 MuzzleOffset
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public AnimFeature_MuzzleData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
