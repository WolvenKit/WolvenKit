using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class artist_test_area_r : gameuiHUDGameController
	{
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkCanvasWidget> _linesWidget;

		[Ordinal(9)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("linesWidget")] 
		public wCHandle<inkCanvasWidget> LinesWidget
		{
			get
			{
				if (_linesWidget == null)
				{
					_linesWidget = (wCHandle<inkCanvasWidget>) CR2WTypeManager.Create("whandle:inkCanvasWidget", "linesWidget", cr2w, this);
				}
				return _linesWidget;
			}
			set
			{
				if (_linesWidget == value)
				{
					return;
				}
				_linesWidget = value;
				PropertySet(this);
			}
		}

		public artist_test_area_r(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
