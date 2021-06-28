using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkButtonTintController : inkButtonController
	{
		private CColor _normalColor;
		private CColor _hoverColor;
		private CColor _pressColor;
		private CColor _disableColor;
		private inkWidgetReference _tintControlRef;

		[Ordinal(10)] 
		[RED("NormalColor")] 
		public CColor NormalColor
		{
			get => GetProperty(ref _normalColor);
			set => SetProperty(ref _normalColor, value);
		}

		[Ordinal(11)] 
		[RED("HoverColor")] 
		public CColor HoverColor
		{
			get => GetProperty(ref _hoverColor);
			set => SetProperty(ref _hoverColor, value);
		}

		[Ordinal(12)] 
		[RED("PressColor")] 
		public CColor PressColor
		{
			get => GetProperty(ref _pressColor);
			set => SetProperty(ref _pressColor, value);
		}

		[Ordinal(13)] 
		[RED("DisableColor")] 
		public CColor DisableColor
		{
			get => GetProperty(ref _disableColor);
			set => SetProperty(ref _disableColor, value);
		}

		[Ordinal(14)] 
		[RED("TintControlRef")] 
		public inkWidgetReference TintControlRef
		{
			get => GetProperty(ref _tintControlRef);
			set => SetProperty(ref _tintControlRef, value);
		}

		public inkButtonTintController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
