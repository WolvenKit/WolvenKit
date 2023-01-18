using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RevealNetworkRequestRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("target")] 
		public entEntityID Target
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RevealNetworkRequestRequest()
		{
			Target = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
