using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMinimapQuestMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(14)] 
		[RED("questMappin")] 
		public CWeakHandle<gamemappinsQuestMappin> QuestMappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>(value);
		}
	}
}
