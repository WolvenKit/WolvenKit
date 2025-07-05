using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameeventsCameraShakeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("shakeStrength")] 
		public CFloat ShakeStrength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameeventsCameraShakeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
