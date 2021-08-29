using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneScreenGameController : gameuiWidgetGameController
	{
		private CHandle<redCallbackObject> _onQuestAnimChangeListener;

		[Ordinal(2)] 
		[RED("onQuestAnimChangeListener")] 
		public CHandle<redCallbackObject> OnQuestAnimChangeListener
		{
			get => GetProperty(ref _onQuestAnimChangeListener);
			set => SetProperty(ref _onQuestAnimChangeListener, value);
		}
	}
}
