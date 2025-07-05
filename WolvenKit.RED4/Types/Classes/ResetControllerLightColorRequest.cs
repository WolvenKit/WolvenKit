using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ResetControllerLightColorRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("notQuest")] 
		public CBool NotQuest
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ResetControllerLightColorRequest()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
