using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RemoveFromChainRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("requestSource")] 
		public entEntityID RequestSource
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public RemoveFromChainRequest()
		{
			RequestSource = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
