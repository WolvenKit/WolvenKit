using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class LerpToColorControllerLightRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("rgb")] 
		public Vector3 Rgb
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(1)] 
		[RED("timeToLerp")] 
		public CFloat TimeToLerp
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("useExponentialCurve")] 
		public CBool UseExponentialCurve
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public LerpToColorControllerLightRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
