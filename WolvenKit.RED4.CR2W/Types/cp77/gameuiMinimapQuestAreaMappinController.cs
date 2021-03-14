using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapQuestAreaMappinController : gameuiBaseMinimapMappinController
	{
		private inkShapeWidgetReference _areaShapeWidget;

		[Ordinal(14)] 
		[RED("areaShapeWidget")] 
		public inkShapeWidgetReference AreaShapeWidget
		{
			get
			{
				if (_areaShapeWidget == null)
				{
					_areaShapeWidget = (inkShapeWidgetReference) CR2WTypeManager.Create("inkShapeWidgetReference", "areaShapeWidget", cr2w, this);
				}
				return _areaShapeWidget;
			}
			set
			{
				if (_areaShapeWidget == value)
				{
					return;
				}
				_areaShapeWidget = value;
				PropertySet(this);
			}
		}

		public gameuiMinimapQuestAreaMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
