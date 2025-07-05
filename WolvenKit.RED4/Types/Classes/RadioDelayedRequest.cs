using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioDelayedRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<PlayRadioArgs> Data
		{
			get => GetPropertyValue<CHandle<PlayRadioArgs>>();
			set => SetPropertyValue<CHandle<PlayRadioArgs>>(value);
		}

		public RadioDelayedRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
