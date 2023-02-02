using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVisionModeEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("activated")] 
		public CBool Activated
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

		public gameVisionModeEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
