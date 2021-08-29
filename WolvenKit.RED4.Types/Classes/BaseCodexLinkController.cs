using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BaseCodexLinkController : inkWidgetLogicController
	{
		private inkImageWidgetReference _linkImage;
		private inkTextWidgetReference _linkLabel;
		private CHandle<inkanimProxy> _animProxy;
		private CBool _isInteractive;

		[Ordinal(1)] 
		[RED("linkImage")] 
		public inkImageWidgetReference LinkImage
		{
			get => GetProperty(ref _linkImage);
			set => SetProperty(ref _linkImage, value);
		}

		[Ordinal(2)] 
		[RED("linkLabel")] 
		public inkTextWidgetReference LinkLabel
		{
			get => GetProperty(ref _linkLabel);
			set => SetProperty(ref _linkLabel, value);
		}

		[Ordinal(3)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(4)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}
	}
}
