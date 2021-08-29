using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DeadOnInitTask : AIbehaviortaskScript
	{
		private CBool _preventSkippingDeathAnimation;

		[Ordinal(0)] 
		[RED("preventSkippingDeathAnimation")] 
		public CBool PreventSkippingDeathAnimation
		{
			get => GetProperty(ref _preventSkippingDeathAnimation);
			set => SetProperty(ref _preventSkippingDeathAnimation, value);
		}
	}
}
