using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyButtonController : inkButtonController
	{
		private inkTextWidgetReference _labelText;
		private inkTextWidgetReference _levelText;
		private inkWidgetReference _frameHovered;
		private CHandle<inkanimProxy> _transparencyAnimationProxy;
		private CInt32 _index;

		[Ordinal(10)] 
		[RED("labelText")] 
		public inkTextWidgetReference LabelText
		{
			get => GetProperty(ref _labelText);
			set => SetProperty(ref _labelText, value);
		}

		[Ordinal(11)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetProperty(ref _levelText);
			set => SetProperty(ref _levelText, value);
		}

		[Ordinal(12)] 
		[RED("frameHovered")] 
		public inkWidgetReference FrameHovered
		{
			get => GetProperty(ref _frameHovered);
			set => SetProperty(ref _frameHovered, value);
		}

		[Ordinal(13)] 
		[RED("transparencyAnimationProxy")] 
		public CHandle<inkanimProxy> TransparencyAnimationProxy
		{
			get => GetProperty(ref _transparencyAnimationProxy);
			set => SetProperty(ref _transparencyAnimationProxy, value);
		}

		[Ordinal(14)] 
		[RED("index")] 
		public CInt32 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		public ProficiencyButtonController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
