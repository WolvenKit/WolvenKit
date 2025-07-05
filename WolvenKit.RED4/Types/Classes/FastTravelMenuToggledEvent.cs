using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastTravelMenuToggledEvent : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FastTravelMenuToggledEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
