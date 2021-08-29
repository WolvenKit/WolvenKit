using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameuiTutorialBracketLogicController : inkWidgetLogicController
	{
		private CHandle<inkanimProxy> _loopAnim;

		[Ordinal(1)] 
		[RED("loopAnim")] 
		public CHandle<inkanimProxy> LoopAnim
		{
			get => GetProperty(ref _loopAnim);
			set => SetProperty(ref _loopAnim, value);
		}
	}
}
