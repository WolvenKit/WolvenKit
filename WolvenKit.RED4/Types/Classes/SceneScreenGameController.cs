using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SceneScreenGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("onQuestAnimChangeListener")] 
		public CHandle<redCallbackObject> OnQuestAnimChangeListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public SceneScreenGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
