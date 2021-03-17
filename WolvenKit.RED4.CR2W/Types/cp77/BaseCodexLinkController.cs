using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseCodexLinkController : inkWidgetLogicController
	{
		private inkImageWidgetReference _linkImage;
		private inkTextWidgetReference _linkLabel;
		private CHandle<inkanimProxy> _animProxy;

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

		public BaseCodexLinkController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
