using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapRemotePlayerMappinController : gameuiBaseMinimapMappinController
	{
		private inkWidgetReference _rootWidget;
		private inkWidgetReference _shapeWidget;
		private inkWidgetReference _dataWidget;
		private wCHandle<gamemappinsRemotePlayerMappin> _playerMappin;

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public inkWidgetReference RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "rootWidget", cr2w, this);
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
		[RED("shapeWidget")] 
		public inkWidgetReference ShapeWidget
		{
			get
			{
				if (_shapeWidget == null)
				{
					_shapeWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "shapeWidget", cr2w, this);
				}
				return _shapeWidget;
			}
			set
			{
				if (_shapeWidget == value)
				{
					return;
				}
				_shapeWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("dataWidget")] 
		public inkWidgetReference DataWidget
		{
			get
			{
				if (_dataWidget == null)
				{
					_dataWidget = (inkWidgetReference) CR2WTypeManager.Create("inkWidgetReference", "dataWidget", cr2w, this);
				}
				return _dataWidget;
			}
			set
			{
				if (_dataWidget == value)
				{
					return;
				}
				_dataWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("playerMappin")] 
		public wCHandle<gamemappinsRemotePlayerMappin> PlayerMappin
		{
			get
			{
				if (_playerMappin == null)
				{
					_playerMappin = (wCHandle<gamemappinsRemotePlayerMappin>) CR2WTypeManager.Create("whandle:gamemappinsRemotePlayerMappin", "playerMappin", cr2w, this);
				}
				return _playerMappin;
			}
			set
			{
				if (_playerMappin == value)
				{
					return;
				}
				_playerMappin = value;
				PropertySet(this);
			}
		}

		public gameuiMinimapRemotePlayerMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
