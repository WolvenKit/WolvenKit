using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBaseMinimapMappinController : gameuiMappinBaseController
	{
		private CEnum<gameuiEIconOrientation> _iconOrientation;
		private inkWidgetReference _fixedOrientationWidget;
		private inkWidgetReference _clampArrowWidget;
		private wCHandle<gamemappinsIMappin> _mappin;
		private wCHandle<inkWidget> _root;
		private wCHandle<inkWidget> _aboveWidget;
		private wCHandle<inkWidget> _belowWidget;

		[Ordinal(7)] 
		[RED("iconOrientation")] 
		public CEnum<gameuiEIconOrientation> IconOrientation
		{
			get
			{
				if (_iconOrientation == null)
				{
					_iconOrientation = (CEnum<gameuiEIconOrientation>) CR2WTypeManager.Create("gameuiEIconOrientation", "iconOrientation", cr2w, this);
				}
				return _iconOrientation;
			}
			set
			{
				if (_iconOrientation == value)
				{
					return;
				}
				_iconOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("fixedOrientationWidget")] 
		public inkWidgetReference FixedOrientationWidget
		{
			get
			{
				if (_fixedOrientationWidget == null)
				{
					_fixedOrientationWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "fixedOrientationWidget", cr2w, this);
				}
				return _fixedOrientationWidget;
			}
			set
			{
				if (_fixedOrientationWidget == value)
				{
					return;
				}
				_fixedOrientationWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("clampArrowWidget")] 
		public inkWidgetReference ClampArrowWidget
		{
			get
			{
				if (_clampArrowWidget == null)
				{
					_clampArrowWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "clampArrowWidget", cr2w, this);
				}
				return _clampArrowWidget;
			}
			set
			{
				if (_clampArrowWidget == value)
				{
					return;
				}
				_clampArrowWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get
			{
				if (_mappin == null)
				{
					_mappin = (wCHandle<gamemappinsIMappin>) CR2WTypeManager.Create("whandle:gamemappinsIMappin", "mappin", cr2w, this);
				}
				return _mappin;
			}
			set
			{
				if (_mappin == value)
				{
					return;
				}
				_mappin = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get
			{
				if (_root == null)
				{
					_root = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "root", cr2w, this);
				}
				return _root;
			}
			set
			{
				if (_root == value)
				{
					return;
				}
				_root = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("aboveWidget")] 
		public wCHandle<inkWidget> AboveWidget
		{
			get
			{
				if (_aboveWidget == null)
				{
					_aboveWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "aboveWidget", cr2w, this);
				}
				return _aboveWidget;
			}
			set
			{
				if (_aboveWidget == value)
				{
					return;
				}
				_aboveWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("belowWidget")] 
		public wCHandle<inkWidget> BelowWidget
		{
			get
			{
				if (_belowWidget == null)
				{
					_belowWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "belowWidget", cr2w, this);
				}
				return _belowWidget;
			}
			set
			{
				if (_belowWidget == value)
				{
					return;
				}
				_belowWidget = value;
				PropertySet(this);
			}
		}

		public gameuiBaseMinimapMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
