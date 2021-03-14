using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApartmentScreenInkGameController : LcdScreenInkGameController
	{
		private wCHandle<inkImageWidget> _backgroundFrameWidget;

		[Ordinal(25)] 
		[RED("backgroundFrameWidget")] 
		public wCHandle<inkImageWidget> BackgroundFrameWidget
		{
			get
			{
				if (_backgroundFrameWidget == null)
				{
					_backgroundFrameWidget = (wCHandle<inkImageWidget>) CR2WTypeManager.Create("whandle:inkImageWidget", "backgroundFrameWidget", cr2w, this);
				}
				return _backgroundFrameWidget;
			}
			set
			{
				if (_backgroundFrameWidget == value)
				{
					return;
				}
				_backgroundFrameWidget = value;
				PropertySet(this);
			}
		}

		public ApartmentScreenInkGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
