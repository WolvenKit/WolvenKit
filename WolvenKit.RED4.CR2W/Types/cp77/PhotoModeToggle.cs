using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeToggle : inkToggleController
	{
		private inkWidgetReference _selectedWidget;
		private inkWidgetReference _frameWidget;
		private inkImageWidgetReference _iconWidget;
		private inkTextWidgetReference _labelWidget;
		private wCHandle<PhotoModeTopBarController> _photoModeGroupController;
		private CHandle<inkanimProxy> _fadeAnim;
		private CHandle<inkanimProxy> _fade2Anim;

		[Ordinal(13)] 
		[RED("SelectedWidget")] 
		public inkWidgetReference SelectedWidget
		{
			get => GetProperty(ref _selectedWidget);
			set => SetProperty(ref _selectedWidget, value);
		}

		[Ordinal(14)] 
		[RED("FrameWidget")] 
		public inkWidgetReference FrameWidget
		{
			get => GetProperty(ref _frameWidget);
			set => SetProperty(ref _frameWidget, value);
		}

		[Ordinal(15)] 
		[RED("IconWidget")] 
		public inkImageWidgetReference IconWidget
		{
			get => GetProperty(ref _iconWidget);
			set => SetProperty(ref _iconWidget, value);
		}

		[Ordinal(16)] 
		[RED("LabelWidget")] 
		public inkTextWidgetReference LabelWidget
		{
			get => GetProperty(ref _labelWidget);
			set => SetProperty(ref _labelWidget, value);
		}

		[Ordinal(17)] 
		[RED("photoModeGroupController")] 
		public wCHandle<PhotoModeTopBarController> PhotoModeGroupController
		{
			get => GetProperty(ref _photoModeGroupController);
			set => SetProperty(ref _photoModeGroupController, value);
		}

		[Ordinal(18)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetProperty(ref _fadeAnim);
			set => SetProperty(ref _fadeAnim, value);
		}

		[Ordinal(19)] 
		[RED("fade2Anim")] 
		public CHandle<inkanimProxy> Fade2Anim
		{
			get => GetProperty(ref _fade2Anim);
			set => SetProperty(ref _fade2Anim, value);
		}

		public PhotoModeToggle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
