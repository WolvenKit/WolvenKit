using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiTutorialBracketLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("loopAnim")] 
		public CHandle<inkanimProxy> LoopAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public gameuiTutorialBracketLogicController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
