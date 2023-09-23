using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FridgeControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FridgeControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
