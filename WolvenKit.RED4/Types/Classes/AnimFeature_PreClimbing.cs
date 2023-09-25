using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_PreClimbing : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("edgePositionLS")] 
		public Vector4 EdgePositionLS
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("valid")] 
		public CFloat Valid
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_PreClimbing()
		{
			EdgePositionLS = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
