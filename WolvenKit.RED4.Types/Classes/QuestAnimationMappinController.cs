using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class QuestAnimationMappinController : gameuiQuestMappinController
	{
		[Ordinal(14)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsQuestMappin> Mappin
		{
			get => GetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>();
			set => SetPropertyValue<CWeakHandle<gamemappinsQuestMappin>>(value);
		}

		[Ordinal(15)] 
		[RED("animationRecord")] 
		public CHandle<gamedataUIAnimation_Record> AnimationRecord
		{
			get => GetPropertyValue<CHandle<gamedataUIAnimation_Record>>();
			set => SetPropertyValue<CHandle<gamedataUIAnimation_Record>>(value);
		}

		[Ordinal(16)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("playing")] 
		public CBool Playing
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public QuestAnimationMappinController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
