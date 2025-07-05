using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleAboutToExplodeTimerRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("red")] 
		public CBool Red
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("abort")] 
		public CBool Abort
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public VehicleAboutToExplodeTimerRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
