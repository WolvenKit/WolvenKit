using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiMinimapQuestMappinController : gameuiBaseMinimapMappinController
	{
		private CWeakHandle<gamemappinsQuestMappin> _questMappin;

		[Ordinal(14)] 
		[RED("questMappin")] 
		public CWeakHandle<gamemappinsQuestMappin> QuestMappin
		{
			get => GetProperty(ref _questMappin);
			set => SetProperty(ref _questMappin, value);
		}
	}
}
