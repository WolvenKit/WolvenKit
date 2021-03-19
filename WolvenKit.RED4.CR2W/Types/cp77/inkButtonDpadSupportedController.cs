using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkButtonDpadSupportedController : inkButtonAnimatedController
	{
		private wCHandle<inkWidget> _targetPath_DpadUp;
		private wCHandle<inkWidget> _targetPath_DpadDown;
		private wCHandle<inkWidget> _targetPath_DpadLeft;
		private wCHandle<inkWidget> _targetPath_DpadRight;

		[Ordinal(22)] 
		[RED("targetPath_DpadUp")] 
		public wCHandle<inkWidget> TargetPath_DpadUp
		{
			get => GetProperty(ref _targetPath_DpadUp);
			set => SetProperty(ref _targetPath_DpadUp, value);
		}

		[Ordinal(23)] 
		[RED("targetPath_DpadDown")] 
		public wCHandle<inkWidget> TargetPath_DpadDown
		{
			get => GetProperty(ref _targetPath_DpadDown);
			set => SetProperty(ref _targetPath_DpadDown, value);
		}

		[Ordinal(24)] 
		[RED("targetPath_DpadLeft")] 
		public wCHandle<inkWidget> TargetPath_DpadLeft
		{
			get => GetProperty(ref _targetPath_DpadLeft);
			set => SetProperty(ref _targetPath_DpadLeft, value);
		}

		[Ordinal(25)] 
		[RED("targetPath_DpadRight")] 
		public wCHandle<inkWidget> TargetPath_DpadRight
		{
			get => GetProperty(ref _targetPath_DpadRight);
			set => SetProperty(ref _targetPath_DpadRight, value);
		}

		public inkButtonDpadSupportedController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
