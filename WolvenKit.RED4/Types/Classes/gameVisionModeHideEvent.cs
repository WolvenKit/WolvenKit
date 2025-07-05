using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionModeHideEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("hide")] 
		public CBool Hide
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<gameVisionModeType> Type
		{
			get => GetPropertyValue<CEnum<gameVisionModeType>>();
			set => SetPropertyValue<CEnum<gameVisionModeType>>(value);
		}

		public gameVisionModeHideEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
