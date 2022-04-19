using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiMinimapQuestMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("questMappin")] 
		public CWeakHandle<gamemappinsQuestMappin> QuestMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>(value);
		}

		public gameuiMinimapQuestMappinController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
