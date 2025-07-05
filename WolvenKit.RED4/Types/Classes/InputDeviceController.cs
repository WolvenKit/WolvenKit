using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InputDeviceController : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("isStarted")] 
		public CBool IsStarted
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public InputDeviceController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
