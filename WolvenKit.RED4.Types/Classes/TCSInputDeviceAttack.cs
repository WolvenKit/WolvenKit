using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TCSInputDeviceAttack : redEvent
	{
		[Ordinal(0)] 
		[RED("value")] 
		public CBool Value
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TCSInputDeviceAttack()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
