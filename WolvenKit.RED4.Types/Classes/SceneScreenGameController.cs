using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SceneScreenGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("onQuestAnimChangeListener")] 
		public CHandle<redCallbackObject> OnQuestAnimChangeListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}
	}
}
