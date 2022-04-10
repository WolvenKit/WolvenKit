using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameResetFppCameraEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("pitch")] 
		public CFloat Pitch
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameResetFppCameraEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
