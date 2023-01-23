using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TCSInputXYAxisEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("isAnyInput")] 
		public CBool IsAnyInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public TCSInputXYAxisEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
