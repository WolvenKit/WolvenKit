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
			get
			{
				if (_thumbnailWidgetPackage == null)
				{
					_thumbnailWidgetPackage = (SThumbnailWidgetPackage) CR2WTypeManager.Create("SThumbnailWidgetPackage", "thumbnailWidgetPackage", cr2w, this);
				}
				return _thumbnailWidgetPackage;
			}
			set
			{
				if (_thumbnailWidgetPackage == value)
				{
					return;
				}
				_thumbnailWidgetPackage = value;
				PropertySet(this);
			}
		}

		public ThumbnailUI(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
