using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimationLogicController : inkWidgetLogicController
	{
		private inkImageWidgetReference _imageView;

		[Ordinal(1)] 
		[RED("imageView")] 
		public inkImageWidgetReference ImageView
		{
			get => GetProperty(ref _imageView);
			set => SetProperty(ref _imageView, value);
		}
	}
}
