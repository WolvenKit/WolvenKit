using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiBriefingGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("briefingPlayerType")] 
		public CEnum<questBriefingPlayerType> BriefingPlayerType
		{
			get => GetPropertyValue<CEnum<questBriefingPlayerType>>();
			set => SetPropertyValue<CEnum<questBriefingPlayerType>>(value);
		}

		public gameuiBriefingGameController()
		{
			BriefingPlayerType = Enums.questBriefingPlayerType.Hud;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
