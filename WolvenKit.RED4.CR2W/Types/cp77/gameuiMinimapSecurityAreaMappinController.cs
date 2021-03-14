using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapSecurityAreaMappinController : gameuiBaseMinimapMappinController
	{
		private CBool _playerInArea;
		private CHandle<gamemappinsIArea> _area;
		private inkShapeWidgetReference _areaShapeWidget;

		[Ordinal(14)] 
		[RED("playerInArea")] 
		public CBool PlayerInArea
		{
			get
			{
				if (_playerInArea == null)
				{
					_playerInArea = (CBool) CR2WTypeManager.Create("Bool", "playerInArea", cr2w, this);
				}
				return _playerInArea;
			}
			set
			{
				if (_playerInArea == value)
				{
					return;
				}
				_playerInArea = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("area")] 
		public CHandle<gamemappinsIArea> Area
		{
			get
			{
				if (_area == null)
				{
					_area = (CHandle<gamemappinsIArea>) CR2WTypeManager.Create("handle:gamemappinsIArea", "area", cr2w, this);
				}
				return _area;
			}
			set
			{
				if (_area == value)
				{
					return;
				}
				_area = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
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

		public gameuiMinimapSecurityAreaMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
