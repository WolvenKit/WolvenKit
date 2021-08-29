using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GameplayMappinController : QuestMappinController
	{
		private CHandle<inkanimProxy> _anim;
		private CBool _isVisibleThroughWalls;

		[Ordinal(33)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}

		[Ordinal(34)] 
		[RED("isVisibleThroughWalls")] 
		public CBool IsVisibleThroughWalls
		{
			get => GetProperty(ref _isVisibleThroughWalls);
			set => SetProperty(ref _isVisibleThroughWalls, value);
		}
	}
}
