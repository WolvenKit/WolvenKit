using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class animAnimFeature_DangleExternalInput : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("fictitiousAccelerationWs")] 
		public Vector4 FictitiousAccelerationWs
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		public animAnimFeature_DangleExternalInput()
		{
			FictitiousAccelerationWs = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
