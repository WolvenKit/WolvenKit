using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuickHackMappinController : gameuiInteractionMappinController
	{
		private inkWidgetReference _bar;
		private inkTextWidgetReference _header;
		private inkImageWidgetReference _iconWidgetActive;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<gamemappinsIMappin> _mappin;
		private CHandle<GameplayRoleMappinData> _data;

		[Ordinal(11)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get
			{
				if (_bar == null)
				{
					_bar = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "bar", cr2w, this);
				}
				return _bar;
			}
			set
			{
				if (_bar == value)
				{
					return;
				}
				_bar = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("header")] 
		public inkTextWidgetReference Header
		{
			get
			{
				if (_header == null)
				{
					_header = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "header", cr2w, this);
				}
				return _header;
			}
			set
			{
				if (_header == value)
				{
					return;
				}
				_header = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("iconWidgetActive")] 
		public inkImageWidgetReference IconWidgetActive
		{
			get
			{
				if (_iconWidgetActive == null)
				{
					_iconWidgetActive = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "iconWidgetActive", cr2w, this);
				}
				return _iconWidgetActive;
			}
			set
			{
				if (_iconWidgetActive == value)
				{
					return;
				}
				_iconWidgetActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
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

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<GameplayRoleMappinData> Data
		{
			get
			{
				if (_data == null)
				{
					_data = (CHandle<GameplayRoleMappinData>) CR2WTypeManager.Create("handle:GameplayRoleMappinData", "data", cr2w, this);
				}
				return _data;
			}
			set
			{
				if (_data == value)
				{
					return;
				}
				_data = value;
				PropertySet(this);
			}
		}

		public QuickHackMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
