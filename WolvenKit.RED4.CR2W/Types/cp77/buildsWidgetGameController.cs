using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class buildsWidgetGameController : gameuiWidgetGameController
	{
		private CArray<wCHandle<inkHorizontalPanelWidget>> _horizontalPanelsList;

		[Ordinal(2)] 
		[RED("horizontalPanelsList")] 
		public CArray<wCHandle<inkHorizontalPanelWidget>> HorizontalPanelsList
		{
			get
			{
				if (_horizontalPanelsList == null)
				{
					_horizontalPanelsList = (CArray<wCHandle<inkHorizontalPanelWidget>>) CR2WTypeManager.Create("array:whandle:inkHorizontalPanelWidget", "horizontalPanelsList", cr2w, this);
				}
				return _horizontalPanelsList;
			}
			set
			{
				if (_horizontalPanelsList == value)
				{
					return;
				}
				_horizontalPanelsList = value;
				PropertySet(this);
			}
		}

		public buildsWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
