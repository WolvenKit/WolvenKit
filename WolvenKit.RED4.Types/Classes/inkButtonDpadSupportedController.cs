using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkButtonDpadSupportedController : inkButtonAnimatedController
	{
		private CWeakHandle<inkWidget> _targetPath_DpadUp;
		private CWeakHandle<inkWidget> _targetPath_DpadDown;
		private CWeakHandle<inkWidget> _targetPath_DpadLeft;
		private CWeakHandle<inkWidget> _targetPath_DpadRight;

		[Ordinal(22)] 
		[RED("targetPath_DpadUp")] 
		public CWeakHandle<inkWidget> TargetPath_DpadUp
		{
			get => GetProperty(ref _targetPath_DpadUp);
			set => SetProperty(ref _targetPath_DpadUp, value);
		}

		[Ordinal(23)] 
		[RED("targetPath_DpadDown")] 
		public CWeakHandle<inkWidget> TargetPath_DpadDown
		{
			get => GetProperty(ref _targetPath_DpadDown);
			set => SetProperty(ref _targetPath_DpadDown, value);
		}

		[Ordinal(24)] 
		[RED("targetPath_DpadLeft")] 
		public CWeakHandle<inkWidget> TargetPath_DpadLeft
		{
			get => GetProperty(ref _targetPath_DpadLeft);
			set => SetProperty(ref _targetPath_DpadLeft, value);
		}

		[Ordinal(25)] 
		[RED("targetPath_DpadRight")] 
		public CWeakHandle<inkWidget> TargetPath_DpadRight
		{
			get => GetProperty(ref _targetPath_DpadRight);
			set => SetProperty(ref _targetPath_DpadRight, value);
		}
	}
}
