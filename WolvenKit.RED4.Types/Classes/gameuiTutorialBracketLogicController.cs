using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTutorialBracketLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("loopAnim")] 
		public CHandle<inkanimProxy> LoopAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}
	}
}
