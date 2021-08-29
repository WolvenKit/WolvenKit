using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class QuestAnimationMappinController : gameuiQuestMappinController
	{
		private CWeakHandle<gamemappinsQuestMappin> _mappin;
		private CHandle<gamedataUIAnimation_Record> _animationRecord;
		private CHandle<inkanimProxy> _animProxy;
		private CBool _playing;

		[Ordinal(14)] 
		[RED("mappin")] 
		public CWeakHandle<gamemappinsQuestMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(15)] 
		[RED("animationRecord")] 
		public CHandle<gamedataUIAnimation_Record> AnimationRecord
		{
			get => GetProperty(ref _animationRecord);
			set => SetProperty(ref _animationRecord, value);
		}

		[Ordinal(16)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(17)] 
		[RED("playing")] 
		public CBool Playing
		{
			get => GetProperty(ref _playing);
			set => SetProperty(ref _playing, value);
		}
	}
}
