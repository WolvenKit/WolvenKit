using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GameplayMappinController : QuestMappinController
	{
		[Ordinal(33)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(34)] 
		[RED("isVisibleThroughWalls")] 
		public CBool IsVisibleThroughWalls
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public GameplayMappinController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
