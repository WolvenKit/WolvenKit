using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CancelDelamainRideRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("forceExit")] 
		public CBool ForceExit
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CancelDelamainRideRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
