using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThumbnailUI : ActionBool
	{
		private SThumbnailWidgetPackage _thumbnailWidgetPackage;

		[Ordinal(25)] 
		[RED("thumbnailWidgetPackage")] 
		public SThumbnailWidgetPackage ThumbnailWidgetPackage
		{
			get => GetProperty(ref _thumbnailWidgetPackage);
			set => SetProperty(ref _thumbnailWidgetPackage, value);
		}

		public ThumbnailUI(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
