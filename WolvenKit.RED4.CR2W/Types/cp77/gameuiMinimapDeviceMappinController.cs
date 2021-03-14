using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapDeviceMappinController : gameuiBaseMinimapMappinController
	{
		private inkCircleWidgetReference _effectAreaWidget;

		[Ordinal(14)] 
		[RED("effectAreaWidget")] 
		public inkCircleWidgetReference EffectAreaWidget
		{
			get
			{
				if (_effectAreaWidget == null)
				{
					_effectAreaWidget = (inkCircleWidgetReference) CR2WTypeManager.Create("inkCircleWidgetReference", "effectAreaWidget", cr2w, this);
				}
				return _effectAreaWidget;
			}
			set
			{
				if (_effectAreaWidget == value)
				{
					return;
				}
				_effectAreaWidget = value;
				PropertySet(this);
			}
		}

		public gameuiMinimapDeviceMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
